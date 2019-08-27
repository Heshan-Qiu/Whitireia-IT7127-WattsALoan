<%@ Page Title="Add Employee" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WattsALoanClient.Employee" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <%: Page.GetRouteUrl( %>
    <div>
        <br />Employee Number:&nbsp;<asp:TextBox ID="TbxEmployeeNumber" runat="server" MaxLength="10"></asp:TextBox>
        <br /><br />First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxFirstName" runat="server" MaxLength="20"></asp:TextBox>
        <br /><br />Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxLastName" runat="server" MaxLength="10"></asp:TextBox>
        <br /><br />Titles:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxTitles" runat="server" MaxLength="100"></asp:TextBox>
        <br /><br />Hourly Salary:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxHourlySalary" runat="server"></asp:TextBox>
        <br /><br /><asp:ValidationSummary runat="server" HeaderText="Validation summary: " ForeColor="Red" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxEmployeeNumber" ErrorMessage="Employee number is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxFirstName" ErrorMessage="First name is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxLastName" ErrorMessage="Last name is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxTitles" ErrorMessage="Titles is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxHourlySalary" ErrorMessage="Hourly salary is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:CompareValidator runat="server" ControlToValidate="TbxHourlySalary" Operator="DataTypeCheck" Type="Double" ErrorMessage="Hourly salary must be a double.">&nbsp;</asp:CompareValidator>
        <br /><br /><asp:Button ID="ButtonSubmit" runat="server" CssClass="btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" />
    </div>
</asp:Content>
