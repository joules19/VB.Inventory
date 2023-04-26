<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateProduct.aspx.vb" Inherits="WebApplication2.UpdateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Product Name<br />
            <asp:TextBox ID="productName" runat="server"></asp:TextBox>
            <br />
            <br />
            Product Type<br />
            <asp:TextBox ID="productType" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="Id" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Button ID="cmdSave" runat="server" Text="Update Product Record" />
        </p>
        <p>
            &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
