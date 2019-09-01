using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoBritaniaWeb
{
    public partial class ImprimirRecibo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        private string strsql;
        private void ConsultarVendedora()
        {

            strsql = "select * from tb_cadastro_vendedora where nomecompleto='" + Recibo.idvendedora + "'";
            SqlCommand comando = new SqlCommand(strsql, con);

            try
            {
                con.Open();
                SqlDataReader dr = comando.ExecuteReader();
                dr.Read();

                txtcpf.Text = dr["cpf"].ToString();
                txtcpf1.Text = dr["cpf"].ToString();
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
            string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ConsultarVendedora();
            txtquantidade.Text = Recibo.QtdParcelas;
            txtvalor.Text = Recibo.Valor;
            txtvendedora.Text = Recibo.idvendedora;
            txtindicacao.Text = Recibo.idindicacao;
            txtdata.Text = data;

            txtqtd1.Text = Recibo.QtdParcelas;
            txtvalor1.Text = Recibo.Valor;
            txtvendedora1.Text = Recibo.idvendedora;
            txtindicacao1.Text = Recibo.idindicacao;
            txtdata1.Text = data;


        }
    }
}