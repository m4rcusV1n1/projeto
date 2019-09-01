<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirCompromisso.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirCompromisso" %>

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
            <h1>Termo de Compromisso</h1>
            </center>
    <p>
        &nbsp;</p>
        <p>
        Termo de Compromisso de 10% por indicação no periodo de 3 meses.

    </p>
        <p>
            Eu <strong>Britânia Jóias</strong> Portadora do <strong>CNPJ: 26.275.930/0001-41</strong>, residente na <strong>Rua José Bonifácio N° 50</strong>, Bairro <strong>Vila Rui Barbosa</strong> em <strong>Salvador / Bahia</strong>, firmo o compromisso em pagar 10% á:


    </p>
        <p>
            Nome:
            <asp:Label ID="lblnome" runat="server" style="font-weight: 700"></asp:Label>
&nbsp;</p>
        <p>
CPF: 
            <asp:Label ID="lblcpf" runat="server" style="font-weight: 700"></asp:Label>
&nbsp;</p>
        <p>
Em cima das vendas do indicado(a)


    </p>
        <p>
            Indicação:
            <asp:Label ID="lblnomeindicacao" runat="server" style="font-weight: 700"></asp:Label>


    </p>
        <p>
            CPF Indicação:
            <asp:Label ID="lblcpfindicacao" runat="server" style="font-weight: 700"></asp:Label>


    </p>
        <p>
            Sendo que esse percentual será pago após confirmação do pagamento das indicações durante o periodo de 03 meses a iniciar da data abaixo, lembrando que esse percentual se firma só por periodo de 3 meses sem acréscimos de tempo a mais.
</p>
        <p>
            <strong>Obs.</strong> Lembrando que se a vendedora indicada não realizar o pagamento das
vendas na data marcada e não devolver as jóias em perfeito estado, quem indicou
perde o direito de receber a porcentagem naquele mês.
Abaixo assinaturas da propietária da Britânia Jóias e da vendedora que indicou. </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <center>
            Salvador, ___/___/_____

<br />
            <br />
            <br />
            _______________________________________
<br />
            Britânia Jóias<br />
            <br />
            <br />
&nbsp;_______________________________________
            <br />
            Vendedora    </div>
    </form>
</body>
</html>
