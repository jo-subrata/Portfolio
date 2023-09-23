<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateAlbum.aspx.cs" Inherits="Kpop_Ztation.View.UpdateAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Update Album</h1>
    </div>

    <div class="field">
        <div class="field-item">
            <asp:Image ID="albumImage" class="image-header" runat="server" />
        </div>
    
        <div class="field-item">
            <label>Album Name:</label>
            <asp:TextBox ID="txtAlbumName" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <label>Description:</label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <label>Price:</label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <label>Stock:</label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="ImageUpload" runat="server" /> 
        </div>

        <div class="field-item">
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>

        <asp:Button ID="btnUpdate" class="button" runat="server" Text="Update Existing Album" OnClick="btnUpdate_Click" />
    </div>
    <br /> <br />                               

</asp:Content>