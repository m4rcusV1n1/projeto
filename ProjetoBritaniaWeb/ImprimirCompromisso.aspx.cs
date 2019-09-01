using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoBritaniaWeb
{
    public partial class ImprimirCompromisso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora where id='" + TermoCompromisso.idvendedora + "'", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    lblnome.Text = dr["nomecompleto"].ToString();
                    lblcpf.Text = dr["cpf"].ToString();
                    Response.Write("<script>window.print();</script>");
                }
                con.Close();
            }
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora where id='" + TermoCompromisso.idindicacao + "'", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    lblnomeindicacao.Text = dr["nomecompleto"].ToString();
                    lblcpfindicacao.Text = dr["cpf"].ToString();
                    
                }
                con.Close();
            }
        }
    }
}