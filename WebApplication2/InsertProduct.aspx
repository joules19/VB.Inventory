<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertProduct.aspx.vb" Inherits="WebApplication2.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Product Name<br />
        <asp:TextBox ID="productName" runat="server"></asp:TextBox>
        <br />
        <br />
        Product Type<br />
        <asp:TextBox ID="productType" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="cmdSave" runat="server" Text="Save Product Record" />
    </form>
</body>
</html>
