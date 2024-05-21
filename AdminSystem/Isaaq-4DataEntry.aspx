<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Isaaq-4DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 66px">
            <asp:Label ID="lblProductNameId" runat="server" style="z-index: 1; top: 23px; position: absolute; left: 17px" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 129px; top: 19px; position: absolute; bottom: 635px"></asp:TextBox>
            <asp:CheckBox ID="chkYes" runat="server" style="z-index: 1; left: 143px; top: 61px; position: absolute" Text="Yes" />
            <asp:CheckBox ID="chkNo" runat="server" style="z-index: 1; left: 257px; top: 63px; position: absolute" Text="No" />
            <asp:Label ID="lblProductAvailableId" runat="server" style="z-index: 1; left: 17px; top: 60px; position: absolute" Text="Product Availibility"></asp:Label>
            <asp:Label ID="lblProductAvailableId0" runat="server" style="z-index: 1; left: 17px; top: 60px; position: absolute" Text="Product Availibility"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtPriceId" runat="server" style="z-index: 1; left: 167px; top: 162px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblpriceId" runat="server" style="z-index: 1; left: 16px; top: 160px; position: absolute; width: 58px; height: 21px" Text="Price"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtQuantityId" runat="server" style="z-index: 1; top: 208px; position: absolute; width: 128px; left: 162px"></asp:TextBox>
            <asp:Label ID="lblQuantityId" runat="server" style="z-index: 1; left: 15px; top: 208px; position: absolute; width: 124px" Text="Quantity"></asp:Label>
        </p>
        <asp:Label ID="lblProductNoId" runat="server" style="z-index: 1; left: 19px; top: 102px; position: absolute" Text="Product Number"></asp:Label>
        <asp:TextBox ID="txtProductNoId" runat="server" style="z-index: 1; left: 168px; top: 105px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateOfOrderId" runat="server" style="z-index: 1; left: 10px; top: 252px; position: absolute" Text="Date Of Order"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 11px; top: 279px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Button ID="btmConfirm" runat="server" OnClick="btmConfirm_Click" style="z-index: 1; left: 5px; top: 502px; position: absolute" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 97px; top: 502px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
