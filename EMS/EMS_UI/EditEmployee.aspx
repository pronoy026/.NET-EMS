﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="EMS_UI.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2 style="text-align:center">Edit Employee</h2>
        <div class="card shadow">
            <table class="table table-condensed">
                <tr>
                    <td>Enter Employee ID</td>
                    <td>
                        <asp:TextBox ID="TextBoxEmpID" MaxLength="255" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="SearchButton" runat="server" CssClass="btn btn-primary" OnClick="SearchButton_Click" Text="Search" ValidationGroup="SearchGroup" />
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxEmpID" ErrorMessage="RequiredFieldValidator" ValidationGroup="SearchGroup">Employee ID  is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="TextBoxName" MaxLength="255" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxName" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Name is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Email is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonListGender" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem Value="Trans"></asp:ListItem>
                        </asp:RadioButtonList></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonListGender" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Gender is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:DropDownList ID="DropDownListDept" runat="server" DataTextField="FullName" DataValueField="DepartmentId"></asp:DropDownList></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownListDept" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Select a department!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="TextBoxDOB" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBoxDOB" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">DOB is required!</asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TextBoxDOB" ErrorMessage="CompareValidator" Operator="LessThanEqual" Type="Date" ValidationGroup="UpdateGroup">DOB cannot be in the future!</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Joining</td>
                    <td>
                        <asp:TextBox ID="TextBoxDOJ" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBoxDOJ" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Date of Joining is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Manager</td>
                    <td>
                        <asp:DropDownList ID="DropDownListManager" runat="server" DataTextField="Name" DataValueField="Number"></asp:DropDownList></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="TextBoxPhone" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Phone no is required!</asp:RequiredFieldValidator>
                        <br />
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="RangeValidator" MaximumValue="9999999999" MinimumValue="1000000000" Type="Double" ValidationGroup="UpdateGroup">Phone no should be 10 digits!</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>Salary</td>
                    <td>
                        <asp:TextBox ID="TextBoxSalary" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxSalary" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Please Enter Salary!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Commision</td>
                    <td>
                        <asp:TextBox ID="TextBoxCommission" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBoxCommission" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Please enter commission!</asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td>Job Title</td>
                    <td>
                        <asp:DropDownList ID="DropDownListJobTitle" runat="server">
                            <asp:ListItem>Manager</asp:ListItem>
                            <asp:ListItem>Tester</asp:ListItem>
                            <asp:ListItem>Developer</asp:ListItem>
                            <asp:ListItem>Consultant</asp:ListItem>
                            <asp:ListItem>CEO</asp:ListItem>
                            <asp:ListItem>CTO</asp:ListItem>
                            <asp:ListItem>President</asp:ListItem>
                            <asp:ListItem>Accountant</asp:ListItem>
                            <asp:ListItem>Head</asp:ListItem>
                            <asp:ListItem>Cashier</asp:ListItem>
                            <asp:ListItem>Salesman</asp:ListItem>
                            <asp:ListItem>Analyst</asp:ListItem>
                        </asp:DropDownList>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownListJobTitle" ErrorMessage="RequiredFieldValidator" ValidationGroup="UpdateGroup">Select a job title!</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <div class="row">
                <div class="col-md-5"></div>
                <div class="col-md-1"><asp:Button Text="Update" ID="ButtonEdit" runat="server" CssClass="btn btn-primary" OnClick="ButtonEdit_Click" ValidationGroup="UpdateGroup"/></div>
                <div class="col-md-1"><asp:Button Text="Cancel" CssClass="btn btn-warning" ID="ButtonCancel2" runat="server" CausesValidation="False" /></div>
                  
             </div>
        </div>
    </div>
</asp:Content>
