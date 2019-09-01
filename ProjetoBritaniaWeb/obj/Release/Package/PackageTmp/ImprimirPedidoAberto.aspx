<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ImprimirPedidoAberto.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirPedidoAberto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <legend>
      <i class="glyphicon glyphicon-print"></i> Imprimir Pedidos em Aberto<br />
        </legend>
    <asp:GridView ID="Consulta_adm" runat="server" EmptyDataText="Sem dados para exibir..." AutoGenerateColumns="false" AllowPaging="True" PageSize="35" ShowFooter="True"  onpageindexchanging="GridView1_PageIndexChanging" Width="813px" CssClass="table table-bordered table-responsive" >
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
        <asp:TemplateField HeaderText="Imprimir">
        <ItemTemplate>
        <center><a href="ImprimirPedidoAbertoI.aspx?VendaId=<%#Eval("VendaId")%>"><i class="glyphicon glyphicon-print"></i></a></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
        <ItemTemplate>
        <center><a href="ImprimirPedidoAbertoI.aspx?VendaId=<%#Eval("VendaId")%>"><i class="glyphicon glyphicon-trash"></i></a></center>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
