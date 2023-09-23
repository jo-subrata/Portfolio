<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ArtistDetail.aspx.cs" Inherits="Kpop_Ztation.View.ArtistDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/ArtistDetail.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
        <h1>Artist Detail</h1>
    </div> 

    <div class="header">
        <%if (checkRole())
        {  %>        
            <asp:Button ID="InsertAlbumButton" class="button" runat="server" Text="Insert Album" OnClick="InsertAlbumButton_Click" />   <%
        }  %>
    </div>
    <br /> <br />

    <div class="field">
        <div class="field-item">
            <asp:Image ID="artistImage" class="image-header" runat="server" /> <br />            
        </div>

        <div class="field">
            <asp:Label ID="artistName" runat="server"  Text=''></asp:Label> <br /> <br />
        </div>

        <h1 class="subheader-text">Artist's Album Collection</h1> <br />        
    </div>

    <div class="listview-container">
        <asp:ListView ID="AlbumListView" runat="server">
            <LayoutTemplate>
                <div class="listview-items">
                    <table>
                        <tr runat="server" id="itemPlaceHolder"/>
                    </table>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <%# Container.DataItemIndex % 4 == 0 ? "<tr>" : "" %>
                <td>
                    <div class="list">
                        <a class="image-link" href='<%# "../View/AlbumDetail.aspx?albumId=" + Eval("AlbumID") %>'>
                            <table>
                                <tr><td><img class="ad-image" src='<%# Eval("AlbumImage") %>' /></a></td></tr>
                                <tr><td><asp:Label ID="Label2" runat="server" Text='<%# "Album Title: " +  Eval("AlbumName") %>'></asp:Label></td></tr>                        
                                <tr><td><asp:Label ID="Label5" runat="server" Text='<%# Eval("AlbumDescription") %>'></asp:Label></td></tr>                        
                                <tr><td><asp:Label ID="Label4" runat="server" Text='<%# "Price: Rp." + Eval("AlbumPrice") %>'></asp:Label></td></tr>
                                <%if (checkRole())
                                    { %>
                                <tr><td><a class="listview-button" href='<%# "../View/UpdateAlbum.aspx?albumId=" + Eval("AlbumID") %>'>Update Album</a></td></tr>
                                <tr><td><asp:LinkButton ID="deleteButton" class="listview-button" OnClick="deleteButton_Click" CommandArgument='<%# Eval("AlbumID") %>' runat="server">Delete Album</asp:LinkButton></td></tr>                                                                                
                                <%} %>
                            </table>
                        </a>
                    </div>
                </td>
               <%# (Container.DataItemIndex + 1) % 4 == 0 ? "</tr>" : "" %>
            </ItemTemplate>             
        </asp:ListView>
    </div> 

</asp:Content>
