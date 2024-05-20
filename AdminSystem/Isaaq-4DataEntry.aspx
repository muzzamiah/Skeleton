<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Isaaq-4DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 66px">
            <asp:Label ID="lblProductNameId" runat="server" style="z-index: 1; top: 21px; position: absolute; left: 12px" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 129px; top: 19px; position: absolute; bottom: 635px"></asp:TextBox>
            <asp:Label ID="lblProductAvailableId" runat="server" style="z-index: 1; left: 17px; top: 60px; position: absolute" Text="Product Availibility"></asp:Label>
            <asp:CheckBox ID="chkYes" runat="server" style="z-index: 1; left: 143px; top: 61px; position: absolute" Text="Yes" />
            <asp:CheckBox ID="chkNo" runat="server" style="z-index: 1; left: 257px; top: 63px; position: absolute" Text="No" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
