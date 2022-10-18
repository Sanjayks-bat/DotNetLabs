<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingValidators.aspx.cs" Inherits="WithScriptsTemplate.UsingValidators" %>


<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <p>
    </p>
    <p style="font-size: xx-large">
        Using All Validators</p>
    <br />
    Using Required
    <asp:TextBox ID="txtRequired" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCompare1" ErrorMessage="Field cannot be Empty" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <br />
    <br />
    Using Compare
    <asp:TextBox ID="txtCompare1" runat="server"></asp:TextBox>
&nbsp;vs
    <asp:TextBox ID="txtCompare2" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtCompare2" ControlToValidate="txtCompare1" ErrorMessage="CompareValidator" ForeColor="#FF3300"></asp:CompareValidator>
    <br />
    <br />
    Using Range&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:RangeValidator ID="txtRange" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter a valid range" ForeColor="#FF3300" MaximumValue="99" MinimumValue="18"></asp:RangeValidator>
    <br />
    <br />
    Using Regular Expression
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="txtRegex" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invlaid email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    <br />
    <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
