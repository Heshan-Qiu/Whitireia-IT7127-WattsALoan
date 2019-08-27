<%@ Page Title="Add Loan Type" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Loan.aspx.cs" Inherits="WattsALoanClient.Loan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <div>
        <br />Loan Type:&nbsp;<asp:TextBox ID="TbxLoanType" runat="server" MaxLength="50"></asp:TextBox>
        <br /><br /><asp:ValidationSummary runat="server" HeaderText="Validation summary: " ForeColor="Red" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxLoanType" ErrorMessage="Loan type is required.">&nbsp;</asp:RequiredFieldValidator>
        <br /><br /><asp:Button ID="ButtonSubmit" runat="server" CssClass="btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" />
    </div>
</asp:Content>
