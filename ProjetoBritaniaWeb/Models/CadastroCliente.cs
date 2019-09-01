using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoBritaniaWeb.Models
{
    public class CadastroCliente
    {
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefonefixo { get; set; }
        public string celular { get; set; }
        public string empregofixo { get; set; }
        public string nomeempresa { get; set; }
        public string tempoempresa { get; set; }
        public string contatoempresa { get; set; }
        public string referenciacomercial1 { get; set; }
        public string referenciacomercial2 { get; set; }
        public string contas1 { get; set; }
        public string contas2 { get; set; }
        public string contas3 { get; set; }
        public DateTime datacadastro { get; set; }
        public string email { get; set; }
        public DateTime dt_aniversario { get; set; }

        public List<CadastroCliente> lista = new List<CadastroCliente>();
    }
}