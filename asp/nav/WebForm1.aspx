<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="nav.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

            <div style="margin-left:22%;">
                <asp:SiteMapPath ID="SiteMapPath1" runat="server" PathSeparator=" > " />
                <h2>Welcome to the Home Page</h2>
                <p>Select a page from the menu or tree view to navigate.</p>
            </div>

           

        </div>
</asp:Content>
