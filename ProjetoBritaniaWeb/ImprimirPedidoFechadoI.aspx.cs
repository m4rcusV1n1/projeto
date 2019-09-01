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
    public partial class ImprimirPedidoFechadoI : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        private string strsql;
        private void ConsultarVenda()
        {
            string id = Request.QueryString["VendaId"];
            strsql = "SELECT a.VendaId ,b.nomecompleto, b.cpf ,a.ValorTotal ,a.ValorSemDesconto ,a.comissao, a.ValorTotalPagar, a.ValorTotalEntregue, a.DataFechamento FROM fechar_caixa_devolucao as a join tb_cadastro_vendedora as b on a.CodCliente = b.id where VendaId='" + id + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                txtvendaid.Text = id;
                txtvendedora.Text = dr["nomecompleto"].ToString();
                txtcpf.Text = dr["cpf"].ToString();
                txtvalortotal.Text = dr["ValorTotal"].ToString();
                txtsemdesconto.Text = dr["ValorSemDesconto"].ToString();
                txtcomissao.Text = dr["comissao"].ToString();
                txtvalortotalpagar.Text = dr["ValorTotalPagar"].ToString();
                txtdtfechamento.Text = dr["DataFechamento"].ToString();
                txtentregue.Text = dr["ValorTotalEntregue"].ToString();
            }
            catch
            {

            }
            finally
            {

                con.Close();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultarVenda();
            string id = Request.QueryString["VendaId"];
            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
            cnx.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tb_pedidos_fechado where VendaId='" + id + "'", cnx);
            DataSet dst = new DataSet();
            adp.Fill(dst);
            Consulta_adm.DataSource = dst;
            Consulta_adm.DataBind();
        }
    }
}