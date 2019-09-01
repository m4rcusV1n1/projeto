<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="Recibo.aspx.cs" Inherits="ProjetoBritaniaWeb.Recibo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <legend>
      <i class="glyphicon glyphicon-print"></i> Gerar Recibo<br />
        </legend>
        <div class="container">
        <div class="row">
            <div class="col-md-6">
        <asp:Label ID="Label1" runat="server" Text="Vendedora:"></asp:Label>
        <br />
        <asp:DropDownList ID="txtvendedora" runat="server" CssClass="form-control">
        </asp:DropDownList>
                <asp:Label ID="Label2" runat="server" Text="Indicação:"></asp:Label>
        <br />
        <asp:DropDownList ID="txtindicacao" runat="server" CssClass="form-control">
        </asp:DropDownList>
                <asp:Label ID="Label3" runat="server" Text="Quantidade de Parcelas:"></asp:Label>
        <br />
        <asp:DropDownList ID="txtparcelas" runat="server" CssClass="form-control" required="required">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1° Parcela</asp:ListItem>
            <asp:ListItem>2° Parcela</asp:ListItem>
            <asp:ListItem>3° Parcela</asp:ListItem>
        </asp:DropDownList>
                <asp:Label ID="Label4" runat="server" Text="Valor:"></asp:Label>
                <asp:TextBox ID="txtvalor" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                 <asp:Button ID="btnimprimir" runat="server" Text="Imprimir Termo" CssClass="btn btn-large btn-primary" Width="250px" OnClick="btnimprimir_Click" />
                </div>
            </div>
        </div>


</asp:Content>
