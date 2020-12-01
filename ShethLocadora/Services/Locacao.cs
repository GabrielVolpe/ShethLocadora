using ShethLocadora.Models;
using ShethLocadora.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShethLocadora.Services
{
    sealed class Locacao
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public Filme Filme { get; set; } = new Filme();
        public Cliente Cliente { get; set; } = new Cliente();
        public double ValorPrazo { get; set; }
        public DateTime DataOcorreuDevolucao { get; set; }
        public double ValorMulta { get; set; }
        public double TaxaJurosAtraso { get; set; }
        public double ValorJuros { get; set; }
        public double ValorFinal { get; set; }

        public Locacao()
        {

        }

        public Locacao(int id, Filme filme, Cliente cliente)
        {
            Id = id;
            Status = true;
            Situacao = true;
            DataLocacao = DateTime.Now;
            DataPrevistaDevolucao = DataLocacao.AddDays(filme.PeriodoDiasLocacao);
            Filme = filme;
            Cliente = cliente;
            ValorPrazo = filme.ValorLocacao;
            DataOcorreuDevolucao = DateTime.MinValue;
            ValorMulta = 0.00; // Ou 150,00
            TaxaJurosAtraso = 0.50; // % Ao dia
            ValorJuros = 0.00;
            ValorFinal = filme.ValorLocacao;
        }

        internal static void AtualizaLocacoes()
        {
            string cpfCliente = null;
            bool atrasoDevolucao = false;

            foreach (var item in BancoDados.Locacoes.ToArray())
            {
                DateTime diaAtual = new DateTime();

                diaAtual = DateTime.Now;
                double diasAtraso = diaAtual.Subtract(item.DataPrevistaDevolucao).TotalDays;

                if (diasAtraso > 0)
                {
                    cpfCliente = item.Cliente.Cpf;

                    atrasoDevolucao = true;

                    item.Situacao = false;

                    item.ValorJuros = ((item.Filme.ValorLocacao * item.TaxaJurosAtraso) * diasAtraso);

                    item.ValorFinal = item.Filme.ValorLocacao + item.ValorMulta + item.ValorJuros;
                }
                else
                {
                    item.ValorFinal = item.Filme.ValorLocacao + item.ValorMulta;
                }
            }

            foreach (var item in BancoDados.Clientes.ToArray())
            {
                if (item.Cpf == cpfCliente && atrasoDevolucao == true)
                {
                    item.Status = false;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringLocacao = new StringBuilder();

            string statusNominal;

            if (Status == true)
            {
                statusNominal = "ATIVA";
            }
            else
            {
                statusNominal = "INATIVA";
            }

            string situacaoNominal;

            if (Situacao == true)
            {
                situacaoNominal = "REGULAR";
            }
            else
            {
                situacaoNominal = "IRREGULAR";
            }

            stringLocacao.AppendLine(" ================================================== D A D O S   D A   L O C A Ç Ã O");
            stringLocacao.AppendLine(" ID............................: " + Id);
            stringLocacao.AppendLine(" Status........................: " + statusNominal);
            stringLocacao.AppendLine(" Situação......................: " + situacaoNominal);
            stringLocacao.AppendLine(" Data de locação...............: " + DataLocacao.ToString("dd/MM/yyyy"));
            stringLocacao.AppendLine(" Data prevista de devolução....: " + DataPrevistaDevolucao.ToString("dd/MM/yyyy"));
            stringLocacao.AppendLine(" Data de ocorrência devolução..: " + DataOcorreuDevolucao.ToString("dd/MM/yyyy"));

            stringLocacao.AppendLine("\n ID do filme...................: " + Filme.Id);
            stringLocacao.AppendLine(" Título do filme...............: " + Filme.Titulo);
            stringLocacao.AppendLine(" Categoria do filme............: " + Filme.Categoria);
            stringLocacao.AppendLine(" Valor da locação no prazo.....: R$" + Filme.ValorLocacao.ToString("F2"));

            stringLocacao.AppendLine("\n Nome do cliente...............: " + Cliente.Nome);
            stringLocacao.AppendLine(" Data de Nascimento do cliente.: " + Cliente.DataNascimento.ToString("dd/MM/yyyy"));
            stringLocacao.AppendLine(" CPF do cliente................: " + Cliente.Cpf);
            stringLocacao.AppendLine(" E-mail do cliente.............: " + Cliente.Email);
            stringLocacao.AppendLine(" Número de celular do cliente..: " + Cliente.NumeroCelular);


            return stringLocacao.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Locacao locacao &&
                   Status == locacao.Status &&
                   Situacao == locacao.Situacao &&
                   DataLocacao == locacao.DataLocacao &&
                   DataPrevistaDevolucao == locacao.DataPrevistaDevolucao &&
                   EqualityComparer<Filme>.Default.Equals(Filme, locacao.Filme) &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, locacao.Cliente) &&
                   ValorPrazo == locacao.ValorPrazo &&
                   DataOcorreuDevolucao == locacao.DataOcorreuDevolucao &&
                   ValorMulta == locacao.ValorMulta &&
                   TaxaJurosAtraso == locacao.TaxaJurosAtraso &&
                   ValorJuros == locacao.ValorJuros &&
                   ValorFinal == locacao.ValorFinal;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Status);
            hash.Add(Situacao);
            hash.Add(DataLocacao);
            hash.Add(DataPrevistaDevolucao);
            hash.Add(Filme);
            hash.Add(Cliente);
            hash.Add(ValorPrazo);
            hash.Add(DataOcorreuDevolucao);
            hash.Add(ValorMulta);
            hash.Add(TaxaJurosAtraso);
            hash.Add(ValorJuros);
            hash.Add(ValorFinal);
            return hash.ToHashCode();
        }
    }
}
