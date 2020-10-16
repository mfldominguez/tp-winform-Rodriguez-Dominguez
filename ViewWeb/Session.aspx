<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="ViewWeb.Session" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
   
     
    <div class="container">
        <div class="row">
            <div class="col">
                <h1>Login</h1>
            </div>
        </div>
        <div class="row">
            <div class=" col">
                <div class="form-group">
                    <label>Direccion de email</label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
                    <small id="emailHelp" class="form-text text-muted">Acordate del "@"</small>
                </div>
                <div class="form-group">
                    <label>Contraseña</label>
                    <asp:TextBox ID="txtPassword" CssClass="form-control" TextMode="Password" runat="server" />
                </div>
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" runat="server" OnClick="btnAceptar_Click" />
            </div>
        </div>
   </div>
</asp:Content>
