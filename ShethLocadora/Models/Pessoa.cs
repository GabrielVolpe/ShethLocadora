using ShethLocadora.Models.Enums;
using System;

namespace ShethLocadora.Models
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } = new DateTime();
        public EnumSexoPessoa Sexo { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string NumeroCelular { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNascimento, EnumSexoPessoa sexo, string cpf, string email, string numeroCelular)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Cpf = cpf;
            Email = email;
            NumeroCelular = numeroCelular;
        }
    }
}
