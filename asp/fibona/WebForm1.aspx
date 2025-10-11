<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="fibona.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fibonacci Series</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter number of terms:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="fibona" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="" Font-Names="Courier New"></asp:Label>
        </div>
    </form>
</body>
</html>
