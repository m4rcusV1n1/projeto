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
    public partial class ImprimirPedidoAbertoI : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        private string strsql;
        private void ConsultarVenda()
        {
            string id = Request.QueryString["VendaId"];
            strsql = "SELECT a.VendaId ,b.nomecompleto, b.cpf ,a.ValorTotal ,a.DataVenda ,a.Status FROM fechar_caixa as a join tb_cadastro_vendedora as b on a.CodCliente = b.id where VendaId='" + id + "'";
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
            string Data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtdata.Text = Data;
            ConsultarVenda();
            string id = Request.QueryString["VendaId"];
            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
            cnx.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tb_gerar_pedido where id_pedido='" + id + "'", cnx);
            DataSet dst = new DataSet();
            adp.Fill(dst);
            Consulta_adm.DataSource = dst;
            Consulta_adm.DataBind();
        }
    }
}