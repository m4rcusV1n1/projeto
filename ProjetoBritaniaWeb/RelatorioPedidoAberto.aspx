<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="RelatorioPedidoAberto.aspx.cs" Inherits="ProjetoBritaniaWeb.RelatorioPedidoAberto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <legend>
            <i class="glyphicon glyphicon-user"></i> Lista de Vendedoras com Pedidos em Aberto<br />
        </legend>
    <asp:GridView ID="Consulta_adm" runat="server" AutoGenerateColumns="false" EmptyDataText="Não Existe Vendedora Com Pedidos Em Aberto"  ShowFooter="True"  Width="813px" CssClass="table table-bordered table-responsive" >
        <Columns>
        <asp:TemplateField HeaderText="Código da Venda">
        <ItemTemplate>
        <center><%# Eval("VendaId") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Vendedora" >
        <ItemTemplate>
        <center><%# Eval("nomecompleto") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Valor da Venda" >
        <ItemTemplate>
         <center><%# Eval("ValorTotal") %></center>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Data da Venda">
        <ItemTemplate>
        <center><%# Eval("DataVenda") %></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
        <ItemTemplate>
        <center><%# Eval("Status") %></center>
        </ItemTemplate>
        </asp:TemplateField>
       
        </Columns>
    </asp:GridView>
        <br />
             <asp:Button ID="btnimprimir" runat="server" Text="Imprimir Lista" CssClass="btn btn-large btn-primary" Width="250px" OnClick="btnimprimir_Click"  />
        </div>
</asp:Content>
