<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebForms.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p>Naziv: <asp:TextBox ID="tbArticleName" runat="server"></asp:TextBox></p>
        <p>Opis: <asp:TextBox ID="tbArticleAbout" runat="server"></asp:TextBox></p>
    </div>
    <asp:Button ID="btSave" runat="server" Text="Spremi" OnClick="btSave_Click" />
    <hr/>
    <asp:GridView ID="gvArticles" runat="server">
    </asp:GridView>
</asp:Content>
