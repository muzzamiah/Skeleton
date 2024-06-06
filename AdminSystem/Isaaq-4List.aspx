<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Isaaq-4List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="237px" Width="290px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 19px" Text="Edit" Width="47px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="Button1_Click" style="margin-left: 16px" Text="Delete" Width="53px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Enter a Product Name<asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 34px; margin-top: 3px" Width="119px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" />
            <asp:Button ID="btnClearFilter" runat="server" Height="24px" OnClick="btnClearFilter_Click" style="margin-left: 26px; margin-top: 0px" Text="Clear Filter" />
        </p>
    </form>
</body>
</html>
