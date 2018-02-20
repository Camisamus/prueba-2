<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    capital de Ecuador<asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>esmeraldas</asp:ListItem>
        <asp:ListItem>quito</asp:ListItem>
        <asp:ListItem>cuenca</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    capital de Chile<asp:RadioButtonList ID="RadioButtonList2" runat="server">
        <asp:ListItem>santiago</asp:ListItem>
        <asp:ListItem>coyahique</asp:ListItem>
        <asp:ListItem>bogota</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    camital de Panama<asp:RadioButtonList ID="RadioButtonList3" runat="server">
        <asp:ListItem>brasil</asp:ListItem>
        <asp:ListItem>toronto</asp:ListItem>
        <asp:ListItem>panama</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="Label4" runat="server" Text="ingrese su rut"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <asp:Label ID="Label5" runat="server"></asp:Label>
    <asp:Label ID="Error" runat="server" Text="error en rut" Visible="False"></asp:Label>
    <br />
</asp:Content>

