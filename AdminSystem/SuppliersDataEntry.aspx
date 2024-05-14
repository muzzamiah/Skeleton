<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SuppliersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #txtAddressId {
            height: 43px;
        }
    </style>
</head>
<body id="txtAddressId">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 61px; top: 95px; position: absolute; height: 27px; width: 144px" Text="Supplier ID"></asp:Label>
        <p style="height: 282px; width: 380px">
            <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 215px; top: 94px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 297px; top: 420px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 217px; position: absolute; top: 420px; height: 26px;" Text="OK" />
        <asp:Label ID="lblContractStartDate" runat="server" style="z-index: 1; left: 61px; top: 170px; position: absolute; width: 144px" Text="Contract Start Date"></asp:Label>
        <asp:Label ID="lblContractEndDate" runat="server" style="z-index: 1; left: 61px; top: 207px; position: absolute" Text="Contract End Date" width="144px"></asp:Label>
        <asp:Label ID="lblContactPhoneNumber" runat="server" style="z-index: 1; left: 61px; top: 245px; position: absolute" Text="Contact Phone Number"></asp:Label>
        <asp:Label ID="lblContactEmailAddress" runat="server" style="z-index: 1; left: 61px; top: 286px; position: absolute" Text="Contact Email Address" width="144px"></asp:Label>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 61px; top: 132px; position: absolute" Text="Supplier Name" width="144px"></asp:Label>
        <asp:TextBox ID="txtContractStartDate" runat="server" height="22px" style="z-index: 1; left: 212px; top: 168px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContractEndDate" runat="server" height="22px" style="z-index: 1; left: 212px; top: 203px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierName" runat="server" height="22px" style="z-index: 1; left: 214px; top: 133px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContactPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 215px; top: 241px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContactEmailAddress" runat="server" height="22px" style="z-index: 1; left: 218px; top: 280px; position: absolute" width="128px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 247px; top: 331px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 63px; top: 382px; position: absolute" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
