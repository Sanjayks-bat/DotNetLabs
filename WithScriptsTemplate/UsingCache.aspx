<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="UsingCache.aspx.cs" Inherits="WithScriptsTemplate.UsingCache" %>
<%@ OutputCache Duration="2" VaryByControl ="ListBox1" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent"  >
    <h1>Check the time for changes</h1>
    <h3> <%= DateTime.Now.ToLongTimeString() %> </h3>
    <hr />

    <br />
    <h1>Check the ListBox for changes</h1>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="104px"></asp:ListBox>
    </p>
    <h3> &nbsp;</h3>
    
</asp:Content>

