

<%@ Page Title="" Language="C#" MasterPageFile="~/Event.Master" AutoEventWireup="true" CodeBehind="EventManagement.aspx.cs" Inherits="WebApplication1.Admin.EventManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <p>
        This is the page Event Management.<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="1394px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" Visible="False" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Date" DataFormatString="{0:D}" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BegVCSharpEventsConnectionString %>" SelectCommand="SELECT * FROM [Events]"></asp:SqlDataSource>
    </p>
</asp:Content>
