using ShethLocadora.Models.Enums;
using System;
using System.Text;

namespace ShethLocadora.Models
{
    sealed class Filme
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public EnumCategoriaFilme Categoria { get; set; }
        public EnumClassificacaoIndicativaFilme ClassificacaoIndicativa { get; set; }
        public double ValorLocacao { get; set; }
        public int PeriodoDiasLocacao { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public Filme()
        {

        }

        public Filme(int id, bool status, string titulo, string diretor, EnumCategoriaFilme categoria, EnumClassificacaoIndicativaFilme classificacaoIndicativa, double valorLocacao, int periodoDiasLocacao, int quantidadeDisponivel)
        {
            Id = id;
            Status = status;
            Titulo = titulo;
            Diretor = diretor;
            Categoria = categoria;
            ClassificacaoIndicativa = classificacaoIndicativa;
            ValorLocacao = valorLocacao;
            PeriodoDiasLocacao = periodoDiasLocacao;
            QuantidadeDisponivel = quantidadeDisponivel;
        }

        public override string ToString()
        {
            StringBuilder stringFilme = new StringBuilder();

            string statusNominal;

            if (Status == true)
            {
                statusNominal = "DISPONÍVEL";
            }
            else
            {
                statusNominal = "INDISPONÍVEL";
            }

            stringFilme.AppendLine(" ID: ........................... " + Id);
            stringFilme.AppendLine(" Status: ....................... " + statusNominal);
            stringFilme.AppendLine(" Título: ....................... " + Titulo);
            stringFilme.AppendLine(" Diretor: ...................... " + Diretor);
            stringFilme.AppendLine(" Categoria: .................... " + Categoria);
            stringFilme.AppendLine(" Classificação indicativa: ..... " + ClassificacaoIndicativa + " ANOS");
            stringFilme.AppendLine(" Valor de locação: ............. R$" + ValorLocacao.ToString("F2"));
            stringFilme.AppendLine(" Período permitido para locação: " + PeriodoDiasLocacao + " DIAS");
            stringFilme.AppendLine(" Quantidade disponível: ........ " + QuantidadeDisponivel);

            return stringFilme.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Filme filme &&
                   Titulo == filme.Titulo &&
                   Diretor == filme.Diretor &&
                   Categoria == filme.Categoria;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Titulo, Diretor, Categoria);
        }
    }
}
