<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EntradaPedido.aspx.cs" Inherits="ProjetoBritaniaWeb.EntradaPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="container">
        <legend>
      <i class="glyphicon glyphicon-shopping-cart"></i>Entrada do Pedido<br />
        </legend>
        <div class="row">
            <div class="col-md-3">
                <span style="font-size:16px;" class="showopacity glyphicon glyphicon-tag"></span> <asp:Label ID="Label1" runat="server" Text="Código da Vendedora"></asp:Label> 
                <br />
                <h5>
        <asp:Label ID="lblcodigovendedora" runat="server" style="font-weight: 700"></asp:Label>
                    </h5>
            </div>
            <div class="col-md-3">
                <span style="font-size:16px;" class="glyphicon glyphicon-edit"></span> <asp:Label ID="Label2" runat="server" Text="Código da Venda"></asp:Label> 
        
                <br />

                <h5>
        <asp:Label ID="txtcode" runat="server" style="font-weight: 700"></asp:Label>
        </h5>
            </div>
               <div class="col-md-3">
                <span style="font-size:16px;" class="showopacity glyphicon glyphicon-user"></span> <asp:Label ID="Label3" runat="server" Text="Nome da Vendedora"></asp:Label> 
        
                <br />
                   <h5>
        <asp:Label ID="lblnomevendedora" runat="server" style="font-weight: 700"></asp:Label>
        </h5>
            </div>
            <div class="col-md-3">
                <span style="font-size:16px;" class="glyphicon glyphicon-euro"></span> <asp:Label ID="Label9" runat="server" Text="Valor Total dos Produtos"></asp:Label> 
        
                <br />
                <h5>
                    <strong>R$</strong> 
        <asp:Label ID="txtvalortotalinsert" runat="server" style="font-weight: 700"></asp:Label>
                </h5>
        
            </div>
        </div>
        <br />
        <br />
        <br />
        <div class="row">
            <div class="col-md-4">
        <span style="font-size:16px;" class="showopacity glyphicon glyphicon-barcode"></span> <asp:Label ID="Label4" runat="server" Text="Código de Barras"></asp:Label> 
        <asp:TextBox ID="txtcodbarra" runat="server" CssClass="form-control"  AutoPostBack="True" OnTextChanged="txtcodbarra_TextChanged"  ></asp:TextBox>
        </div>
             <div class="col-md-4">
        <span style="font-size:16px;" class="showopacity glyphicon glyphicon-tags"></span> <asp:Label ID="Label5" runat="server" Text=" Nome do Produto"></asp:Label> 
        <asp:TextBox ID="txtnomeproduto" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>
            <div class="col-md-4">
                <span style="font-size:16px;" class="showopacity glyphicon glyphicon-euro"></span> <asp:Label ID="Label6" runat="server" Text="Valor do Produto"></asp:Label> 
        <asp:TextBox ID="txtvalorproduto" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>
             </div>
        <br />
         <div class="row">
            <div class="col-md-4">
         <span style="font-size:16px;" class="showopacity glyphicon glyphicon-plus"></span> <asp:Label ID="Label7" runat="server" Text="Quantidade"></asp:Label> 
        <asp:TextBox ID="txtquantidade" runat="server" CssClass="form-control"  AutoPostBack="True" OnTextChanged="txtquantidade_TextChanged" TextMode="Number"></asp:TextBox>
        </div>
             <div class="col-md-4">
        <span style="font-size:16px;" class="showopacity glyphicon glyphicon-euro"></span> <asp:Label ID="Label8" runat="server" Text="Valor Total"></asp:Label> 
                    <asp:TextBox ID="txtvalortotal" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                 </div>
             <div class="col-md-4">
                 <br />
             <asp:Button ID="txtsalvar" runat="server" Text="Adicionar Produto" CssClass="btn btn-large btn-primary" Width="250px" OnClick="txtsalvar_Click" />
                 </div>
             </div>
        <br />
   <asp:GridView ID="gridTamanhos" runat="server" BorderColor="#000000" BorderStyle="Inset" BorderWidth="1px" EmptyDataText="Sem dados para exibir..." CssClass="footable" Width="1114px">
</asp:GridView>
        <br />
             <asp:Button ID="btnfinalizarpedido" runat="server" Text="Finalizar Pedido" CssClass="btn btn-large btn-primary" Width="250px" OnClick="btnfinalizarpedido_Click" />
           </div>
</asp:Content>
