<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="adrotar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="XmlDataSource1" Height="400px" Width="400px" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/ads.xml"></asp:XmlDataSource>
        <div>
            
        </div>
    </form>
</body>
</html>
