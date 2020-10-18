<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="Vieew.Session" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div class="container">
            <div class="display-4 text-primary">
                Iniciar Sesion
            </div>
            <div class="form-group mt-4">
                <label class="text-primary">Nombre de Usuario</label>
                <asp:TextBox CssClass="form-control" Columns="90" MaxLength="80" ID="txtUser" runat="server" />
            </div>
            <div class="form-group mt-2">
                <label  class="text-primary">Contraseña</label>
                <asp:TextBox CssClass="form-control d-block" Columns="90" MaxLength="8" TextMode="Password" ID="txtPass" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblCompletar"  Visible="false" Text="Debe Ingresar Usuario y contraseña para ingresar" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblFaltaUser"  Visible="false" Text="Debe Ingresar un Usuario para ingresar" runat="server" />
            </div>
            <div class="display-7 text-danger"  style="width:500px">
                <asp:Label ID="lblFaltaPass"  Visible="false" Text="Debe Ingresar la contraseña para ingresar" runat="server" />
            </div>
            <asp:Button Text="Iniciar" CssClass="btn btn-primary" ID="btnIniciar" runat="server" OnClick="btnIniciar_Click" />
        </div>


</asp:Content>
