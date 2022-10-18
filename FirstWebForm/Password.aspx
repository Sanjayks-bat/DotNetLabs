<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Password.aspx.cs" Inherits="FirstWebForm.Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>Password Generator<hr />
            </center></div>
        <div>
            Enter the Password Length :
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Height="16px"  TextMode="Number" Width="137px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="b1" runat="server" Text="Generate" OnClick="b1_Click" />
            <br />
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Password = "></asp:Label>
            <br />
    </div>
    </form>
    
</body>
</html>
