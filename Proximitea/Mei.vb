Imports MySql.Data.MySqlClient

Module Mei
    'Connection Variables
    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlDataReader As MySqlDataReader

    'For data grid population
    Public sqlDataAdapter As New MySqlDataAdapter
    Public sqlDataTable As New DataTable    'temporary order sheet
    Public sqlTransactionsDataTable As New DataTable
    Public sqlTransactionItemsDataTable As New DataTable
    Public sqlProductsDataTable As New DataTable
    Public sqlUsersDataTable As New DataTable

    'SQL Query String - default variable for SQL queries
    'USE THIS EVERY TIME A QUERY IS TO BE PASSED.
    Public sqlQuery As String

    Sub connect()
        If sqlConnection.State = ConnectionState.Closed Then
            Try
                sqlConnection.ConnectionString = "SERVER = localhost; DATABASE = proximitea; UID = root; PWD ="
                sqlConnection.Open()
            Catch ex As Exception
                Dim errorPrompt = MessageBox.Show("The attempt to connect to the database failed.\nError:\n" & ex.ToString & "\nRetry to connect?", "Connection Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If errorPrompt = MsgBoxResult.Yes Then
                    connect()
                Else
                    End
                End If
            End Try
        End If
    End Sub

    Sub disconnect()
        If sqlConnection.State = ConnectionState.Open Then
            Try
                sqlConnection.Close()
                'MessageBox.Show("Disconnection successful.", "Disconnect from Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Disconnection failed.\n" & ex.ToString, "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Module
