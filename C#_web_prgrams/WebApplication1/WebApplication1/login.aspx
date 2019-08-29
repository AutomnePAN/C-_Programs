<%@ Page Title="" Language="C#" MasterPageFile="~/Event.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
            align-items:center;
            align-self:center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Login ID="Login1" runat="server" CssClass="auto-style1" ForeColor="#00CCFF" LoginButtonText="login" PasswordLabelText="Code" RememberMeText="Remember me" TitleText="Login" UserNameLabelText="Username" UserNameRequiredErrorMessage="Username is obligatory" Width="354px">
    </asp:Login>
    <asp:Button ID="Button1" runat="server" PostBackUrl="~/Intro/RegisterUser.aspx" Text="Create a new account" />
</asp:Content>
