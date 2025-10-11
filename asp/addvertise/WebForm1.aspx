<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdRotatorDemo.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdRotator Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h2>Random Advertisements</h2>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Ads.xml"
                           Width="400px" Height="250px" />
        </div>
    </form>
</body>
</html>
