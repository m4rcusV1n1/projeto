using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoBritaniaWeb
{
    public partial class EntradaPedidoUser : System.Web.UI.Page
    {
        private void carregacombo()
        {
            {
                using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora", con))
                    {
                        
                        txttermoRes.DataTextField = "nomecompleto";
                        txttermoRes.DataValueField = "id";
                        txttermoRes.DataSource = cmd.ExecuteReader();
                        txttermoRes.DataBind();
                        txttermoRes.Items.Insert(0, new ListItem("Selecione uma Vendedora", ""));

                    }
                    con.Close();
                }

            }
        }
        public static string idvendedora;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carregacombo();
            }
        }

        protected void BtnAbrir_Click(object sender, EventArgs e)
        {
            
            idvendedora = txttermoRes.SelectedValue;
            Response.Redirect("EntradaPedido.aspx");
        }
    }
}