using ShethLocadora.Models.Enums;
using ShethLocadora.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShethLocadora.Models
{
    sealed class Cliente : Pessoa
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; } = new Endereco();
        public bool Status { get; set; }
        public List<Locacao> Locacoes { get; set; } = new List<Locacao>();

        public Cliente()
        {

        }

        public Cliente(string nome, DateTime dataNascimento, EnumSexoPessoa sexo, string cpf, string email, string numeroCelular, int id, Endereco endereco, bool status)
            : base(nome, dataNascimento, sexo, cpf, email, numeroCelular)
        {
            Id = id;
            Endereco = endereco;
            Status = status;
        }

        public override string ToString()
        {
            StringBuilder stringCliente = new StringBuilder();

            string statusNominal = null;

            if (Status == true)
            {
                statusNominal = "ATIVO";
            }
            else
            {
                statusNominal = "INATIVO";
            }

            stringCliente.AppendLine(" ================================================== D A D O S   P E S S O A I S");
            stringCliente.AppendLine(" ID: " + Id);
            stringCliente.AppendLine(" Nome.........................: " + Nome);
            stringCliente.AppendLine(" Data de nascimento...........: " + DataNascimento.ToString("dd/MM/yyyy"));
            stringCliente.AppendLine(" Sexo.........................: " + Sexo);
            stringCliente.AppendLine(" CPF..........................: " + Cpf);
            stringCliente.AppendLine(" E-mail.......................: " + Email);
            stringCliente.AppendLine(" Celular......................: " + NumeroCelular);
            stringCliente.AppendLine(" Status.......................: " + statusNominal);
            stringCliente.AppendLine(" Número de locãções realizadas: " + Locacoes.Count + "\n");
            stringCliente.AppendLine(Endereco.ToString());

            return stringCliente.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   Nome == cliente.Nome &&
                   DataNascimento == cliente.DataNascimento &&
                   Sexo == cliente.Sexo &&
                   Cpf == cliente.Cpf;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento, Sexo, Cpf);
        }
    }
}
