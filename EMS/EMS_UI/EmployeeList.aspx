<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="EMS_UI.EmployeeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center"> Employee List</h1>
    <div>
        <asp:GridView ID="GridViewEmployeeList" runat="server" EmptyDataText="No employee find!" CssClass="table"></asp:GridView>
    </div>
</asp:Content>
