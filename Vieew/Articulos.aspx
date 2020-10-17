<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="Vieew.Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <h1 Style="margin-left:15px">Listado de articulos</h1>

    <asp:Label Style="margin-left:15px" class="col-form-label"  ID="lblBienvenida" Text="Bienvenido: " Visible="false" runat="server" />
    <asp:TextBox ID="txtBuscar" CssClass="form-control mr-sm-2" Style="margin-left:15px" placeholder="Buscar por nombre" runat="server" />
    <asp:Button ID="btnBuscar" Style="margin-left:15px; margin-bottom:15px; margin-top:10px" CssClass="btn btn-success"  Text="Buscar" runat="server" OnClick="btnBuscar_Click" />

    <div class="card-columns" style="margin-left: 15px; margin-right: 5px;">
        <%       foreach (var item in ListaArticulos)
            { %>
        <div class="card" style="width: 18rem;">
            <img src="<% = item.ImagenURL %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% = item.Nombre %></h5>
                <p class="card-text"><% = item.Precio %></p>
                <a href="Detalles.aspx?idart=<% = item.Id.ToString() %>" class="btn btn-primary">Seleccionar</a>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
