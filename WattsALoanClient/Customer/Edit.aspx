<%@ Page Title="Customer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WattsALoanClient.CustomerEdit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <div>
        <br />Full Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxFullName" runat="server" MaxLength="50"></asp:TextBox>
        <br /><br />Billing Address:&nbsp;&nbsp;<asp:TextBox ID="TbxAddress" runat="server" MaxLength="100"></asp:TextBox>
        <br /><br />Billing City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxCity" runat="server" MaxLength="50"></asp:TextBox>
        <br /><br />Billing State:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxState" runat="server" MaxLength="50"></asp:TextBox>
        <br /><br />Billing ZIP Cide:&nbsp;<asp:TextBox ID="TbxZipCide" runat="server" MaxLength="10"></asp:TextBox>
        <br /><br />Email Address:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TbxEmail" runat="server" MaxLength="100"></asp:TextBox>
        <br /><br /><asp:ValidationSummary runat="server" HeaderText="Validation summary: " ForeColor="Red" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxFullName" ErrorMessage="Full name is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxAddress" ErrorMessage="Billing address is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxCity" ErrorMessage="Billing city is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxState" ErrorMessage="Billing state is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxZipCide" ErrorMessage="Billing ZIP cide is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxEmail" ErrorMessage="Email address is required.">&nbsp;</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator runat="server" ControlToValidate="TbxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Email address is invalid.">&nbsp;</asp:RegularExpressionValidator>
        <br /><br /><asp:Button ID="ButtonSubmit" runat="server" CssClass="btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" />
        <asp:TextBox ID="TbxCustomerID" runat="server" Visible="false"></asp:TextBox>
    </div>
</asp:Content>
