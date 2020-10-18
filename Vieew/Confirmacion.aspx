<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Confirmacion.aspx.cs" Inherits="Vieew.Confirmacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div>
        <label class="text-primary">Seguro que desea eliminar el articulo <% = Request.QueryString["Name"] %>?</label>  
        <asp:Button CssClass="btn btn-primary" Text="Aceptar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click1" />
        <asp:Button CssClass="btn btn-danger" Text="Cancelar" runat="server" ID="btnCancealr" OnClick="btnCancealr_Click"/>  
    </div>
</asp:Content>
