<%@ Page  MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FirstWebForm.Dashboard" %>

<asp:Content ContentPlaceHolderID="Pages" runat="server">
     <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Hobbies" />
        <div>
            <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
        </div>
        <br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" Width="55px">
            <asp:ListItem Value="1001">Item 1</asp:ListItem>
            <asp:ListItem Value="1002">Item 2</asp:ListItem>
            <asp:ListItem Value="1003">Item 3</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="lblSelected" runat="server" Text="Selected value = "></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="View Cookie Data" />
        <hr />
        <p>
            &nbsp;</p>
        <p>
            Working with ViewState and GridView&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View data" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</asp:Content>
