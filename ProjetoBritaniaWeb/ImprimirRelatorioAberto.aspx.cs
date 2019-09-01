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
    public partial class ImprimirRelatorioAberto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<script>window.print();</script>");
            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
            cnx.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT a.VendaId ,b.nomecompleto ,a.ValorTotal ,a.DataVenda ,a.Status FROM fechar_caixa as a join tb_cadastro_vendedora as b on a.CodCliente = b.id where status ='aberto' order by DataVenda desc", cnx);
            DataSet dst = new DataSet();
            adp.Fill(dst);
            Consulta_adm.DataSource = dst;
            Consulta_adm.DataBind();
        }
    }
}