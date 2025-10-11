<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationDemo.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form with Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 400px; padding: 20px;">
            <h2>Registration Form</h2>

            <!-- Name -->
            <asp:Label ID="LabelName" runat="server" Text="Full Name:" /><br />
            <asp:TextBox ID="TextBoxName" runat="server" /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="TextBoxName"
                ErrorMessage="Name is required." ForeColor="Red" /><br /><br />

            <!-- Email -->
            <asp:Label ID="LabelEmail" runat="server" Text="Email:" /><br />
            <asp:TextBox ID="TextBoxEmail" runat="server" /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="TextBoxEmail"
                ErrorMessage="Email is required." ForeColor="Red" />
            <asp:RegularExpressionValidator ID="RegexValidatorEmail" runat="server"
                ControlToValidate="TextBoxEmail"
                ErrorMessage="Enter a valid email."
                ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
                ForeColor="Red" /><br /><br />

            <!-- Password -->
            <asp:Label ID="LabelPassword" runat="server" Text="Password:" /><br />
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="TextBoxPassword"
                ErrorMessage="Password is required." ForeColor="Red" /><br /><br />

            <!-- Confirm Password -->
            <asp:Label ID="LabelConfirm" runat="server" Text="Confirm Password:" /><br />
            <asp:TextBox ID="TextBoxConfirm" runat="server" TextMode="Password" /><br />
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToValidate="TextBoxConfirm"
                ControlToCompare="TextBoxPassword"
                ErrorMessage="Passwords do not match." ForeColor="Red" /><br /><br />

            <!-- Age -->
            <asp:Label ID="LabelAge" runat="server" Text="Age:" /><br />
            <asp:TextBox ID="TextBoxAge" runat="server" /><br />
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ControlToValidate="TextBoxAge"
                MinimumValue="18" MaximumValue="60"
                Type="Integer"
                ErrorMessage="Age must be between 18 and 60." ForeColor="Red" /><br /><br />

            <!-- Submit Button -->
            <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" /><br /><br />

            <!-- Validation Summary -->
            <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                HeaderText="Please correct the following errors:"
                ForeColor="Red" />

            <!-- Confirmation Label -->
            <asp:Label ID="LabelResult" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
