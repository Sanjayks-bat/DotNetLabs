<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FirstWebForm.Login" %>

<asp:Content ContentPlaceHolderID ="Pages" runat="server">
<style>
    body {
        background-image: url('../images/focus.png');
        background-repeat: no-repeat;
        background-size: cover;
    }
</style>
    <br />
    <form id="form1" runat="server">
        <div>
            <h1>
            <center style="color:white">Course Enrollment<br />
            
            </center></h1></div>
        <div>
        <p style="color: #FF9900; font-size: large;">
            Name :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" ForeColor="Black" Width="170px"></asp:TextBox>
        </p>
        <p style="color: #FF9900; font-size: large;">
            Email :&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" CausesValidation="True" Height="22px" Width="169px"></asp:TextBox>
        </p>
        <p style="color: #FF9900; font-size: large;">
            Phone :&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="177px"></asp:TextBox>
        </p>
        <p style="color: #FF9900; font-size: large;">
            Courses :&nbsp; <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select Course</asp:ListItem>
                <asp:ListItem>Intro to Bug Bounty</asp:ListItem>
                <asp:ListItem>Practical Ethical Hacking</asp:ListItem>
                <asp:ListItem>.NET the complete guide</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p style="color: #FF9900; font-size: large;">
            Time-slot :
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Select Time slot</asp:ListItem>
                <asp:ListItem>10 am - 12:30 pm</asp:ListItem>
                <asp:ListItem>1:30pm - 4pm</asp:ListItem>
                <asp:ListItem>5pm - 8pm</asp:ListItem>
            </asp:DropDownList>
        </p>
            <p style="color: #FF9900; font-size: large;">
            <asp:Button ID="btn" runat="server" Text="Submit" BackColor="White" BorderStyle="Groove" Font-Size="Medium" OnClick="btn_Click" />
        </p>
            <p style="color: #FF9900; font-size: large;">
                &nbsp;</p>
            <p style="color: #FF9900; font-size: large;">
                &nbsp;</p>
        <p>
            &nbsp;</p>
    </div>
    </form>
</asp:Content>
