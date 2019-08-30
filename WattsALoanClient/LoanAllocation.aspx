<%@ Page Title="Add Loan Allocation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoanAllocation.aspx.cs" Inherits="WattsALoanClient.LoanAllocation" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <div>
        <table style="font-size: medium;" class="table">
            <tr>
                <td class="text-right">Employee:</td>
                <td><asp:DropDownList runat="server" ID="DdlEmployee"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text-right">Customer:</td>
                <td><asp:DropDownList runat="server" ID="DdlCustomer"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text-right">Account Number:</td>
                <td><asp:TextBox runat="server" ID="TbxAccountNumber"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text-right">Loan Type:</td>
                <td><asp:DropDownList runat="server" ID="DdlLoanType"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text-right">Loan Amount:</td>
                <td><asp:TextBox runat="server" ID="TbxLoanAmount"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text-right">Interest Rate:</td>
                <td><asp:TextBox runat="server" ID="TbxInterestRate"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="text-right">Periods:</td>
                <td><asp:TextBox runat="server" ID="TbxPeriods"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary runat="server" HeaderText="Validation summary: " ForeColor="Red" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxAccountNumber" ErrorMessage="Account number is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxLoanAmount" ErrorMessage="Loan amount is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ControlToValidate="TbxLoanAmount" Operator="DataTypeCheck" Type="Double" ErrorMessage="Loan amount must be a double.">&nbsp;</asp:CompareValidator>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxInterestRate" ErrorMessage="Interest rate is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ControlToValidate="TbxInterestRate" Operator="DataTypeCheck" Type="Double" ErrorMessage="Interest rate must be a double.">&nbsp;</asp:CompareValidator>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxPeriods" ErrorMessage="Periods is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ControlToValidate="TbxPeriods" Operator="DataTypeCheck" Type="Double" ErrorMessage="Periods must be a double.">&nbsp;</asp:CompareValidator>
                </td>
            </tr>
            <tr><td colspan="2" class="text-center"><asp:Button ID="ButtonSubmit" runat="server" CssClass="btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" /></td></tr>
        </table>
    </div>
</asp:Content>
