<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Isaaq-4DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 66px">
            <asp:Label ID="lblProductNameId" runat="server" style="z-index: 1; top: 23px; position: absolute; left: 17px" Text="Product Name" height="19px" width="89px"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 275px; top: 21px; position: absolute; bottom: 607px; width: 124px;"></asp:TextBox>
            <asp:CheckBox ID="chkYes" runat="server" style="z-index: 1; left: 279px; top: 63px; position: absolute" Text="Yes" height="22px" width="124px" />
            <asp:CheckBox ID="chkNo" runat="server" style="z-index: 1; left: 354px; top: 62px; position: absolute" Text="No" height="22px" width="124px" />
            <asp:Label ID="lblProductAvailableId" runat="server" style="z-index: 1; left: 17px; top: 60px; position: absolute" Text="Product Availibility"></asp:Label>
            <asp:Label ID="lblProductAvailableId0" runat="server" style="z-index: 1; left: 17px; top: 60px; position: absolute" Text="Product Availibility" height="19px" width="89px"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtPriceId" runat="server" style="z-index: 1; left: 275px; top: 156px; position: absolute; width: 124px;" height="22px"></asp:TextBox>
            <asp:Label ID="lblpriceId" runat="server" style="z-index: 1; left: 16px; top: 160px; position: absolute; width: 89px; height: 19px" Text="Price"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtQuantityId" runat="server" style="z-index: 1; top: 207px; position: absolute; width: 124px; left: 275px" height="22px"></asp:TextBox>
            <asp:Label ID="lblQuantityId" runat="server" style="z-index: 1; left: 15px; top: 208px; position: absolute; width: 89px" Text="Quantity" height="19px"></asp:Label>
        </p>
        <asp:Label ID="lblProductNoId" runat="server" style="z-index: 1; left: 19px; top: 102px; position: absolute" Text="Product Number" height="19px" width="89px"></asp:Label>
        <asp:TextBox ID="txtProductNoId" runat="server" style="z-index: 1; left: 275px; top: 97px; position: absolute; width: 124px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblDateOfOrderId" runat="server" style="z-index: 1; left: 10px; top: 252px; position: absolute" Text="Date Of Order" height="19px" width="89px"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 7px; top: 301px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Button ID="btmConfirm" runat="server" OnClick="btmConfirm_Click" style="z-index: 1; left: 5px; top: 502px; position: absolute" Text="Confirm" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 97px; top: 502px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
