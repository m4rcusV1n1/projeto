<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirPedidoFechadoI.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirPedidoFechadoI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="container">
              
  <table class="table">
    
    <tbody>
      <tr>
             <td> <img src="Imagens/Marcasistema.png" width="154" height="135" /></td>
          <td><strong>Razão:</strong> Britânia Jóias Atacado e Varejo / <strong>CNPJ:</strong> 26.275.930/0001-41<br/><strong>Endereço:</strong> Rua José Bonifácio N° 50<br/><strong>Bairro:</strong> Caminho de Areia / <strong>Cidade:</strong> Salvador-BA<br /><strong>CEP: </strong>40430160 / Tel: (71) 98884-8802 / (71) 3035-2218<br />
              <strong>Email:</strong> contato@britaniajoias.com.br
              <br />
              <strong>Data do Fechamento: </strong>
              <asp:Label ID="txtdtfechamento" runat="server"></asp:Label>
              <br />
              <strong>Pedido N°:</strong>
              <asp:Label ID="txtvendaid" runat="server"></asp:Label>
              <br />
              <strong>Nome da Vendedora:</strong>
              <asp:Label ID="txtvendedora" runat="server"></asp:Label>
              <br />
              <strong>CPF Vendedora:</strong>
              <asp:Label ID="txtcpf" runat="server"></asp:Label>
              <br />
              <strong>Valor Entregue:</strong>
              <asp:Label ID="txtentregue" runat="server"></asp:Label>
              <br />
              <strong>Valor Total Devolução:</strong>
              <asp:Label ID="txtvalortotal" runat="server"></asp:Label>
              <br />
              <strong>Valor Sem Desconto:</strong>
              <asp:Label ID="txtsemdesconto" runat="server"></asp:Label>
              <br />
              <strong>Valor Comissão 30%:</strong>
              <asp:Label ID="txtcomissao" runat="server"></asp:Label>
              <br />
              <strong>Valor Total a Pagar:</strong>
              <asp:Label ID="txtvalortotalpagar" runat="server"></asp:Label>
             </td>
          </tr>
    
    </tbody>
  </table>
         <center>
             <hr />
         <h2>Fechamento de Pedido</h2>
             </center>
         <center>
     <asp:GridView ID="Consulta_adm" runat="server" AutoGenerateColumns="false" AllowPaging="True" PageSize="35" ShowFooter="True"   Width="813px" CssClass="table table-bordered" >
        <Columns>
        <asp:TemplateField HeaderText="Código de Barras" >
        <ItemTemplate>
        <center><%# Eval("codigobarras") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nome do Produto" >
        <ItemTemplate>
         <center><%# Eval("nomeproduto") %></center>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Valor do Produto">
        <ItemTemplate>
        <center><%# Eval("valorproduto") %></center>
        </ItemTemplate>
        </asp:TemplateField>
             <asp:TemplateField HeaderText="Quantidade">
        <ItemTemplate>
        <center><%# Eval("quantidade") %></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Valor Total">
        <ItemTemplate>
        <center><%# Eval("valortotal") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        
        </Columns>
    </asp:GridView>
            </center>
        <center>
            <p>__________________________________________</p>
        <p>Vendedora:</p>
            <p>OBS: Lembrando que a Vendedora, ganha em cima das vendas a comissão de 30%.</p>
            </center>

</div>
    </form>
</body>
</html>
