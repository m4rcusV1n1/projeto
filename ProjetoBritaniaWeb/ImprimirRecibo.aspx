<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImprimirRecibo.aspx.cs" Inherits="ProjetoBritaniaWeb.ImprimirRecibo" %>

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
            <h1>Recibo de Pagamento de Indicação</h1>
            </center>
            <br />
             <br />
            <p>1° via</p>
            <hr />
            <p><strong>Quantidade de Parcelas: <asp:Label ID="txtquantidade" runat="server" Text="" style="font-weight: 700"></asp:Label></strong></p>
            <p><strong>Valor: <asp:Label ID="txtvalor" runat="server" Text="" style="font-weight: 700"></asp:Label></strong></p>
        <p>Eu <asp:Label ID="txtvendedora" runat="server" Text="" style="font-weight: 700"></asp:Label>, Portadora do <strong>CPF:</strong> 
            <asp:Label ID="txtcpf" runat="server" Text="" style="font-weight: 700"></asp:Label>
        &nbsp;recebi de <strong>Britânia Jóias</strong> a quantia do valor especificado acima, correspondente ao pagamento de <strong>10%</strong> das vendas da vendedora indicada:
            <asp:Label ID="txtindicacao" runat="server" Text="" style="font-weight: 700"></asp:Label>
            ,</p>
        <p><strong>Data do recebimento:</strong>
            <asp:Label ID="txtdata" runat="server" Text="" style="font-weight: 700"></asp:Label>
        </p>
        <p>Assinatura de quem fez a indicação e recebimento da importância: ____________________________________________</p>
        <p><strong>Observação: Lembrando que a promoção indique um amigo, só é válida durante 03 meses.</strong></p>



             <br />
             <br />
            <p>2° via</p>
            <hr />
            <p><strong>Quantidade de Parcelas: <asp:Label ID="txtqtd1" runat="server" Text="" style="font-weight: 700"></asp:Label></strong></p>
            <p><strong>Valor: <asp:Label ID="txtvalor1" runat="server" Text="" style="font-weight: 700"></asp:Label></strong></p>
        <p>Eu <asp:Label ID="txtvendedora1" runat="server" Text="" style="font-weight: 700"></asp:Label>, Portadora do <strong>CPF:</strong> 
            <asp:Label ID="txtcpf1" runat="server" Text="" style="font-weight: 700"></asp:Label>
        &nbsp;recebi de <strong>Britânia Jóias</strong> a quantia do valor especificado acima, correspondente ao pagamento de <strong>10%</strong> das vendas da vendedora indicada:
            <asp:Label ID="txtindicacao1" runat="server" Text="" style="font-weight: 700"></asp:Label>
            ,</p>
        <p><strong>Data do recebimento:</strong>
            <asp:Label ID="txtdata1" runat="server" Text="" style="font-weight: 700"></asp:Label>
        </p>
        <p>Assinatura de quem fez a indicação e recebimento da importância: ____________________________________________</p>
        <p><strong>Observação: Lembrando que a promoção indique um amigo, só é válida durante 03 meses.</strong></p>
            </div>
    </form>
</body>
</html>
