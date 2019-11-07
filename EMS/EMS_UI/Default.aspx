﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EMS_UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Employee Management System</h1>

    <div>
        <asp:HyperLink ID="HyperLinkListEMp" runat="server" NavigateUrl="~/EmployeeList.aspx">Employees List</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkAddEmp" runat="server" NavigateUrl="~/AddEmployee.aspx">Add Employee</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkEditEmp" runat="server" NavigateUrl="~/EditEmployee.aspx">Edit Employee</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkDeleteEmp" runat="server">Delete Employee</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkEmpByDept" runat="server">Employees by Dept</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkRegister" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLinkLogin" runat="server" NavigateUrl="~/Login.aspx">Log In</asp:HyperLink>
        <br />

    </div>
    
</asp:Content>