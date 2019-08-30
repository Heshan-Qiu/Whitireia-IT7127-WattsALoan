<%@ Page Title="Modify Employees" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WattsALoanClient.EmployeeModify" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <div>
        <asp:ListView ID="ListView" runat="server" DataKeyNames="EmployeeID" ItemType="WattsALoanClient.WattsALoanServiceReference.Employee" SelectMethod="GetEmployees" OnItemCommand="ListView_ItemCommand">
            <EmptyDataTemplate>
                <table><tr><td>No data was returned.</td></tr></table>
            </EmptyDataTemplate>
            <LayoutTemplate>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th scope="col">Employee Number</th>
                            <th scope="col">First Name</th>
                            <th scope="col">Last Name</th>
                            <th scope="col">Titles</th>
                            <th scope="col">Hourly Salary</th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id="itemPlaceholder" runat="server"></tr>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <th scope="row"><asp:Label runat="server" Text="<%# Item.EmployeeNumber %>"></asp:Label></th>
                    <td><asp:Label runat="server" Text="<%# Item.FirstName %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.LastName %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.Titles %>"></asp:Label></td>
                    <td><asp:Label runat="server" Text="<%# Item.HourlySalary %>"></asp:Label></td>
                    <td>
                        <asp:Button ID="ButtonEdit" runat="server" CssClass="btn-primary" Text="Edit" CommandName="Edit" CommandArgument="<%# Item.EmployeeID %>" />
                        <asp:Button ID="ButtonDelete" runat="server" CssClass="btn-primary" Text="Delete" CommandName="Remove" CommandArgument="<%# Item.EmployeeID %>" OnClientClick="return ConfirmDelete();" />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <script type="text/javascript">
        function ConfirmDelete() {
            return confirm('Confirm delete employee?');
        }
    </script>
</asp:Content>
