﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calen.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 380px">
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"></asp:Calendar>
        </div>
    </form>
</body>
</html>
