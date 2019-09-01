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
    public partial class ListPedidosAbertos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
            cnx.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select VendaId, ValorTotal, DataVenda, Status from fechar_caixa where status='Aberto' and  CodCliente='" + FecharPedidoUser.idvendedora + "'", cnx);
            DataSet dst = new DataSet();
            adp.Fill(dst);
            Consulta_adm.DataSource = dst;
            Consulta_adm.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            Consulta_adm.PageIndex = e.NewPageIndex;
            DataSet dst = new DataSet();


        }
    }
}