<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="CadastrarVendedora.aspx.cs" Inherits="ProjetoBritaniaWeb.CadastrarVendedora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
         
                 <fieldset>
        <legend>
      <i class="glyphicon glyphicon-shopping-cart"></i>Cadastrar Cliente<br />
        </legend>
                     </fieldset>
         <div class="row">
             <div class="col-md-6">
    <asp:Label ID="Label1" runat="server" Text="Nome Completo:"></asp:Label>
    <br />
    <asp:TextBox ID="TxtNomeCompleto" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
                 <div class="col-md-6">
                 <asp:Label ID="Label2" runat="server" Text="CPF:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcpf" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         <div class="row">
             <div class="col-md-4">
                    <asp:Label ID="Label3" runat="server" Text="RG:"></asp:Label>
    <br />
    <asp:TextBox ID="txtrg" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
              <div class="col-md-4">
          <asp:Label ID="Label5" runat="server" Text="Bairro:"></asp:Label>
    <br />
    <asp:TextBox ID="txtbairro" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
              <div class="col-md-4">
                    <asp:Label ID="Label6" runat="server" Text="Cidade:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcidade" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
             </div>

                    <asp:Label ID="Label4" runat="server" Text="Endereço:"></asp:Label>
    <br />
    <asp:TextBox ID="txtendereco" runat="server" CssClass="form-control"></asp:TextBox>
                   <div class="row">
             <div class="col-md-6">
                    <asp:Label ID="Label7" runat="server" Text="Telefone Fixo:"></asp:Label>
    <br />
    <asp:TextBox ID="txttelefonefixo" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
                <div class="col-md-6">
                    <asp:Label ID="Label8" runat="server" Text="Celular:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcelular" runat="server" CssClass="form-control" ></asp:TextBox>
                    </div>
                       </div>
                    <asp:Label ID="Label9" runat="server" Text="Emprego Fixo:"></asp:Label>
    <br />
    <asp:TextBox ID="txtempregofixo" runat="server" CssClass="form-control"></asp:TextBox>
         <div class="row">
             <div class="col-md-4">
                    <asp:Label ID="Label10" runat="server" Text="Nome da Empresa:"></asp:Label>
    <br />
    <asp:TextBox ID="txtnomeEmpresa" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             <div class="col-md-4">
                    <asp:Label ID="Label11" runat="server" Text="Tempo da Empresa:"></asp:Label>
    <br />
    <asp:TextBox ID="txttempoempresa" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
                 <div class="col-md-4">
                    <asp:Label ID="Label12" runat="server" Text="Contato da Empresa:"></asp:Label>
    <br />
    <asp:TextBox ID="txtcontatoempresa" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
          <div class="row">
             <div class="col-md-6">
                    <asp:Label ID="Label13" runat="server" Text="Referência 1:"></asp:Label>
    <br />
    <asp:TextBox ID="txtreferencia1" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
               <div class="col-md-6">
                    <asp:Label ID="Label14" runat="server" Text="Referência 2:"></asp:Label>
    <br />
    <asp:TextBox ID="txtreferencia2" runat="server" CssClass="form-control"></asp:TextBox>
                   </div>
              </div>
         <div class="row">
             <div class="col-md-4">
                    <asp:Label ID="Label15" runat="server" Text="Ultimas Contas 1:"></asp:Label>
    <br />
    <asp:TextBox ID="txtultimas1" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             <div class="col-md-4">
                    <asp:Label ID="Label16" runat="server" Text="Ultimas Contas 2:"></asp:Label>
    <br />
    <asp:TextBox ID="txtultimas2" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             <div class="col-md-4">
                    <asp:Label ID="Label17" runat="server" Text="Ultimas Contas 3:"></asp:Label>
    <br />
    <asp:TextBox ID="txtultimas3" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
             </div>
         <div class="row">
         <div class="col-md-6">
                    <asp:Label ID="Label18" runat="server" Text="E-mail:"></asp:Label>
    <br />
    <asp:TextBox ID="txtemail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
             </div>
             <div class="col-md-6">
                    <asp:Label ID="Label19" runat="server" Text="Data do Aniversário:"></asp:Label>
    <br />
    <asp:TextBox ID="txtdtaniversario" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                  </div>
              </div>
         <br />
                    <asp:Button ID="btnCadastrarCliente" runat="server" Text="Cadastrar Cliente" CssClass="btn btn-large btn-primary" Width="250px" OnClick="btnCadastrarCliente_Click"  />
                 <br />
                 <br />
         <br />
                  <asp:GridView ID="dataGridView1" runat="server" EmptyDataText="Sem dados para exibir..." AutoGenerateColumns="false" AllowPaging="True" PageSize="35" ShowFooter="True"   Width="1110px" CssClass="table table-bordered table-responsive" >
        <Columns>
        <asp:TemplateField HeaderText="Nome Completo">
        <ItemTemplate>
        <center><%# Eval("nomecompleto") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CPF" >
        <ItemTemplate>
        <center><%# Eval("cpf") %></center>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="RG" >
        <ItemTemplate>
         <center><%# Eval("rg") %></center>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Telefone Fixo">
        <ItemTemplate>
        <center><%# Eval("telefonefixo") %></center>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="Celular">
        <ItemTemplate>
        <center><%# Eval("celular") %></center>
        </ItemTemplate>
        </asp:TemplateField>
  <asp:TemplateField HeaderText="Excluir">
        <ItemTemplate>
        <center><a href="ExcluirVendedora.aspx?id=<%#Eval("id")%>"><i class="glyphicon glyphicon-trash"></i></a></center>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
         <br />
                 </div>
        
</asp:Content>
