<%@ Page Title="Record Payment" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="WattsALoanClient.Payment" %>

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
                <td><asp:DropDownList runat="server" ID="DdlCustomer" AutoPostBack="true" OnSelectedIndexChanged="DdlCustomer_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text-right">Loan Allocation:</td>
                <td><asp:DropDownList runat="server" ID="DdlLoanAllocation"></asp:DropDownList></td>
            </tr>
            <tr>
                <td class="text-right">Payment Amount:</td>
                <td><asp:TextBox runat="server" ID="TbxPaymentAmount"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ValidationSummary runat="server" HeaderText="Validation summary: " ForeColor="Red" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="DdlLoanAllocation" ErrorMessage="Loan allocation is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TbxPaymentAmount" ErrorMessage="Payment amount is required.">&nbsp;</asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ControlToValidate="TbxPaymentAmount" Operator="DataTypeCheck" Type="Double" ErrorMessage="Payment amount must be a double.">&nbsp;</asp:CompareValidator>
                </td>
            </tr>
            <tr><td colspan="2" class="text-center"><asp:Button ID="ButtonSubmit" runat="server" CssClass="btn-primary" Text="Submit" OnClick="ButtonSubmit_Click" /></td></tr>
        </table>
    </div>
</asp:Content>
