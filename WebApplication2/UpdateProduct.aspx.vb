Public Class UpdateProduct
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If String.IsNullOrEmpty(Request.QueryString("Id")) Then
            Response.Redirect("ProductList.aspx")
        End If
        If Not IsPostBack Then
            Dim con As New ClsMain
            Dim data As DataTable = con.GetProduct(Request.QueryString("Id"))
            Dim r As DataRow = data.Rows(0)

            Id.Text = r("Id")
            productName.Text = r("ProductName").ToString
            productType.Text = r("ProductType").ToString

        End If
    End Sub

    Protected Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim con As New ClsMain
        con.UpdateProduct(productName.Text, productType.Text, Id.Text)
        Response.Redirect("ProductList.aspx")

    End Sub
End Class