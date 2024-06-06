<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStatistics.aspx.cs" Inherits="CustomerStatistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Statistics Page<br />
            <br />
            <br />
            Customer List- Grouped by Lastname<br />
            <asp:GridView ID="GridViewStGroupByCustomerLastName" runat="server">
            </asp:GridView>
            <br />
            <br />
            Customer List - Grouped by Added Date<br />
            <asp:GridView ID="GridViewStGroupByDateAdded" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
