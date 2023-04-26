Imports System.Data
Imports System.Data.SqlClient

Public Class ClsMain

    Public Shared Sub InsertProduct(ProductName As String, ProductType As String)
        Dim cmd As New SqlClient.SqlCommand
        Dim objCon As New ClsData

        cmd.Connection = objCon.Connection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SpProduct_InsertProduct"
        cmd.Parameters.Add(New SqlClient.SqlParameter("ProductName", DbType.String)).Value = ProductName
        cmd.Parameters.Add(New SqlClient.SqlParameter("ProductType", DbType.String)).Value = ProductType


        cmd.ExecuteNonQuery()
        cmd.Dispose()

        objCon.CloseConnection()
    End Sub

    Public Shared Function GetProducts() As DataTable
        Dim cmd As New SqlClient.SqlCommand
        Dim objCon As New ClsData
        Dim data As New DataTable

        cmd.Connection = objCon.Connection()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SpProduct_GetProducts"

        Dim DA As New SqlClient.SqlDataAdapter(cmd)

        DA.Fill(data)
        GetProducts = data

        cmd.Dispose()
        objCon.CloseConnection()
    End Function

    Public Shared Function GetProduct(Id As Int32) As DataTable
        Dim con As New ClsData
        Dim cmd As New SqlClient.SqlCommand
        Dim data As New DataTable

        cmd.Connection = con.Connection
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SpProduct_GetProduct"
        cmd.Parameters.Add(New SqlParameter("Id", DbType.String)).Value = Id

        Dim DA As New SqlClient.SqlDataAdapter(cmd)
        DA.Fill(data)

        GetProduct = data

        cmd.Dispose()
        con.CloseConnection()

    End Function

    Public Shared Sub UpdateProduct(ProductName As String, ByVal ProductType As String, Id As Integer)
        Dim SqlCommand As New SqlClient.SqlCommand
        Dim con As New ClsData
        Dim command As New SqlClient.SqlCommand
        command.Connection = con.Connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "SpProduct_UpdateProduct"
        command.Parameters.AddWithValue("ProductName", DbType.String).Value = ProductName
        command.Parameters.Add(New SqlClient.SqlParameter("ProductType", DbType.String)).Value = ProductType
        command.Parameters.Add(New SqlClient.SqlParameter("Id", DbType.Int32)).Value = Id

        command.ExecuteNonQuery()
        command.Dispose()
        con.CloseConnection()

    End Sub

    Public Shared Sub DeleteProduct(Id As Integer)
        Dim cmd As New SqlClient.SqlCommand()
        Dim con As New ClsData

        cmd.Connection = con.Connection
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SpProduct_DeleteProduct"
        cmd.Parameters.Add(New SqlClient.SqlParameter("Id", DbType.Int32)).Value = Id

        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.CloseConnection()

    End Sub


End Class
