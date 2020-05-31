<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Uwierzytelnianie._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <hr />
    <label>Login: </label> <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox> <br />
    <label>Hasło: </label> <asp:TextBox ID="txtHaslo" runat="server"></asp:TextBox> <br />
    <asp:Button ID="Button1" runat="server" Text="Loguj" OnClick="Button1_Click" CssClass="btn btn-primary" /> 
    <asp:Button ID="Button2" runat="server" Text="Loguj" OnClick="Button2_Click" CssClass="btn btn-success" /> 
    <br />
    <asp:Label ID="lKomunikat" runat="server" Text="Proszę się zalogować!" ForeColor="Black"></asp:Label>
    <br />
</asp:Content>
