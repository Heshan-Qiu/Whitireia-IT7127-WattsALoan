<%@ Page Title="Manager" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="WattsALoanClient.Manager" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><asp:SiteMapPath ID="SiteMapPath" runat="server"></asp:SiteMapPath></h4>
    <h2><%: Title %>.</h2>
    <asp:TreeView ID="TreeView" runat="server">
        <Nodes>
            <asp:TreeNode Text="Manager" Value="Manager" NavigateUrl="~/Manager">
                <asp:TreeNode Text="Add Employee" Value="Add Employee" NavigateUrl="~/Employee/Add"></asp:TreeNode>
                <asp:TreeNode Text="Modify Employees" Value="Modify Employees" NavigateUrl="~/Employee/Modify"></asp:TreeNode>
                <asp:TreeNode Text="Add Loan Type" Value="Add Loan Type" NavigateUrl="~/LoanType/Add"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
    </asp:TreeView>
</asp:Content>
