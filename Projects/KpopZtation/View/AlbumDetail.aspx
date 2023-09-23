<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="AlbumDetail.aspx.cs" Inherits="Kpop_Ztation.View.AlbumDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="field">
        <div class="header">
            <h1>Album Detail</h1> 
        </div>

        <asp:Image ID="albumImage" class="image-header" runat="server" /> 
        <asp:Label ID="albumTitle" class="field-item" runat="server"  Text=''></asp:Label> 
        <asp:Label ID="albumDesc" class="field-item" runat="server"  Text=''></asp:Label> 
        <asp:Label ID="albumPrice" class="field-item" runat="server"  Text=''></asp:Label> 
        <asp:Label ID="albumStock" class="field-item" runat="server"  Text=''></asp:Label> 
        <asp:Label ID="errorTxt" class="field-item" runat="server"  Text=''></asp:Label> 
        
        <%if (Session["User"] != null && !checkRole())
            { %>
                <asp:TextBox ID="purchaseAmount" class="field-item" runat="server" placeholder="Amount to buy"></asp:TextBox>
                <asp:Button ID="addCart" class="button" runat="server" Text="Add to Cart" OnClick="addCart_Click" />
        <%} %>
    </div>
    <br /><br />
    
</asp:Content>
