<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Kpop_Ztation.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">     
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Register.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Conten3" ContentPlaceHolderID="WebsiteContent" runat="server">
    
    <br /><br /><br /><br />
    <div class="register-box">
        <h2>Register</h2>

        <div class="register-field">
            <asp:Label ID="Label1" class="register-text" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" class="register-text" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox> <br />

            <asp:Label ID="Label3" class="register-text" runat="server" Text="Gender"></asp:Label> 
            <asp:RadioButtonList ID="GenderSelect" runat="server">
                <asp:ListItem Selected="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="Label4" class="register-text" runat="server" Text="Address"></asp:Label> 
            <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox> 

            <asp:Label ID="Label5" class="register-text" runat="server" Text="Password"></asp:Label> 
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox> <br />
            
            <div class="register-item">
                <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label> 
            </div>

            <asp:Button ID="registerButton" class="button" runat="server" Text="Register" OnClick="registerButton_Click" />

        </div>
    </div>
    <br /><br /><br /><br />

</asp:Content>
