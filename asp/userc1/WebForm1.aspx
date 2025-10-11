<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="userc1.WebForm1" %>
<%@ Register Src="~/WelcomeControl.ascx" TagName="Welcome" TagPrefix="uc" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Login Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>User Login</h2>
            <asp:Label ID="Label1" runat="server" Text="Username: " />
            <asp:TextBox ID="TextBoxUsername" runat="server" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password: " />
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" />
            <br /><br />
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
            <br /><br />
            <asp:Label ID="LabelMessage" runat="server" ForeColor="Red" />
            <br /><br />
            <uc:Welcome ID="Welcome1" runat="server" Visible="false" />
        </div>
    </form>
</body>
</html>
