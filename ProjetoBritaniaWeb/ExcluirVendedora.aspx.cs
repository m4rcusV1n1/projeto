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
    public partial class ExcluirVendedora : System.Web.UI.Page
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123";
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string sql = "DELETE FROM tb_cadastro_vendedora WHERE id='" + id + "'";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Response.Write("<script type='text/javascript'>alert('Item Excluido com Sucesso');</script></script><script type='text/javascript'>window.location.href = 'CadastrarVendedora.aspx';</script>");
                
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('Erro ao Excluir');</script></script>");
            }
            finally
            {
                con.Close();
            }

        }
    }
}