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
    public partial class ImprimirResponsabilidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora where id='" + TermoResponsabilidade.idvendedora + "'", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    lblnomevendedora.Text = dr["nomecompleto"].ToString();
                    lblcpf.Text = dr["cpf"].ToString();
                    lblbairro.Text = dr["bairro"].ToString();
                    lblendereco.Text = dr["endereco"].ToString();
                    lblrg.Text = dr["rg"].ToString();
                    Response.Write("<script>window.print();</script>");
                }
                con.Close();
            }

        }
        
    }
}