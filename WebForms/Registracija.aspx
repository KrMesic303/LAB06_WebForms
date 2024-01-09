<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebForms.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        p{
            margin: 0px;
            padding: 5px;
        }

    </style>

        <h3>Registriraj se</h3>
        <p>Korisničko ime: 
            <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
        </p>
        <p>Puno ime:
            <asp:TextBox ID="tbFName" runat="server"></asp:TextBox>
        </p>
        <p>Lozinka:
            <asp:TextBox ID="tbPassword1" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>Ponovljena lozinka:
            <asp:TextBox ID="tbPassword2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="valCheckPassword" runat="server" ControlToCompare="tbPassword1" ControlToValidate="tbPassword2" ErrorMessage="Nije isti password!">Nije isti password!</asp:CompareValidator>
        </p>

        <asp:Button ID="btnRegistriraj" runat="server" Text="Registriraj" OnClick="btnRegistriraj_Click" />

    
</asp:Content>
