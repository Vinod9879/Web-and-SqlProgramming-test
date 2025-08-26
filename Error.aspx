<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="hacks.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px; color:red;">
            <asp:Label ID="lblError" runat="server" />
            <br /><br />
            <asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="Search.aspx">Try another word</asp:HyperLink>
        </div>
        
    </form>
</body>
</html>
