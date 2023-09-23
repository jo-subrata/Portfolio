<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kpop_Ztation.View.Guest.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <asp:Label ID="Label6" runat="server" Text="Login Page"></asp:Label>
    
    <br />
    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label> &nbsp
    <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> &nbsp
    <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>    

    <br />
    <asp:CheckBox ID="rememberMe" runat="server" />
    <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>

    <br />
    <asp:Label ID="errorText" runat="server" Text=""></asp:Label> <br />
    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />

</asp:Content>
