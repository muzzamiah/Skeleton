<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sammy-2DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 583px;
        }
    </style>
</head>
<body style="height: 669px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 28px; top: 162px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 155px; top: 162px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 37px; top: 199px; position: absolute" Text="Firstname"></asp:Label>
        <asp:CheckBox ID="chkAgeCheck" runat="server" style="z-index: 1; left: 124px; top: 438px; position: absolute" Text="Over 18?" />
        <p style="height: 529px; margin-top: 0px">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 156px; top: 197px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 38px; top: 237px; position: absolute" Text="Lastname"></asp:Label>
            <asp:Label ID="lblCustomerDOB" runat="server" style="z-index: 1; left: 33px; top: 279px; position: absolute" Text="Date Of Birth"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 49px; top: 318px; position: absolute" Text="Email"></asp:Label>
            <asp:Label ID="lblCustomerPhone" runat="server" style="z-index: 1; left: 48px; top: 359px; position: absolute" Text="Phone"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 37px; top: 397px; position: absolute" Text="Date Added"></asp:Label>
            <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 157px; top: 240px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerDOB" runat="server" style="z-index: 1; left: 156px; top: 279px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 158px; top: 321px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerPhone" runat="server" style="z-index: 1; left: 156px; top: 357px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 155px; top: 395px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 53px; top: 482px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 82px; top: 515px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 175px; top: 514px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
