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
    public partial class CadastrarVendedora : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
        SqlDataAdapter adapt;
        bool novo;
        private void DisplayData()
        {

            SqlConnection cnx = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123");
            cnx.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select * from tb_cadastro_vendedora order by datacadastro desc", cnx);
            DataSet dst = new DataSet();
            adp.Fill(dst);
            dataGridView1.DataSource = dst;
            dataGridView1.DataBind();


            con.Close();
        }  
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        protected void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=britania_db;User ID=sa;Password=Marcus123";
            string dt_cadastro = System.DateTime.Now.ToString("dd/MM/yyyy");
            string sql = "INSERT INTO tb_cadastro_vendedora (nomecompleto,cpf,rg,endereco,bairro,cidade,telefonefixo,celular,empregofixo,nomeempresa,tempoempresa,contatoempresa,referenciacomercial1,referenciacomercial2,contas1,contas2,contas3,datacadastro,email,dt_aniversario)" + "VALUES ('" + TxtNomeCompleto.Text + "', '" + txtcpf.Text + "', '" + txtrg.Text + "', '" + txtendereco.Text + "', '" + txtbairro.Text + "', '" + txtcidade.Text + "', '" + txttelefonefixo.Text + "', '" + txtcelular.Text + "', '" + txtempregofixo.Text + "', '" + txtnomeEmpresa.Text + "', '" + txtnomeEmpresa.Text + "',  '" + txtcontatoempresa.Text + "', '" + txtreferencia1.Text + "', '" + txtreferencia2.Text + "', '" + txtultimas1.Text + "', '" + txtultimas2.Text + "', '" + txtultimas3.Text + "', '" + dt_cadastro + "', '" + txtemail.Text + "', '" + txtdtaniversario.Text + "')";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Response.Write("<script type='text/javascript'>alert('Cadastro Realizado com Sucesso');</script></script><script type='text/javascript'>window.location.href = 'CadastrarVendedora.aspx';</script>");
                DisplayData();

            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('Erro ao Cadastrar');</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }
}