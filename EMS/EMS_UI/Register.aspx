<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EMS_UI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div style="padding-top : 20px">
        <h3 style="text-align:center">Register Here</h3>
        <div>
            <table class="table table-condensed">
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="TextBoxUsername" MaxLength="255" runat="server" CssClass="form-control"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="RequiredFieldValidator">Name is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBoxPassword">Password is required!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                  <tr>
                    <td>Confirm Password</td>
                    <td>
                        <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBoxConfirmPassword">Password and Confirmed password should match!</asp:RequiredFieldValidator>
                    </td>
                </tr>
                </table>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-4">
                    <asp:Button ID="ButtonRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="ButtonRegister_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>
