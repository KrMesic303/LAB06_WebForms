<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForms.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login</h2>
    <div>
        <p>Korisničko ime:
        <asp:TextBox ID="tbUsernameLogin" runat="server"></asp:TextBox></p>
    </div>
    <div>
        <p>Lozinka:
            <asp:TextBox ID="tbPasswordLogin" runat="server" TextMode="Password"></asp:TextBox></p>
    </div>
    <asp:Button ID="btLogin" runat="server" Text="Prijava" OnClick="btLogin_Click" />
    <hr/>
    <asp:TextBox ID="tbLoginError" runat="server" BackColor="Black" BorderColor="Red" ForeColor="Red" ReadOnly="True" Visible="False">Krivi podatci!</asp:TextBox>
</asp:Content>
