using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioCadastroFilme
    {
        internal static void IniciaFomrulario()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE CADASTRO - FILMES");

            Console.WriteLine("\n Informe os dados abaixo para efetuar o cadastro: ");

            RecebeStatus();
            RecebeTitulo();
            RecebeDiretor();
            RecebeCategoria();
            RecebeClassificacaoIndicativa();
            RecebeValorLocacao();
            RecebePeriodoDiasLocacao();
            RecebeQuantidadeDisponivel();
            FinalizaCadastro();
        }

        internal static Tuple<bool, int> RecebeStatus()
        {
            Console.WriteLine("\n ================================================== Status");

            Console.WriteLine(" 1 - Disponível");
            Console.WriteLine(" 2 - Indisponível");

            int opcaoStatusInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n Opção: ");

            bool resultadoValidacaoStatus = ControllerFilme.ValidaStatus(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }

            return new Tuple<bool, int>(resultadoValidacaoStatus, opcaoStatusInformada);
        }

        internal static Tuple<bool, string> RecebeTitulo()
        {
            string tituloInformado = UtilitariosGlobais.RecebeDadoCadastroString(" ================================================== Título");

            bool resultadoValidacaoTitulo = ControllerFilme.ValidaTitulo(tituloInformado);

            if (resultadoValidacaoTitulo == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Título inválido!");

                RecebeTitulo();
            }

            return new Tuple<bool, string>(resultadoValidacaoTitulo, tituloInformado);
        }

        internal static Tuple<bool, string> RecebeDiretor()
        {
            string diretorInformado = UtilitariosGlobais.RecebeDadoCadastroString(" ================================================== Diretor");

            bool resultadoValidacaoDiretor = ControllerFilme.ValidaDiretor(diretorInformado);

            if (resultadoValidacaoDiretor == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Diretor inválido!");

                RecebeDiretor();
            }

            return new Tuple<bool, string>(resultadoValidacaoDiretor, diretorInformado);
        }

        internal static Tuple<bool, int> RecebeCategoria()
        {
            Console.WriteLine(" ================================================== Categoria");

            int contadorCategoriaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.WriteLine($" {contadorCategoriaFilme} - {opcaoEnum}");

                contadorCategoriaFilme++;
            }

            int opcaoCategoriaInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n Opção: ");

            bool resultadoValidacaoCategoria = ControllerFilme.ValidaCategoria(opcaoCategoriaInformada);

            if (resultadoValidacaoCategoria == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeCategoria();
            }

            return new Tuple<bool, int>(resultadoValidacaoCategoria, opcaoCategoriaInformada);
        }

        internal static Tuple<bool, int> RecebeClassificacaoIndicativa()
        {
            Console.WriteLine(" ================================================== Classificação Indicativa");

            int contadorClassificacaoIndicativaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumClassificacaoIndicativaFilme)))
            {
                Console.WriteLine($" {contadorClassificacaoIndicativaFilme} - {opcaoEnum}");
                contadorClassificacaoIndicativaFilme++;
            }

            int opcaoClassificacaoIndicativaInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n Opção:");

            bool resultadoValidacaoClassificacaoIndicativa = ControllerFilme.ValidaClassificacaoIndicativa(opcaoClassificacaoIndicativaInformada);

            if (resultadoValidacaoClassificacaoIndicativa == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeClassificacaoIndicativa();
            }

            return new Tuple<bool, int>(resultadoValidacaoClassificacaoIndicativa, opcaoClassificacaoIndicativaInformada);
        }

        internal static Tuple<bool, double> RecebeValorLocacao()
        {
            Console.WriteLine(" ================================================== Valor de locação: ");

            double valorInformadoLocacao;

            Console.Write(" ");
            double.TryParse(Console.ReadLine(), out valorInformadoLocacao);

            bool resultadoValidacaoValorLocacao = ControllerFilme.ValidaValorLocacao(valorInformadoLocacao);

            if (resultadoValidacaoValorLocacao == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Valor inválido!");

                RecebeValorLocacao();
            }

            return new Tuple<bool, double>(resultadoValidacaoValorLocacao, valorInformadoLocacao);
        }

        internal static Tuple<bool, int> RecebePeriodoDiasLocacao()
        {
            Console.WriteLine(" ================================================== Período de dias permitido para locação: ");

            int periodoDiasLocacaoInformado = UtilitariosGlobais.RecebeDadoCadastroIntEnum(" ");

            bool resultadoValidacaoPeriodoDiasLocacao = ControllerFilme.ValidaPeriodoDiasLocacao(periodoDiasLocacaoInformado);

            if (resultadoValidacaoPeriodoDiasLocacao == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Período inválido!");

                RecebePeriodoDiasLocacao();
            }

            return new Tuple<bool, int>(resultadoValidacaoPeriodoDiasLocacao, periodoDiasLocacaoInformado);
        }

        internal static Tuple<bool, int> RecebeQuantidadeDisponivel()
        {
            Console.WriteLine(" ================================================== Quantidade disponível: ");

            int quantidadeDisponivelInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum(" ");

            bool resultadoValidacaoQuantidadeDisponivel = ControllerFilme.ValidaQuantidadeDisponivel(quantidadeDisponivelInformada);

            if (resultadoValidacaoQuantidadeDisponivel == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Quantidade inválida!");

                RecebeQuantidadeDisponivel();
            }

            return new Tuple<bool, int>(resultadoValidacaoQuantidadeDisponivel, quantidadeDisponivelInformada);
        }

        private static void FinalizaCadastro()
        {
            Console.Clear();

            bool resultadoFinalizacaoCadastro = ControllerFilme.FinalizaCadastro();

            if (resultadoFinalizacaoCadastro == true)
            {
                UtilitariosGlobais.ApresentaMensagemSucesso("Cadastro realizado com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cadastro cancelado! Filme já cadastrado.");

                TelaMenuFilme.ApresentaTela();
            }
        }
    }
}
