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
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="margin-left: 19px" Text="Edit" Width="42px" />
        </p>
    </form>
</body>
</html>
