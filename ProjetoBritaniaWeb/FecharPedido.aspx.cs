using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoBritaniaWeb
{
    public partial class FecharPedido : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        private string strsql;
        float TotalVenda = 0;
        DataRow Linha;
        public static string cpf;
        private void ConsultarVendedora()
        {

            strsql = "select * from tb_cadastro_vendedora where id='" + CodCliente + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                lblnomevendedora.Text = dr["nomecompleto"].ToString();
                cpf = dr["cpf"].ToString();
                lblcodigovendedora.Text = CodCliente;
            }
            catch
            {

            }
            finally
            {

                con.Close();
            }
        }
        private void ConsultarValorEntregue()
        {
            string id = Request.QueryString["VendaId"];
            strsql = "select * from fechar_caixa where VendaId='" + id + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                lblvalorentregue.Text = dr["ValorTotal"].ToString();
                CodCliente = dr["CodCliente"].ToString();
                txtcode.Text = dr["VendaId"].ToString();
            }
            catch 
            {
               
            }
            finally
            {

                con.Close();
            }
        }
        public static string CodCliente;
       
        private void ConsultarProduto()
        {
            txtcodbarra.Focus();
            strsql = "select * from tb_produto where codigobarra='" + txtcodbarra.Text + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                if (!dr.HasRows)
                {

                    Response.Write("<script type='text/javascript'>alert('Produto não encontrado! Efetue o cadastro');</script>");
                    txtcodbarra.Text = "";
                    txtcodbarra.Focus();

                }
                else
                {

                    txtnomeproduto.Text = dr["nomeproduto"].ToString();
                    int quantidade = int.Parse(dr["Quantidade"].ToString());

                    string converter = dr["valorprodutofinal"].ToString();
                    double converterconversao = Convert.ToDouble(converter);
                    txtvalorproduto.Text = converterconversao.ToString("F");

                    txtquantidade.Focus();
                }
            }
            catch
            {

            }
            finally
            {

                con.Close();
            }
        }

        private void GravarVenda()
        {
            strsql = "insert into fechar_caixa_devolucao(VendaId, ValorTotal, ValorSemDesconto, comissao, ValorTotalPagar, ValorTotalEntregue, CodCliente, DataFechamento) values (@VendaId, @ValorTotal, @ValorSemDesconto, @comissao, @ValorTotalPagar, @ValorTotalEntregue, @CodCliente, @DataFechamento)";
            SqlCommand comando = new SqlCommand(strsql, con);

            string DataFechamento = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            comando.Parameters.AddWithValue("@VendaId", Convert.ToInt32(txtcode.Text));
            comando.Parameters.AddWithValue("@ValorTotal", txtvalortotalinsert.Text);
            comando.Parameters.AddWithValue("@ValorSemDesconto", lblvalorsdesconto.Text);
            comando.Parameters.AddWithValue("@comissao", lblcomissao.Text);
            comando.Parameters.AddWithValue("@ValorTotalPagar", lblvalorpagar.Text);
            comando.Parameters.AddWithValue("@ValorTotalEntregue", lblvalorentregue.Text);
            comando.Parameters.AddWithValue("@CodCliente", lblcodigovendedora.Text);
            comando.Parameters.AddWithValue("@DataFechamento", DataFechamento);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                Response.Write("<script type='text/javascript'>alert('Pedido Fechado com Sucesso');</script><script type='text/javascript'>window.location.href = 'ImprimirPedidoFechado.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('Erro ao Fechar Pedido.\n') ; </script>" + ex.Message);

            }
            finally
            {

                inserir();
                con.Close();


                //GridView1.Rows.;
                txtvalortotalinsert.Text = "0";
                txtcodbarra.Focus();

            }

        }
        private void inserir()
        {

            strsql = "insert into tb_pedidos_fechado (VendaId, codigobarras, nomeproduto, valorproduto, quantidade, valortotal, CodCliente) values (@VendaId, @codigobarras, @nomeproduto, @valorproduto, @quantidade, @valortotal, @CodCliente)";
            SqlCommand comando = new SqlCommand(strsql, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                for (int i = 0; i < gridTamanhos.Rows.Count; i++)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@VendaId", txtcode.Text);
                    comando.Parameters.AddWithValue("@codigobarras", gridTamanhos.Rows[i].Cells[0].Text);
                    comando.Parameters.AddWithValue("@nomeproduto", gridTamanhos.Rows[i].Cells[1].Text);
                    comando.Parameters.AddWithValue("@valorproduto", gridTamanhos.Rows[i].Cells[2].Text);
                    comando.Parameters.AddWithValue("@quantidade", gridTamanhos.Rows[i].Cells[3].Text);
                    comando.Parameters.AddWithValue("@valortotal", gridTamanhos.Rows[i].Cells[4].Text);
                    comando.Parameters.AddWithValue("@CodCliente", lblcodigovendedora.Text);



                    comando.ExecuteNonQuery();


                }
            }
            catch
            {

            }

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                txtvalortotalinsert.Text = "0,00";
                lblvalorpagar.Text = "0";
                lblvalorsdesconto.Text = "0";
                lblcomissao.Text = "0";
                txtcodbarra.Focus();
                ConsultarValorEntregue();
                ConsultarVendedora();

                DataTable tbDados;
                DataColumn Coluna;
                Session["contador"] = 0;
                tbDados = new DataTable();
                Coluna = new DataColumn();
                Coluna.DataType = System.Type.GetType("System.String");
                Coluna.ColumnName = "Código";
                tbDados.Columns.Add(Coluna);
                Coluna = new DataColumn();
                Coluna.DataType = System.Type.GetType("System.String");
                Coluna.ColumnName = "Produto";
                tbDados.Columns.Add(Coluna);
                Coluna = new DataColumn();
                Coluna.DataType = System.Type.GetType("System.String");
                Coluna.ColumnName = "Valor Unitário";
                tbDados.Columns.Add(Coluna);
                Coluna = new DataColumn();
                Coluna.DataType = System.Type.GetType("System.String");
                Coluna.ColumnName = "Quantidade";
                tbDados.Columns.Add(Coluna);
                Coluna = new DataColumn();
                Coluna.DataType = System.Type.GetType("System.String");
                Coluna.ColumnName = "Valor Total";

                tbDados.Columns.Add(Coluna);
                Session["TabelaDados"] = tbDados;
                gridTamanhos.DataSource = tbDados;
                gridTamanhos.DataBind();

            }
        }

        protected void txtcodbarra_TextChanged(object sender, EventArgs e)
        {
            if (txtcodbarra.Text != string.Empty)
            {
                ConsultarProduto();
            }
            else
            {
                txtcodbarra.Focus();
            }

        }

        protected void txtquantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtquantidade.Text != string.Empty)
            {
                txtvalortotal.Text = (float.Parse(txtvalorproduto.Text) * float.Parse(txtquantidade.Text)).ToString();
                txtvalortotal.Text = Convert.ToDouble(txtvalortotal.Text).ToString("F");
                txtsalvar.Focus();
            }
            else
            {
                //MessageBox.Show("DIGITE A QUANTIDADE", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Response.Write("<script type='text/javascript'>alert('DIGITE A QUANTIDADE');</script>");

            }
        }

        protected void txtsalvar_Click(object sender, EventArgs e)
        {


            DataTable tbDadosSession = new DataTable();
            tbDadosSession = (DataTable)Session["TabelaDados"];
            //string conteudoTextBox = TextBox1.Text;
            Linha = tbDadosSession.NewRow();
            Linha["Código"] = txtcodbarra.Text;
            Linha["Produto"] = txtnomeproduto.Text;
            Linha["Valor Unitário"] = txtvalorproduto.Text;
            Linha["Quantidade"] = txtquantidade.Text;
            Linha["Valor Total"] = txtvalortotal.Text;



            //TotalVenda += float.Parse(tbDadosSession.cells[4].ToString());
            //txtvalortotalinsert.Text = TotalVenda.ToString();
            //txtvalortotalinsert.Text = Convert.ToDouble(txtvalortotalinsert.Text).ToString("F");

            tbDadosSession.Rows.Add(Linha);
            Session["TabelaDados"] = tbDadosSession;
            gridTamanhos.DataSource = tbDadosSession;
            gridTamanhos.DataBind();
            Session["contador"] = tbDadosSession.Rows.Count;

            foreach (GridViewRow row in gridTamanhos.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    if (!String.IsNullOrEmpty(row.Cells[4].Text))
                    {
                        TotalVenda += float.Parse(row.Cells[4].Text);
                        txtvalortotalinsert.Text = TotalVenda.ToString("F");
                        txtvalortotalinsert.Text = Convert.ToDouble(txtvalortotalinsert.Text).ToString("F");
                        double converter = Convert.ToDouble(lblvalorsdesconto.Text);
                        converter = Convert.ToDouble(lblvalorentregue.Text) - Convert.ToDouble(txtvalortotalinsert.Text);
                        lblvalorsdesconto.Text = converter.ToString("F");
                        double converter2 = Convert.ToDouble(lblvalorpagar.Text);
                        double converter3 = Convert.ToDouble(lblcomissao.Text);
                        converter3 = Convert.ToDouble(lblvalorsdesconto.Text) * 30 / 100;
                        lblcomissao.Text = converter3.ToString("F");
                        converter2 = converter - converter3;
                        lblvalorpagar.Text = converter2.ToString("F");
                    }
                }
            }
            txtcodbarra.Focus();
            txtcodbarra.Text = String.Empty;
            txtnomeproduto.Text = String.Empty;
            txtvalorproduto.Text = String.Empty;
            txtquantidade.Text = String.Empty;
            txtvalortotal.Text = String.Empty;
        }

        protected void btnfinalizarpedido_Click(object sender, EventArgs e)
        {
            GravarVenda();
            MudarStatus();

        }
        private void MudarStatus()
        {
            string status = "Fechado";
            strsql = "UPDATE fechar_caixa SET status='" + status + "' where VendaId='" + txtcode.Text + "'";
            SqlCommand comando = new SqlCommand(strsql, con);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
            }
            catch 
            {
                
            }
        }
    }
}