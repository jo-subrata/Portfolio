<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Kpop_Ztation.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Update Profile</h1>
    </div>
    
    <div class="field">
        <div class="field-item">
            <asp:Label ID="nameLabel" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="emailLabel" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox> 
        </div>

        <div class="field-item">
            <asp:Label ID="genderLabel" runat="server" Text="Gender"></asp:Label> 
            <asp:RadioButtonList ID="GenderSelect" runat="server">
                <asp:ListItem Selected="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div class="field-item">
            <asp:Label ID="addressLabel" runat="server" Text="Address"></asp:Label> 
            <asp:TextBox ID="addressTxt" runat="server"></asp:TextBox> 
        </div>

        <div class="field-item">
            <asp:Label ID="passwordLabel" runat="server" Text="Password"></asp:Label> 
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox> 
        </div>

        <div class="field-item">
            <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label>
        </div>

        <asp:Button ID="updateProfile" class="button" runat="server" Text="Update Profile" OnClick="updateProfile_Click" />
    </div>
    <br /> <br />

</asp:Content>
