Public Class Transactions
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateTransactionGrid()
    End Sub

    Private Sub Transactions_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Main.Show()
    End Sub

    Public Sub populateTransactionGrid()
        sqlDataReader.Close()   'Close reader if needed

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        'Pull transactions
        With sqlCommand
            .Connection = sqlConnection
            .CommandText = "SELECT `Transaction Date`, `Transaction Time`, `Customer Name`, `Cashier Name`, `Cash Tendered`, `Net Total`, Discount, `Cash Change` FROM transactions"
        End With

        'Populate data grid
        sqlDataAdapter.SelectCommand = sqlCommand
        sqlTransactionsDataTable.Clear()
        sqlDataAdapter.Fill(sqlTransactionsDataTable)
        dgvTransactions.DataSource = sqlTransactionsDataTable

        sqlCommand.Dispose()
        sqlConnection.Close()
    End Sub

    Public Sub populateTransactionItemsGrid(ByVal row As String)
        sqlDataReader.Close()   'Close reader if needed

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        If row = "refresh" Then
            sqlTransactionItemsDataTable.Clear()
            dgvTransactionItems.DataSource = sqlTransactionItemsDataTable

            sqlCommand.Dispose()
            sqlConnection.Close()
        Else
            'Pull items
            With sqlCommand
                .Connection = sqlConnection
                .CommandText = "SELECT Item, Amount, Quantity FROM transactionorders LEFT JOIN transactions ON transactions.orderNumber = transactionorders.orderNumber WHERE transactions.transactionID = " + row
            End With

            'Populate data grid
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlTransactionItemsDataTable.Clear()
            sqlDataAdapter.Fill(sqlTransactionItemsDataTable)
            dgvTransactionItems.DataSource = sqlTransactionItemsDataTable

            sqlCommand.Dispose()
            sqlConnection.Close()
        End If
    End Sub

    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        populateTransactionItemsGrid(dgvTransactions.CurrentRow.Index.ToString)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        populateTransactionGrid()
        populateTransactionItemsGrid("refresh")
    End Sub

    Public Sub populateDbQuickViews()
        sqlDataReader.Close()   'Close reader if needed

        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.Open()
        End If

        Try
            'Pull transactions
            With sqlCommand
                .Connection = sqlConnection
                .CommandText = "SELECT `Transaction Date`, `Transaction Time`, `Customer Name`, `Cashier Name`, `Cash Tendered`, `Net Total`, Discount, `Cash Change` FROM transactions"
            End With

            'Populate data grid
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlTransactionsDataTable.Clear()
            sqlDataAdapter.Fill(sqlTransactionsDataTable)
            dgvTransactions2.DataSource = sqlTransactionsDataTable

            sqlCommand.Dispose()

            'Pull products
            With sqlCommand
                .Connection = sqlConnection
                .CommandText = "SELECT productName AS `Product Name`, productCategory AS `Product Category`, price AS `Price` FROM products"
            End With

            'Populate data grid
            sqlDataAdapter.SelectCommand = sqlCommand
            sqlProductsDataTable.Clear()
            sqlDataAdapter.Fill(sqlProductsDataTable)
            dgvProducts.DataSource = sqlProductsDataTable

            sqlCommand.Dispose()

            'Pull users
            With sqlCommand
                .Connection = sqlConnection
                .CommandText = "SELECT username AS `Username`, fname AS `First Name`, lname AS `Last Name` FROM users"
            End With

            sqlDataAdapter.SelectCommand = sqlCommand
            sqlUsersDataTable.Clear()
            sqlDataAdapter.Fill(sqlUsersDataTable)
            dgvUsers.DataSource = sqlUsersDataTable

            sqlCommand.Dispose()
            sqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Populating Grid Views", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnViewDb_Click(sender As Object, e As EventArgs) Handles btnViewDb.Click
        populateDbQuickViews()
        pnlDatabaseQuickView.Visible = True
        btnRefreshDb.Visible = True
    End Sub

    Private Sub btnRefreshDb_Click(sender As Object, e As EventArgs) Handles btnRefreshDb.Click
        populateDbQuickViews()
    End Sub
End Class