﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sammy-2DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

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
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 12px; top: 164px; position: absolute" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 150px; top: 162px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 150px; top: 195px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 12px; top: 194px; position: absolute" Text="Firstname" width="79px"></asp:Label>
        <asp:CheckBox ID="chkAgeCheck" runat="server" style="z-index: 1; left: 145px; top: 419px; position: absolute" Text="Over 18?" />
        <p style="height: 425px; margin-top: 0px">
            <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 12px; top: 225px; position: absolute" Text="Lastname" width="79px"></asp:Label>
            <asp:Label ID="lblCustomerDOB" runat="server" style="z-index: 1; left: 12px; top: 259px; position: absolute" Text="Date Of Birth" width="79px"></asp:Label>
            <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 12px; top: 313px; position: absolute" Text="Email" width="79px"></asp:Label>
            <asp:Label ID="lblCustomerPhone" runat="server" style="z-index: 1; left: 12px; top: 347px; position: absolute" Text="Phone" width="79px"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 12px; top: 380px; position: absolute" Text="Date Added" width="79px"></asp:Label>
            <asp:TextBox ID="txtCustomerLastName" runat="server" style="z-index: 1; left: 150px; top: 225px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerDOB" runat="server" style="z-index: 1; left: 150px; top: 264px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 150px; top: 311px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 150px; top: 381px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtCustomerPhone" runat="server" style="z-index: 1; left: 150px; top: 348px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="39px" OnClick="btnFind_Click" Text="Find" Width="54px" />
        </p>
        <p style="height: 529px; margin-top: 0px">
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 466px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 24px; top: 515px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 113px; top: 513px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
