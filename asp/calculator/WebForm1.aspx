<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="sol">
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="False" />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
                <asp:ListItem>x</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="False" />
            =
            <asp:Label ID="ResultLabel" runat="server" ForeColor="Blue" />
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Solve" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
