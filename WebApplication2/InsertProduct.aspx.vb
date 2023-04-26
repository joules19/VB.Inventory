Public Class InsertProduct
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim con As New ClsMain
        con.InsertProduct(productName.Text, productType.Text)
        Response.Redirect("ProductList.aspx")
    End Sub
End Class