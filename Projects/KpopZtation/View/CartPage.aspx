<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Kpop_Ztation.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Stylesheets" runat="server">
    <link href="../CSS/Style.css" rel="stylesheet" runat="server"/>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="WebsiteContent" runat="server">
    
    <div class="header">
        <h1>Cart</h1>
    </div>

    <div class="field">
        <asp:GridView ID="CartGridView" class="field-item" runat="server" AutoGenerateColumns="False" OnRowDeleting="CartGridView_RowDeleting">
            <Columns>
                <asp:BoundField DataField="albumID" HeaderText="Album ID"/>
                <asp:BoundField DataField="User" HeaderText="User ID"/>
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Album's Picture" ControlStyle-Width="320" ControlStyle-Height="320"/>
                <asp:BoundField DataField="Name" HeaderText="Album's Name"/>
                <asp:BoundField DataField="Quantity" HeaderText="Album's Quantity"/>
                <asp:BoundField DataField="Price" HeaderText="Album's Price"/>
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowHeader="True" DeleteText="Remove" />
            </Columns>
            <EmptyDataTemplate>
                <p>No data has been put in the cart</p>
            </EmptyDataTemplate>
        </asp:GridView>

        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
        <%if (CartGridView.Rows.Count != 0){ %>
            <asp:Button ID="CheckOutButton" class="button" runat="server" Text="Check Out" OnClick="CheckOutButton_Click" />
        <%} %>
    </div>
    <br /><br /><br /><br />

    
</asp:Content>
