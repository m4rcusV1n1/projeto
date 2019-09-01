<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ImprimirPedidoFechado.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirPedidoFechado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
     <legend>
      <i class="glyphicon glyphicon-print"></i> Imprimir Fechamento do Pedido<br />
        </legend>
    <asp:GridView ID="Consulta_adm" runat="server" EmptyDataText="Sem dados para exibir..." AutoGenerateColumns="false"  ShowFooter="True"   Width="813px" CssClass="table table-bordered table-responsive" >
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
        <asp:TemplateField HeaderText="Valor da Devolução" >
        <ItemTemplate>
         <center><%# Eval("ValorTotal") %></center>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Valor Sem Desconto">
        <ItemTemplate>
        <center><%# Eval("ValorSemDesconto") %></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Comissão">
        <ItemTemplate>
        <center><%# Eval("comissao") %></center>
        </ItemTemplate>
        </asp:TemplateField>
             <asp:TemplateField HeaderText="Valor Total a Pagar">
        <ItemTemplate>
        <center><%# Eval("ValorTotalPagar") %></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Data do Fechamento">
        <ItemTemplate>
        <center><%# Eval("DataFechamento") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Imprimir">
        <ItemTemplate>
        <center><a href="ImprimirPedidoFechadoI.aspx?VendaId=<%#Eval("VendaId")%>"><i class="glyphicon glyphicon-print"></i></a></center>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
