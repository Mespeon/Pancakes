Imports MySql.Data.MySqlClient

Module Sibyl
    'Connection Variables
    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlDataReader As MySqlDataReader

    'SQL String - Always use this variable whenever a command is to be passed to sqlCommand
    Public sqlQuery As String

    Sub ConnectToDatabase()
        If sqlConnection.State = ConnectionState.Closed Then
            Try
                sqlConnection.ConnectionString = "SERVER = localhost; DATABASE = mirai_rms; UID = root; PWD ="
                sqlConnection.Open()
                'Login.lblConnectionStatus.Text = "ONLINE"
            Catch ex As Exception
                Dim ConnectionErrorPrompt = MessageBox.Show("The attempt to connect to the database failed. Please make sure that Apache and MySQL are enabled before attempting to connect again.", "Connection Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                If ConnectionErrorPrompt = MsgBoxResult.Retry Then
                    ConnectToDatabase()
                Else
                    End
                End If
            End Try
        End If
    End Sub

    Sub DisconnectToDatabase()
        If sqlConnection.State = ConnectionState.Open Then
            Try
                sqlConnection.Close()
                MessageBox.Show("Disconnection successful. You may now exit the program.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Disconnection failed.")
            End Try
        End If
    End Sub
End Module
