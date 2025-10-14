<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UC.WebForm1" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc" TagName="Welcome" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 293px">
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <uc:Welcome id="Welcome1" runat="server" visible="false" />
        <div>
        </div>
    </form>
</body>
</html>
