Module Yuzu
    'Login Procedures
    Public Sub beginLogin(ByVal username As String, ByVal password As String)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT * FROM users WHERE username = '" + username + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                If password.Equals(sqlDataReader.Item("password")) Then
                    Main.userFname = sqlDataReader.Item("fname")
                    Main.userLname = sqlDataReader.Item("lname")
                    Main.Text &= " (Logged in as: " + sqlDataReader.Item("fname") + " " + sqlDataReader.Item("lname") + ")"
                    Main.lblCashier.Text = Main.userFname + " " + Main.userLname

                    sqlCommand.Dispose()
                    sqlDataReader.Close()
                    sqlConnection.Close()

                    Main.Show()
                    Login.Hide()
                Else
                    MessageBox.Show("Incorrect password. Please make sure that you type in the correct password.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    sqlCommand.Dispose()
                    sqlDataReader.Close()
                    sqlConnection.Close()
                End If
            Else
                MessageBox.Show("No such user found. Please make sure that the account exists.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
                sqlCommand.Dispose()
                sqlDataReader.Close()
                sqlConnection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Fetching Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    'Update order number on restart
    Public Sub updateOrderNumber()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT orderNumber AS orderNumber FROM transactionorders ORDER BY orderNumber DESC LIMIT 1"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Main.orderNumber = Val(sqlDataReader.Item("orderNumber")) + 1
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Updating Order Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    'Check if there are transactions in transactions table
    'and enable View Transactions button if true
    Public Sub checkTransactions()
        sqlDataReader.Close() 'Close reader in case it is open

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "SELECT * FROM transactions"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            If sqlDataReader.HasRows Then
                Main.btnViewTransactions.Visible = True
            Else
                Main.btnViewTransactions.Visible = False
            End If

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Checking Transactions Table", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    'Button Generation
    Public Sub generateButtons(ByVal category As String)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Main.pnlItems.Controls.Clear()   'empty panel
        Main.nameList.Clear()            'empty name list
        Main.btnClear.Enabled = True     'enable clear button

        Try
            'Select category to show based on which button is tapped or clicked.
            Select Case (category)
                Case "batter"
                    sqlQuery = "SELECT COUNT(productID) as itemCount FROM products WHERE productCategory = '" + category + "'"

                Case "regtop"
                    sqlQuery = "SELECT COUNT(productID) as itemCount FROM products WHERE productCategory = '" + category + "'"

                Case "premtop"
                    sqlQuery = "SELECT COUNT(productID) as itemCount FROM products WHERE productCategory = '" + category + "'"

                Case "sides"
                    sqlQuery = "SELECT COUNT(productID) as itemCount FROM products WHERE productCategory = '" + category + "'"

            End Select

            'Begin data pull and population
            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            sqlDataReader.Read()

            Dim itemCount As Integer = sqlDataReader.Item("itemCount")  'get item count

            sqlCommand.Dispose()
            sqlDataReader.Close()

            'Prep another query
            sqlQuery = "SELECT * FROM products WHERE productCategory = '" + category + "'"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlDataReader = sqlCommand.ExecuteReader
            While sqlDataReader.Read()
                Main.nameList.Add(sqlDataReader.Item("productName"))
            End While

            For i As Integer = 0 To itemCount - 1
                Main.newButton(i)
            Next

            sqlCommand.Dispose()
            sqlDataReader.Close()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Button Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    'Push orders into table
    Public Sub saveOrders()

    End Sub

    'Empty orders table
    Public Sub clearOrders(ByVal sender As String)
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            sqlQuery = "TRUNCATE TABLE orders"

            sqlCommand.Connection = sqlConnection
            sqlCommand.CommandText = sqlQuery

            sqlCommand.ExecuteNonQuery()
            sqlCommand.Dispose()
            sqlConnection.Close()

            If sender = "cancel" Or sender = "save" Then
                Main.originalPrice = 0
                Main.populateGrid()
                Main.lblTotalAmt.Text = "0"
                Main.lblChangeAmt.Text = "0"
                Main.lblDiscountAmt.Text = "0"
                Main.txtCash.Clear()
                Main.txtCustomerName.Clear()
                Main.cbxApplySeniorDiscount.CheckState = CheckState.Unchecked
                Main.pnlCheckout.Enabled = False

                If Main.btnRemoveItem.Enabled = True Then
                    Main.btnRemoveItem.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Truncating Table", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub
End Module
