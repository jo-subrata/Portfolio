<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Kpop_Ztation.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">     
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Login.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">    
    <br /><br /><br /><br />

    <div class="login-box">
        <h2>Log In</h2> <br />

        <div class="login-field">
            <asp:Label ID="Label1" class="login-text" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxt" class="login-input" runat="server"></asp:TextBox>
    
            <asp:Label ID="Label2" class="login-text" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="passwordTxt" class="login-input" runat="server" TextMode="Password"></asp:TextBox>    
            
            <div class="field-item">
                <asp:CheckBox ID="rememberMe" CssClass="remember-me" runat="server" OnCheckedChanged="rememberMe_CheckedChanged" />
                <asp:Label ID="Label3" class="login-text remember-me" runat="server" Text="Remember Me"></asp:Label>
            </div>            

            <div class="field-item">
                <asp:Label ID="Label4" class="login-text no-account" runat="server" Text="No account?"></asp:Label> 
                <a href="../View/RegisterPage.aspx" class="register-now">register now</a> <br /> <br />
            </div>

            <div class="field-item">
                <asp:Label ID="errorText" class="login-text" runat="server" Text=""></asp:Label>
            </div>      

            <asp:Button ID="loginButton" class="button" runat="server" Text="Login" OnClick="loginButton_Click" />

        </div>
    </div>
    <br /><br /><br /><br />

</asp:Content>
