<%@ Page Title="" Language="C#" MasterPageFile="~/Event.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="WebApplication1.Intro.RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 1144px;
        }
        .auto-style7 {
            width: 1189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CreateUserButtonText="Create" RequireEmail="False" AutoGeneratePassword="True" OnCreatedUser="CreateUserWizard1_CreatedUser">
        <WizardSteps>
            <asp:CreateUserWizardStep runat="server">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td align="center" colspan="2">Create new Acount</td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style7">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User name obligatory”。" ToolTip="User name obligatory" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style7">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Code:</asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Code obligatory" ToolTip="Code Obligatory" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style7" >
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Code</asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="必须填写“确认密码”。" ToolTip="必须填写“确认密码”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                       
                        <tr>
                            <td align="right" class="auto-style7">
                                <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Security Question:</asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="Question" runat="server" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question" ErrorMessage="必须填写“安全提示问题”。" ToolTip="必须填写“安全提示问题”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style7">
                                <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Answer:</asp:Label>
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="必须填写“安全答案”。" ToolTip="必须填写“安全答案”。" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                Code and Confirm code should be the same</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color:Red;">
                                <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep runat="server" />
        </WizardSteps>
        <FinishNavigationTemplate>
            <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="上一步" />
            <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="完成" />
        </FinishNavigationTemplate>
        <StartNavigationTemplate>
            <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="下一步" />
        </StartNavigationTemplate>
        <StepNavigationTemplate>
            <asp:Button ID="StepPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="上一步" />
            <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="下一步" />
        </StepNavigationTemplate>
    </asp:CreateUserWizard>
</asp:Content>
