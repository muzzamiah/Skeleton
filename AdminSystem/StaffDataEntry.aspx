<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblStaffID" runat="server" BorderStyle="None" style="z-index: 1; left: 9px; top: 19px; position: absolute; height: 25px; width: 97px" Text="Staff ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 109px; top: 19px; position: absolute" OnTextChanged="txtStaffID_TextChanged"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 9px; top: 41px; position: absolute; height: 28px; width: 97px" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 109px; top: 42px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 9px; top: 69px; position: absolute; width: 97px; height: 29px" Text="Staff Address"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtAddressID" runat="server" style="z-index: 1; left: 109px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 9px; top: 100px; position: absolute; width: 97px; height: 25px" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 109px; top: 99px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 9px; top: 123px; position: absolute; width: 97px; height: 28px" Text="Staff Role"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 9px; top: 201px; position: absolute; height: 34px; width: 97px" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 109px; top: 127px; position: absolute"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 109px; top: 195px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Label ID="lblAttendance" runat="server" Font-Size="13pt" style="z-index: 1; left: 9px; top: 149px; position: absolute; height: 33px; width: 97px; " Text="Attendance"></asp:Label>
        <p>
            <asp:CheckBox ID="chkTrue" runat="server" style="z-index: 1; left: 109px; top: 149px; position: absolute" Text="True" />
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkFalse" runat="server" style="z-index: 1; left: 320px; top: 149px; position: absolute" Text="False" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 109px; top: 409px; position: absolute; width: 60px" Text="OK" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 409px; position: absolute; width: 97px; height: 23px" Text="Error"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 311px; top: 406px; position: absolute; height: 29px; width: 61px" Text="Cancel" />
    </form>
</body>
</html>
