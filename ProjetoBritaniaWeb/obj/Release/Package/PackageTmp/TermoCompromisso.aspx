<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="TermoCompromisso.aspx.cs" Inherits="ProjetoBritaniaWeb.TermoCompromisso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
          <legend>
      <i class="glyphicon glyphicon-list-alt"></i> Termo de Compromisso<br />
        </legend>
        <div class="row">
            <div class="col-md-6">
        
    <asp:Label ID="Label1" runat="server" Text="Selecione o nome da Vendedora"></asp:Label>
    <br />
    <asp:DropDownList ID="txtvendedora" runat="server" CssClass="form-control"></asp:DropDownList>
                <br />
                 <asp:Label ID="Label2" runat="server" Text="Indicação"></asp:Label>
    <br />
    <asp:DropDownList ID="txtindicacao" runat="server" CssClass="form-control"></asp:DropDownList>
                <br />
                 <asp:Button ID="BtnAbrir" runat="server" Text="Imprimir Termo" CssClass="btn btn-large btn-primary" Width="250px" OnClick="BtnAbrir_Click" />
                </div>
        </div>
        </div>
</asp:Content>
