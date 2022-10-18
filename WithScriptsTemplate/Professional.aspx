<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Professional.aspx.cs" Inherits="FirstWebForm.Professional" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2>This is a content page</h2>
    <hr />
    <h3>Add New Employee</h3>
    
        <p>
            <asp:TextBox ID="txtName" placeholder= "Enter your Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Name is Mandatory" SetFocusOnError="True" Font-Size="Medium" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:TextBox ID="txtDesig" placeholder= "Enter your Designation" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtSalary" placeholder= "Enter your Salary" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtSalary" ErrorMessage="Invalid Range" MaximumValue="1000000" MinimumValue="300000" SetFocusOnError="True" Font-Size="Medium" ForeColor="#FF3300"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Salary cannot be empty" SetFocusOnError="True" ControlToValidate="txtSalary" Font-Size="Medium" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <h3>Databinding with Database</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="EmpId" HeaderText="EmpId" InsertVisible="False" ReadOnly="True" SortExpression="EmpId" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KpmgDbConnectionString %>" 
        SelectCommand="SELECT * FROM [Employees]" 
        DeleteCommand="DELETE FROM [Employees] WHERE [EmpId] = @EmpId" 
        InsertCommand="INSERT INTO [Employees] ([Name], [Designation], [Salary]) VALUES (@Name, @Designation, @Salary)" 
        UpdateCommand="UPDATE [Employees] SET [Name] = @Name, [Designation] = @Designation, [Salary] = @Salary WHERE [EmpId] = @EmpId">
        
        <DeleteParameters>
            <asp:Parameter Name="EmpId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Name" Type="String" />
            <asp:Parameter Name="Designation" Type="String" />
            <asp:Parameter Name="Salary" Type="Double" />
            <asp:Parameter Name="EmpId" Type="Int32" />
        </UpdateParameters>
        </asp:SqlDataSource>
    
</asp:Content>

