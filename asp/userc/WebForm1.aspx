<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="userc.WebForm1" %>
<%@ Register Src="GreetingControl.ascx" TagPrefix="uc" TagName="GreetingControl" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>User Control Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <asp:Label ID="Label1" runat="server" Text="Enter Your Name:" />
            <asp:TextBox ID="txtName" runat="server" />
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Enter Password:" />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />

            <uc:GreetingControl ID="GreetingControl1" runat="server" />
        </div>
    </form>
</body>
</html>
