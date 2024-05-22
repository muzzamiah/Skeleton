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
        <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 36px; top: 202px; position: absolute; height: 36px; width: 308px" Text="Supplier ID"></asp:Label>
        <p style="height: 282px; width: 380px">
            <asp:TextBox ID="txtSupplierId" runat="server" height="22px" style="z-index: 1; left: 354px; top: 203px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblContractStartDate" runat="server" style="z-index: 1; left: 36px; top: 329px; position: absolute; width: 308px" Text="Contract Start Date" height="36px"></asp:Label>
        <asp:Label ID="lblContractEndDate" runat="server" style="z-index: 1; left: 36px; top: 396px; position: absolute; width: 308px;" Text="Contract End Date" height="36px"></asp:Label>
        <asp:Label ID="lblContactPhoneNumber" runat="server" style="z-index: 1; left: 36px; top: 458px; position: absolute" Text="Contact Phone Number" height="36px" width="308px"></asp:Label>
        <asp:Label ID="lblContactEmailAddress" runat="server" style="z-index: 1; left: 36px; top: 519px; position: absolute; width: 308px;" Text="Contact Email Address"></asp:Label>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 36px; top: 259px; position: absolute; width: 308px;" Text="Supplier Name" height="36px"></asp:Label>
        <asp:TextBox ID="txtContractStartDate" runat="server" height="22px" style="z-index: 1; left: 354px; top: 326px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContractEndDate" runat="server" height="22px" style="z-index: 1; left: 354px; top: 397px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierName" runat="server" height="22px" style="z-index: 1; left: 354px; top: 266px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContactPhoneNumber" runat="server" height="22px" style="z-index: 1; left: 354px; top: 465px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtContactEmailAddress" runat="server" height="22px" style="z-index: 1; left: 354px; top: 526px; position: absolute" width="128px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 291px; top: 636px; position: absolute; height: 1px;" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 656px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 129px; position: absolute; top: 720px; height: 41px; width: 113px; right: 1888px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 273px; top: 720px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" height="41px" width="113px" />
    </form>
</body>
</html>
