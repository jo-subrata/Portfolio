<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Kpop_Ztation.View.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
     <link href="../CSS/Homepage.css" rel="stylesheet" runat="server"/>
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>

</asp:Content>

<asp:Content ID ="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    <div class="header">
            <h1>Home</h1>
    </div>

    <div class="header">
    <%if (checkRole())
        { %>   
        <asp:Button ID="InsertArtistButton" class="button" runat="server" Text="Insert Artist" OnClick="InsertArtistButton_Click"/> &nbsp        
    <%}%>     
    </div> <br /><br />               

    <h2 class="subheader-text">Artist List</h2>

    <div class="listview-container">            
        <asp:ListView ID="ArtistListView" runat="server">
            <LayoutTemplate>
                <div class="listview-items">
                    <table>
                        <tr runat="server" id="itemPlaceHolder"/>
                    </table>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <%# Container.DataItemIndex % 3 == 0 ? "<tr>" : "" %>
                <td>
                    <div class="list">
                        <a class="image-link" href='<%# "../View/ArtistDetail.aspx?artistId=" + Eval("ArtistID") %>'>
                            <table>
                                <tr><td><img class="home-image" src='<%# Eval("ArtistImage") %>' /></a></td></tr>
                                <tr><td><asp:Label ID="artistName" runat="server" Text='<%# Eval("ArtistName") %>'></asp:Label></td></tr>
                                <%if(checkRole())
                                    { %>
                                <tr><td><a class="listview-button" href='<%# "../View/UpdateArtist.aspx?artistId=" + Eval("ArtistID") %>'>Update Artist</a></td></tr>
                                <tr><td><asp:LinkButton ID="deleteButton" class="listview-button" CommandArgument='<%#Eval("ArtistID") %>' OnClick="deleteButton_Click" runat="server">Delete Artist</asp:LinkButton></td></tr>                                                        
                                <%  }%>
                            </table>
                        </a>
                    </div>
                </td>
                <%# (Container.DataItemIndex + 1) % 3 == 0 ? "</tr>" : "" %>
            </ItemTemplate>
        </asp:ListView> 
    </div>
    <br /> <br />

</asp:Content>