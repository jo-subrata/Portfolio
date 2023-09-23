<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="Kpop_Ztation.View.InsertArtist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Insert Artist</h1>
    </div>

    <div class="field">
        <div class="field-item">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> 
            <asp:TextBox ID="artistNameTxt" runat="server"></asp:TextBox> <br />
        </div>
        <br />

        <div class="field-item">
            <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="ImageUpload" runat="server" /> <br />
        </div>
        <br />

        <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label> <br />
        <asp:Button ID="InsertArtistButton" class="button" runat="server" Text="Add New Artist" OnClick="InsertArtistButton_Click" /> 
    </div>
    <br /> <br />

</asp:Content>
