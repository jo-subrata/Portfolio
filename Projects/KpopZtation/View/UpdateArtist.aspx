<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateArtist.aspx.cs" Inherits="Kpop_Ztation.View.UpdateArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Update Artist</h1>
    </div>

    <div class="field">
        <div class="field-item">
            <asp:Image ID="artistImage" class="image-header" runat="server" /> <br />
        </div>
        
        <div class="field-item">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="artistNameTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="ImageUpload" runat="server" />
        </div>

        <div class="field-item">
            <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label>
        </div>

        <asp:Button ID="UpdateArtistButton" class="button" OnClick="UpdateArtistButton_Click" runat="server" Text="Update Existing Artist" />
    </div>
    <br /> <br />
</asp:Content>
