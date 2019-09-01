<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ListPedidosAbertos.aspx.cs" Inherits="ProjetoBritaniaWeb.ListPedidosAbertos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div class="container">
        <legend>
      <i class="glyphicon glyphicon-shopping-cart"></i>Fechar Pedido<br />
        </legend>
    <asp:GridView ID="Consulta_adm" runat="server" AutoGenerateColumns="false" AllowPaging="True" EmptyDataText="Não Existe Pedidos Abertos Para Essa Vendedora" PageSize="35" ShowFooter="True"  onpageindexchanging="GridView1_PageIndexChanging" Width="813px" CssClass="table table-bordered" >
        <Columns>
        <asp:TemplateField HeaderText="Código da Venda">
        <ItemTemplate>
        <center><%# Eval("VendaId") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Valor do Pedido" >
        <ItemTemplate>
        <center><%# Eval("ValorTotal") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Data da Venda" >
        <ItemTemplate>
         <center><%# Eval("DataVenda") %></center>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Status">
        <ItemTemplate>
        <center><%# Eval("Status") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Abrir">
        <ItemTemplate>
        <center><a href="FecharPedido.aspx?VendaId=<%#Eval("VendaId")%>"><i class="glyphicon glyphicon-search"></i></a></center>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
