<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EntradaPedidoUser.aspx.cs" Inherits="ProjetoBritaniaWeb.EntradaPedidoUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
        <legend>
      <i class="glyphicon glyphicon-shopping-cart"></i>Entrada do Pedido<br />
        </legend>
    <asp:Label ID="Label1" runat="server" Text="Selecione o nome da Vendedora"></asp:Label>
    <br />
    <asp:DropDownList ID="txttermoRes" runat="server" CssClass="form-control"></asp:DropDownList>
                <br />
                 <asp:Button ID="BtnAbrir" runat="server" Text="Abrir Pedido" CssClass="btn btn-large btn-primary" Width="250px" OnClick="BtnAbrir_Click" />
                </div>
        </div>
        </div>
</asp:Content>
