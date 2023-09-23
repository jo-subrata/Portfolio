<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertAlbum.aspx.cs" Inherits="Kpop_Ztation.View.InsertAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Insert Album</h1>
    </div> 

    <div class="field">
        <div class="field-item">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> &nbsp
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox> <br />
        </div>

        <div class="field-item">
            <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="descTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="stockTxt" runat="server"></asp:TextBox>
        </div>

        <div class="field-item">
            <asp:Label ID="Label5" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="ImageUpload" runat="server" />
        </div>
        
        <asp:Label ID="errorTxt" runat="server" Text=""></asp:Label>
        <asp:Button ID="InsertAlbumButton" class="button" runat="server" Text="Add New Album" OnClick="InsertAlbumButton_Click" />
    </div>
    <br /> <br />

</asp:Content>
