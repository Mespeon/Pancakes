Public Class Main
    Public nameList As ArrayList = New ArrayList    'used for storing button names
    Public originalPrice As String = 0
    Public orderNumber As String = 1
    Public userFname As String
    Public userLname As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSysTimeDate.Text = DateString + " " + TimeOfDay
        tmrTimeTick.Enabled = True
        populateGrid()
        Yuzu.updateOrderNumber()
        Yuzu.checkTransactions()
    End Sub

    Private Sub Main_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Login.Show()
    End Sub

    Private Sub tmrTimeTick_Tick(sender As Object, e As EventArgs) Handles tmrTimeTick.Tick
        lblSysTimeDate.Text = DateString + " " + TimeOfDay
    End Sub

    'Used for button generation
    Public Sub newButton(ByVal buttonNum As Integer)
        'Create object
        Dim thisButton As Button
        thisButton = New Button

        'Set properties
        thisButton.BackColor = Color.FromArgb("64", "64", "64")
        thisButton.ForeColor = Color.FromKnownColor(KnownColor.White)
        thisButton.FlatStyle = FlatStyle.Flat
        thisButton.FlatAppearance.BorderSize = 0
        thisButton.Enabled = True
        thisButton.Location = New Point(23, buttonNum * 79)
        thisButton.Name = "btnItem" & buttonNum.ToString
        thisButton.Size = New Size(220, 73)
        thisButton.Text = nameList(buttonNum)
        thisButton.Visible = True

        'Use tag to store "which button" information
        thisButton.Tag = buttonNum

        'Add button to click handler
        AddHandler thisButton.Click, AddressOf onButtonClick

        'Add to form controls collection
        pnlItems.Controls.Add(thisButton)   ' add buttons
    End Sub

    'Generated buttons' click handler
    Private Sub onButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        'Handle button click and see which is clicked
        Dim buttonNum As Integer
        Dim buttonText As String

        'Get Tag property
        If CType(sender, Button).Tag IsNot Nothing Then
            'Check if button Tag property has a valid integer
            If Integer.TryParse(CType(sender, Button).Tag.ToString, buttonNum) Then
                'A valid button number is now usable.
                buttonText = CType(sender, Button).Text
                processClick(buttonNum, buttonText)
            End If
        End If
    End Sub

    'Process the actual click from the buttons
    Private Sub processClick(ByVal buttonNum As Integer, ByVal buttonText As String)
        'MessageBox.Show("You clicked button: " & buttonText.ToString, "Click", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Add item to orders table
        Try
            'Select data to be pushed
            sqlQuery = "SELECT productName, price FROM products WHERE productName = '" + buttonText.ToString + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            Dim item As String = sqlDataReader.Item("productName")
            Dim quantity As String = 1
            Dim amount As String = sqlDataReader.Item("price")

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()

            checkDuplicates(item, quantity, amount)
            'insertItems(item, quantity, amount)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Item Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub checkDuplicates(ByVal item As String, ByVal quantity As String, ByVal amount As String)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Check if the item selected is already in the table.
        'If true, update the row instead.
        'If false, add a new row.
        Try
            sqlQuery = "SELECT * FROM orders WHERE Item = '" + item + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                updateItem(item, quantity, amount)
            Else
                insertItems(item, quantity, amount)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Checking Duplicates", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub insertItems(ByVal item As String, ByVal quantity As String, ByVal amount As String)
        sqlDataReader.Close()   'Close reader in case previous methods did not close it.

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "INSERT INTO orders(orderNumber, Item, Quantity, Amount) VALUES(" + orderNumber + ", '" + item + "', " + quantity + ", " + Decimal.Parse(amount).ToString + ")"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Inserting Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try

        populateGrid()
    End Sub

    Private Sub updateItem(ByVal item As String, ByVal quantity As String, ByVal amount As String)
        sqlDataReader.Close()   'Close reader in case previous methods did not close it.

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "UPDATE orders SET Quantity = Quantity + 1, Amount = Quantity * " + amount + " WHERE Item = '" + item + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Updating Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try

        populateGrid()
    End Sub

    Private Sub removeItem(ByVal item As String)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Remove data from table
        Try
            sqlQuery = "DELETE FROM orders WHERE Item = '" + item + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Removing Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try

        btnRemoveItem.Enabled = False
        populateGrid()
    End Sub

    Private Sub dgvOrderList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderList.CellContentClick
        btnRemoveItem.Enabled = True
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        removeItem(dgvOrderList.CurrentCell.Value)
    End Sub

    Public Sub populateGrid()
        sqlDataReader.Close()   'Close reader if needed

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Pull data from table
        With sqlCommand
            .Connection = sqlConnection
            .CommandText = "SELECT Item, Quantity, Amount FROM orders"
        End With

        'Populate data table and pass to data grid
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlDataTable.Clear()
        sqlDataAdapter.Fill(sqlDataTable)
        dgvOrderList.DataSource = sqlDataTable

        sqlCommand.Dispose()
        sqlConnection.Close()

        'Update total
        If dgvOrderList.RowCount > 0 Then
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            Try
                sqlQuery = "SELECT SUM(Amount) AS totalAmount FROM orders"

                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                sqlDataReader = sqlCommand.ExecuteReader
                sqlDataReader.Read()

                If sqlDataReader.HasRows Then
                    lblTotalAmt.Text = sqlDataReader.Item("totalAmount")
                    originalPrice = lblTotalAmt.Text
                End If

                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error Updating Total", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try
        End If

        'Control Checkout enabled
        If dgvOrderList.RowCount > 0 Then
            btnCheckout.Enabled = True
        Else
            btnCheckout.Enabled = False
        End If
    End Sub

    Private Sub btnBatter_Click(sender As Object, e As EventArgs) Handles btnBatter.Click
        Yuzu.generateButtons("batter")
    End Sub

    Private Sub btnRegTopping_Click(sender As Object, e As EventArgs) Handles btnRegTopping.Click
        Yuzu.generateButtons("regtop")
    End Sub

    Private Sub btnPremToppings_Click(sender As Object, e As EventArgs) Handles btnPremToppings.Click
        Yuzu.generateButtons("premtop")
    End Sub

    Private Sub btnSides_Click(sender As Object, e As EventArgs) Handles btnSides.Click
        Yuzu.generateButtons("sides")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pnlItems.Controls.Clear()
        btnClear.Enabled = False
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        pnlCheckout.Enabled = True
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim changeFormula As Double = Val(txtCash.Text) - (Val(lblTotalAmt.Text) - Val(lblDiscountAmt.Text))
        If changeFormula > 0 Then
            lblChangeAmt.Text = changeFormula
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCash.KeyDown
        Select Case e.KeyCode
            Case Keys.D1
                txtCash.Text &= 1
            Case Keys.D2
                txtCash.Text &= 2
            Case Keys.D3
                txtCash.Text &= 3
            Case Keys.D4
                txtCash.Text &= 4
            Case Keys.D5
                txtCash.Text &= 5
            Case Keys.D6
                txtCash.Text &= 6
            Case Keys.D7
                txtCash.Text &= 7
            Case Keys.D8
                txtCash.Text &= 8
            Case Keys.D9
                txtCash.Text &= 9
            Case Keys.D0
                txtCash.Text &= 0
        End Select
    End Sub

    Private Sub txtCash_Clicked(sender As Object, e As EventArgs) Handles txtCash.Click
        'Numpad.txtCashAmt.Text = txtCash.Text
        'Numpad.Show()
    End Sub

    Private Sub cbxApplySeniorDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles cbxApplySeniorDiscount.CheckedChanged
        Dim discountFormula = Val(lblTotalAmt.Text) - (Val(lblTotalAmt.Text) * 0.2)
        'Remove entered cash amount and calculated change if SCD is enabled after entering a cash amount.
        If Val(lblChangeAmt.Text) > 0 Then
            lblChangeAmt.Text = 0
            txtCash.Clear()
        End If

        If cbxApplySeniorDiscount.CheckState = CheckState.Checked Then
            'Apply Senior Discount
            lblDiscountAmt.Text = Val(lblTotalAmt.Text) * 0.2
            lblTotalAmt.Text = discountFormula
        Else
            'Remove Senior Discount
            lblDiscountAmt.Text = Val(lblDiscountAmt.Text) - Val(lblDiscountAmt.Text)
            lblTotalAmt.Text = originalPrice
        End If
    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged
        'SHOW ON-SCREEN KEYBOARD
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        txtCash.Text = Val(txtCash.Text) + 1000
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        txtCash.Text = Val(txtCash.Text) + 500
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        txtCash.Text = Val(txtCash.Text) + 100
    End Sub

    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        txtCash.Text = Val(txtCash.Text) + 50
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        txtCash.Text = Val(txtCash.Text) + 20
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs)
        txtCash.Text = Val(txtCash.Text) + 10
    End Sub

    Private Sub btnClearCash_Click(sender As Object, e As EventArgs) Handles btnClearCash.Click
        txtCash.Clear()
        btnSave.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCash.Text = "" Then
            MessageBox.Show("Please enter cash amount.", "No Cash Amount Entered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCustomerName.Text = "" Then
            MessageBox.Show("Please enter customer name.", "No Customer Name Entered", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If

            Try
                'Push order number to bridge table
                sqlQuery = "INSERT INTO transactionorders(orderNumber, Item, Quantity, Amount) SELECT orderNumber, Item, Quantity, Amount FROM orders WHERE orderNumber = " + orderNumber

                sqlCommand.Connection = sqlConnection
                sqlCommand.CommandText = sqlQuery

                sqlCommand.ExecuteNonQuery()
                sqlCommand.Dispose()

                Try
                    If sqlConnection.State = ConnectionState.Closed Then
                        sqlConnection.Open()
                    End If

                    'Create row for transaction
                    Dim cashier As String = userFname + " " + userLname
                    sqlQuery = "INSERT INTO transactions(`Transaction Date`, `Transaction Time`, orderNumber, `Customer Name`, `Cashier Name`, `Cash Tendered`, `Net Total`, Discount, `Cash Change`) VALUES(CURRENT_DATE(), CURRENT_TIME(), " + orderNumber + ", '" + txtCustomerName.Text + "', '" + cashier + "', " + Decimal.Parse(Val(txtCash.Text)).ToString + ", " + Decimal.Parse(Val(lblTotalAmt.Text)).ToString + ", " + Decimal.Parse(Val(lblDiscountAmt.Text)).ToString + ", " + Decimal.Parse(Val(lblChangeAmt.Text)).ToString + ")"

                    sqlCommand.Connection = sqlConnection
                    sqlCommand.CommandText = sqlQuery

                    sqlCommand.ExecuteNonQuery()
                    sqlCommand.Dispose()

                    MessageBox.Show("Transaction saved. Use the View Transactions button to review transactions.", "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString, "Error Saving Transaction Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sqlConnection.Close()
                End Try

                sqlConnection.Close()
                clearOrders("save")
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error Saving Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sqlConnection.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearOrders("cancel")
        btnSave.Enabled = False
    End Sub

    Private Sub btnViewTransactions_Click(sender As Object, e As EventArgs) Handles btnViewTransactions.Click
        Transactions.Show()
        Hide()
    End Sub
End Class
