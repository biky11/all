﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="states.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

   
        <div>
       <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1" OnMenuItemClick="Menu1_MenuItemClick">
        </asp:Menu>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
            </asp:TreeView>
            <br />
        </div>
    </form>
</body>
</html>
