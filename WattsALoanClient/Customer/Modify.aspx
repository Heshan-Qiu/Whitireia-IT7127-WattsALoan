<%@ Page Title="Modify Customers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WattsALoanClient.CustomerModify" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <div>
        <asp:ListView ID="ListView" runat="server" DataKeyNames="CustomerID" ItemType="WattsALoanClient.WattsALoanServiceReference.Customer" SelectMethod="GetCustomers" OnItemCommand="ListView_ItemCommand">
            <EmptyDataTemplate>
                <table><tr><td>No data was returned.</td></tr></table>
            </EmptyDataTemplate>
            <LayoutTemplate>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col">Full Name</th>
                            <th scope="col">Billing Address</th>
                            <th scope="col">Billing City</th>
                            <th scope="col">Billing State</th>
                            <th scope="col">Billing ZIP Cide</th>
                            <th scope="col">Email Address</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id="itemPlaceholder" runat="server"></tr>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <th scope="row"><asp:Label runat="server" Text="<%# Item.FullName %>"></asp:Label></th>
                    <td><asp:Label runat="server" Text="<%# Item.BillingAddress %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.BillingCity %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.BillingState %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.BillingZIPCide %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.EmailAddress %>"></asp:Label></td>
                    <td><asp:Button ID="ButtonEdit" runat="server" CssClass="btn-primary" Text="Edit" CommandName="Edit" CommandArgument="<%# Item.CustomerID %>" /></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
