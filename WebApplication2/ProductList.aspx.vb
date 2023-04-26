Public Class ProductList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim con As New ClsMain
        Dim data As DataTable = con.GetProducts()
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim id As String = GridView1.Rows(index).Cells(0).Text
        Dim con As New ClsMain

        If e.CommandName = "deleteRow" Then
            con.DeleteProduct(id)
            Response.Redirect("ProductList.aspx")
        ElseIf e.CommandName = "editRow" Then
            Response.Redirect("UpdateProduct.aspx?Id=" & id)
        End If
    End Sub

    Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Response.Redirect("InsertProduct.aspx")
    End Sub
End Class