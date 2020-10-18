<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Desloguear.aspx.cs" Inherits="Vieew.Desloguear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <p>Seguro desea desloguearse ?</p>

    <asp:Button Text="Desloguearse" CssClass="btn btn-primary" ID="btnDesloguear" runat="server" OnClick="btnDesloguear_Click" />
    <asp:Button Text="Volver al Catalogo" CssClass="btn btn-primary" ID="btnVolver" runat="server" OnClick="btnVolver_Click" PostBackUrl="~/Articulos.aspx" />



</asp:Content>
