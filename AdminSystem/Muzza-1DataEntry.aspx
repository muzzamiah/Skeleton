<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Muzza-1DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblStaffID" runat="server" BorderStyle="None" style="z-index: 1; left: 17px; top: 19px; position: absolute; height: 25px; width: 79px" Text="Staff ID"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 115px; top: 19px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 14px; top: 41px; position: absolute; height: 28px; width: 93px" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 115px; top: 42px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 13px; top: 69px; position: absolute; width: 91px; height: 29px" Text="Staff Address"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtAddressID" runat="server" style="z-index: 1; left: 114px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 13px; top: 100px; position: absolute; width: 87px; height: 25px" Text="PostCode"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 114px; top: 99px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffRole" runat="server" style="z-index: 1; left: 14px; top: 123px; position: absolute; width: 76px; height: 28px" Text="Staff Role"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" style="z-index: 1; left: 6px; top: 201px; position: absolute; height: 34px; width: 98px" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server" style="z-index: 1; left: 113px; top: 127px; position: absolute"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" style="z-index: 1; left: 109px; top: 195px; position: absolute; height: 188px; width: 259px"></asp:Calendar>
        <asp:Label ID="lblAttendance" runat="server" Font-Size="13pt" style="z-index: 1; left: 12px; top: 149px; position: absolute; height: 33px; width: 85px; right: 1413px" Text="Attendance"></asp:Label>
        <p>
            <asp:CheckBox ID="chkTrue" runat="server" style="z-index: 1; left: 121px; top: 149px; position: absolute" Text="True" />
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkFalse" runat="server" style="z-index: 1; left: 237px; top: 149px; position: absolute" Text="False" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 85px; top: 408px; position: absolute; width: 60px" Text="OK" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 409px; position: absolute; width: 53px; height: 23px" Text="Error"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 193px; top: 405px; position: absolute; height: 29px; width: 61px" Text="Cancel" />
    </form>
</body>
</html>
