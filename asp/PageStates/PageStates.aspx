<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageStates.aspx.cs" Inherits="aspstates.PageStates" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>ASP.NET Page States Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px; border: 1px solid gray; width: 400px;">
            <h3>ASP.NET Page State Demo</h3>

            <asp:Label ID="lblViewState" runat="server" Text="ViewState Count: " />
            <br /><br />

            <asp:Button ID="btnViewState" runat="server" Text="Increase ViewState Counter" OnClick="btnViewState_Click" />
            <br /><br />

            <asp:Label ID="lblSession" runat="server" Text="Session Value: " />
            <br /><br />

            <asp:Button ID="btnSession" runat="server" Text="Set Session Value" OnClick="btnSession_Click" />
            <br /><br />

            <asp:Label ID="lblAppState" runat="server" Text="Application Value: " />
            <br /><br />

            <asp:Button ID="btnApp" runat="server" Text="Increase App Counter" OnClick="btnApp_Click" />
        </div>
    </form>
</body>
</html>
