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
    public partial class EntradaPedido : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        private string strsql;
        float TotalVenda = 0;
        DataRow Linha;
        public static string cpf;
        private void ConsultarVendedora()
        {

            strsql = "select * from tb_cadastro_vendedora where id='" + lblcodigovendedora.Text + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                lblnomevendedora.Text = dr["nomecompleto"].ToString();
                cpf = dr["cpf"].ToString();
            }
            catch 
            {
                
            }
            finally
            {

                con.Close();
            }
        }

        private void Gerarcodigo()
        {
            strsql = "select max(id_pedido) from tb_gerar_pedido";
            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand(strsql, con);
                if (comando.ExecuteScalar() == DBNull.Value)
                {
                    txtcode.Text = "1";

                }
                else
                {
                    Int32 ra = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    txtcode.Text = ra.ToString();
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

                    //string converter = dr["valorprodutofinal"].ToString();
                    //double converterconversao = Convert.ToDouble(converter);
                    //txtvalorproduto.Text = converterconversao.ToString("F");
                    txtvalorproduto.Text = dr["valorprodutofinal"].ToString();

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
            strsql = "insert into fechar_caixa(VendaId, ValorTotal, CodCliente, DataVenda, Status) values (@VendaId, @ValorTotal, @CodCliente, @DataVenda, @Status)";
            SqlCommand comando = new SqlCommand(strsql, con);
            string Status = "Aberto";
            string DataVenda = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            comando.Parameters.AddWithValue("@VendaId", Convert.ToInt32(txtcode.Text));
            comando.Parameters.AddWithValue("@ValorTotal", txtvalortotalinsert.Text);
            comando.Parameters.AddWithValue("@CodCliente", lblcodigovendedora.Text);
            comando.Parameters.AddWithValue("@DataVenda", DataVenda);
            comando.Parameters.AddWithValue("@Status", Status);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                Response.Write("<script type='text/javascript'>alert('Pedido Inserido com Sucesso');</script><script type='text/javascript'>window.location.href = 'ImprimirPedidoAberto.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('Erro ao Inserir Pedido.\n') ; </script>" + ex.Message);

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

            strsql = "insert into tb_gerar_pedido (id_pedido, codigobarras, nomeproduto, valorproduto, quantidade, valortotal, CodCliente) values (@id_pedido, @codigobarras, @nomeproduto, @valorproduto, @quantidade, @valortotal, @CodCliente)";
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
                    comando.Parameters.AddWithValue("@id_pedido", txtcode.Text);
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
            lblcodigovendedora.Text = EntradaPedidoUser.idvendedora;
            txtvalortotalinsert.Text = "0,00";
            Gerarcodigo();
            txtcodbarra.Focus();
            
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
                string conversao = (float.Parse(txtvalorproduto.Text) * float.Parse(txtquantidade.Text)).ToString();

                txtvalortotal.Text = Convert.ToDouble(conversao, System.Globalization.CultureInfo.GetCultureInfo("pt-BR")).ToString("F");
                //txtvalortotal.Text = Convert.ToDouble(txtvalortotal.Text).ToString("F");
                //txtvalortotal.Text = Convert.ToDouble(conversao).ToString("F");
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
                    if (!String.IsNullOrEmpty(row.Cells[4].Text)) { 
                        TotalVenda += float.Parse(row.Cells[4].Text);
                    txtvalortotalinsert.Text = TotalVenda.ToString("F");
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
        }
    }
}