<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="floyd_trangle.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Floyd's Triangle with Asterisks</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter number of rows:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Draw" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="" Font-Names="Courier New"></asp:Label>
        </div>
    </form>
</body>
</html>
