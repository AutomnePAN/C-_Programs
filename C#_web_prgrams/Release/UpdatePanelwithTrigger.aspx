<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanelwithTrigger.aspx.cs" Inherits="WebApplication1.UpdatePanelwithTrigger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

        </div>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Label: "></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server" Text="Label: "></asp:Label>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
