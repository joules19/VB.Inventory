Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlConnection

Public Class ClsData

    Dim sqlConnection As New SqlClient.SqlConnection

    Public Function Connection()
        Try
            Dim conString As String = ConfigurationManager.AppSettings("connectionString")
            sqlConnection = New SqlClient.SqlConnection(conString)

            If sqlConnection.State = ConnectionState.Closed Then
                sqlConnection.Open()
            End If
            Return sqlConnection
        Catch ex As Exception
            Connection = Nothing
        End Try
    End Function

    Public Sub CloseConnection()
        If sqlConnection.State = ConnectionState.Open Then
            sqlConnection.Close()
        End If
    End Sub

End Class
