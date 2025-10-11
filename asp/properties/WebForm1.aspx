<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ServerControlsDemo.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AutoPostBack Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <asp:Label ID="Label1" runat="server" Text="Enter Your Name:" Font-Bold="True" Font-Size="Large"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxName" runat="server" Width="200px" MaxLength="50"></asp:TextBox>
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Select Your Gender:" Font-Italic="True"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonListGender" runat="server" RepeatDirection="Horizontal"
                                 AutoPostBack="True" OnSelectedIndexChanged="RadioButtonListGender_SelectedIndexChanged">
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:RadioButtonList>
            <br />

            

            <asp:DropDownList ID="DropDownListCountry" runat="server"
                              AutoPostBack="True" OnSelectedIndexChanged="DropDownListCountry_SelectedIndexChanged">
                <asp:ListItem Text="Select Country" Value="" />
                <asp:ListItem Text="USA" Value="USA" />
                <asp:ListItem Text="India" Value="India" />
                <asp:ListItem Text="UK" Value="UK" />
            </asp:DropDownList>
            <br /><br />

            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
            <br /><br />

            <asp:Label ID="LabelResult" runat="server" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
