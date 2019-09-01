<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirRelatorioAberto.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirRelatorioAberto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
     <div class="container">
        <center>
    <img src="Imagens/Marcasistema.png" width="154" height="135" class="img-responsive" style="margin-top:10px;" />
            <h2>Lista de Vendedoras com Pedidos em Aberto</h2>
            <br />
            <asp:GridView ID="Consulta_adm" runat="server" AutoGenerateColumns="false"  ShowFooter="True"  Width="813px" CssClass="table table-bordered table-responsive" >
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
            </center>
            <br />
    </div>
    </form>
</body>
</html>
