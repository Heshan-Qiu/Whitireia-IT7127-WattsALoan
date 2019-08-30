<%@ Page Title="Advisor" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Advisor.aspx.cs" Inherits="WattsALoanClient.Advisor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <asp:TreeView ID="TreeView" runat="server">
        <Nodes>
            <asp:TreeNode Text="Advisor" Value="Manager" NavigateUrl="~/Advisor">
                <asp:TreeNode Text="Add Customer" Value="Add Customer" NavigateUrl="~/Customer/Add"></asp:TreeNode>
                <asp:TreeNode Text="Modify Customers" Value="Modify Customers" NavigateUrl="~/Customer/Modify"></asp:TreeNode>
                <asp:TreeNode Text="Add Loan Allocation" Value="Add Loan Allocation" NavigateUrl="~/LoanAllocation/Add"></asp:TreeNode>
                <asp:TreeNode Text="Record Payment" Value="Record Payment" NavigateUrl="~/Payment/Record"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
</asp:Content>
