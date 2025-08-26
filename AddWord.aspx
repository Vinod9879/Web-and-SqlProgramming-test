<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWord.aspx.cs" Inherits="hacks.AddWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
               <div style="padding:20px;">
            <asp:Label ID="lblWord" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="txtTranslation" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" Text="Add to My words" OnClick="btnAdd_Click" />
            <br /><br />
            <h3>My Words</h3>
            <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="EnglishWord" HeaderText="Word" />
                    <asp:BoundField DataField="Translation" HeaderText="Translation" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
