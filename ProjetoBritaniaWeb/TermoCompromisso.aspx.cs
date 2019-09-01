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
    public partial class TermoCompromisso : System.Web.UI.Page
    {
        private void CarregaComboVendedora()
        {
            {
                using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora", con))
                    {

                        txtvendedora.DataTextField = "nomecompleto";
                        txtvendedora.DataValueField = "id";
                        txtvendedora.DataSource = cmd.ExecuteReader();
                        txtvendedora.DataBind();
                        txtvendedora.Items.Insert(0, new ListItem("Selecione uma Vendedora", ""));

                    }
                    con.Close();
                }

            }
        }
        private void CarregaComboIndicacao()
        {
            {
                using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["BDConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("select * from tb_cadastro_vendedora", con))
                    {

                        txtindicacao.DataTextField = "nomecompleto";
                        txtindicacao.DataValueField = "id";
                        txtindicacao.DataSource = cmd.ExecuteReader();
                        txtindicacao.DataBind();
                        txtindicacao.Items.Insert(0, new ListItem("Selecione uma Indicação", ""));

                    }
                    con.Close();
                }

            }
        }
        public static string idvendedora;
        public static string idindicacao;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaComboIndicacao();
                CarregaComboVendedora();
            }
        }

        protected void BtnAbrir_Click(object sender, EventArgs e)
        {
            idvendedora = txtvendedora.SelectedValue;
            idindicacao = txtindicacao.SelectedValue;
            Response.Redirect("ImprimirCompromisso.aspx");
        }
    }
}