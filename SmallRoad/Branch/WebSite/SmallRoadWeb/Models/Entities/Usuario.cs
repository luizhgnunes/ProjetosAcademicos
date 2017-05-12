using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class Usuario
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public char TipoUsuario { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public char Ddd { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        //MUN_ID
        public DateTime DataDeCadastro { get; set; }
        public DateTime DataDeAtualizacao { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public String IpCadastro { get; set; }
        //public String Uniqid { get; set; }
        public DateTime DataConfirmacao { get; set; }
        public string Confirmacao { get; set; }
        public char Status { get; set; }
        


    }
} 