using ShethLocadora.Models.Enums;
using System;
using System.Text;

namespace ShethLocadora.Models
{
    sealed class Usuario : Pessoa
    {
        public Endereco Endereco { get; set; }
        public int Id { get; set; }
        public bool Status { get; set; }
        public int Permissao { get; set; }
        public string UsuarioAutenticacao { get; set; }
        public string SenhaAutenticacao { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, DateTime dataNascimento, EnumSexoPessoa sexo, string cpf, string email, string numeroCelular, int id, bool status, int permissao, Endereco endereco, string usuarioAutenticacao,
            string senhaAutenticacao) : base(nome, dataNascimento, sexo, cpf, email, numeroCelular)
        {
            Id = id;
            Status = status;
            Permissao = permissao;
            Endereco = endereco;
            UsuarioAutenticacao = usuarioAutenticacao;
            SenhaAutenticacao = senhaAutenticacao;
        }

        public override string ToString()
        {
            StringBuilder stringUsuario = new StringBuilder();

            string statusNominal;

            if (Status == true)
            {
                statusNominal = "ATIVO";
            }
            else
            {
                statusNominal = "INATIVO";
            }

            string permissaoNominal;

            if (Permissao == 1)
            {
                permissaoNominal = "ADMINISTRADOR";
            }
            else
            {
                permissaoNominal = "OPERADOR";
            }

            stringUsuario.AppendLine(" ================================================== D A D O S   P E S S O A I S");
            stringUsuario.AppendLine(" ID.....................: " + Id);
            stringUsuario.AppendLine(" Nome...................: " + Nome);
            stringUsuario.AppendLine(" Data de nascimento.....: " + DataNascimento.ToString("dd/MM/yyyy"));
            stringUsuario.AppendLine(" Sexo...................: " + Sexo);
            stringUsuario.AppendLine(" CPF....................: " + Cpf);
            stringUsuario.AppendLine(" E-mail.................: " + Email);
            stringUsuario.AppendLine(" Celular................: " + NumeroCelular);
            stringUsuario.AppendLine(" Status.................: " + statusNominal);
            stringUsuario.AppendLine(" Permissão..............: " + permissaoNominal);
            stringUsuario.AppendLine(" Usuário de autenticação: " + UsuarioAutenticacao);
            stringUsuario.AppendLine(" Senha de autenticação..: " + SenhaAutenticacao + "\n");
            stringUsuario.AppendLine(Endereco.ToString());

            return stringUsuario.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   Nome == usuario.Nome &&
                   DataNascimento == usuario.DataNascimento &&
                   Sexo == usuario.Sexo &&
                   Cpf == usuario.Cpf;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento, Sexo, Cpf);
        }
    }
}
