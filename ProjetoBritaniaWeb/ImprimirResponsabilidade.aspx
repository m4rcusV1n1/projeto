<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirResponsabilidade.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirResponsabilidade" %>

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
            <h1>Termo de Responsabilidade</h1>
            </center>
            <br />
        <br />
        <p>Eu  
                <asp:Label ID="lblnomevendedora" runat="server" style="font-weight: 700"></asp:Label>
                , Portadora de RG: 
                <asp:Label ID="lblrg" runat="server" style="font-weight: 700"></asp:Label>
                ,
CPF: 
                <asp:Label ID="lblcpf" runat="server" style="font-weight: 700"></asp:Label>
                , residente na rua:
                <asp:Label ID="lblendereco" runat="server" style="font-weight: 700"></asp:Label>
&nbsp;Bairro: 
                <asp:Label ID="lblbairro" runat="server" style="font-weight: 700"></asp:Label>
                , me responsabilizo totalmente, pelas jóias que a mim foram entregues pela empresa <strong>Britânia Jóias</strong>, <strong>CNPJ: 26.275.930/0001-41</strong>, com o objetivo para que eu venda e ganhe 30 % de comissão em cima das vendas, portanto é de minha responsabilidade efetuar o pagamento das jóias até a data prevista pela empresa.


            </p>
        <br />
                   <br />
                   <br />
        <br />
        <br />
                   <br />
               <center>Salvador, __ de_________de_____
                   
               
        <br />
        <br />
        <br />
&nbsp;_________________________________________________
                                                          <br />
                   Vendedora<br />
                   <br />
&nbsp;_________________________________________________
                                                        <br />
                   Britânia Jóias </center>
    </div>
    </form>
</body>
</html>
