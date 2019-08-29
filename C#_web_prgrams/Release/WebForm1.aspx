<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 366px;
        }
        .auto-style3 {
            width: 366px;
            height: 24px;
        }
        .auto-style4 {
            height: 24px;
        }
        .auto-style5 {
            width: 366px;
            height: 31px;
        }
        .auto-style6 {
            height: 31px;
        }
        .auto-style7 {
            width: 366px;
            height: 30px;
        }
        .auto-style8 {
            height: 30px;
        }
        a {
            background-color: #808080;
            line-height: normal;
            font-size: large;
            font-family: Georgia;
            color: #FFFFFF;
            padding: 0px;
        }
        video {
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Event:</td>
                <td>
                    <asp:DropDownList ID="dropDownListEvents" runat="server" Width="434px">
                        <asp:ListItem>Introduction to ASP NET.</asp:ListItem>
                        <asp:ListItem>Introduction to Windows Azure</asp:ListItem>
                        <asp:ListItem>Inroduction to .NET4.0</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">First Name:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="textFirstName" runat="server" Width="425px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textFirstName" ErrorMessage="First name is required"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Last Name:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="textLastName" runat="server" Width="427px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textLastName" ErrorMessage="Last name is required"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style8">
                </td>
            </tr>
            <tr>
                <td class="auto-style2">E-mail:</td>
                <td>
                    <asp:TextBox ID="textEmail" runat="server" Width="426px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textEmail" Display="Dynamic" ErrorMessage="email is required "></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textEmail" Display="Dynamic" ErrorMessage="Enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" PostBackUrl="~/WebForm2.aspx" />
                </td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <asp:Label ID="LabelText" runat="server"></asp:Label>
    </form>
</body>
</html>
