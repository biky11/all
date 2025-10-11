<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TreeDemo.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TreeView Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>TreeView Example</h2>

            <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            </asp:TreeView>

            <br />
        </div>
    </form>
</body>
</html>
