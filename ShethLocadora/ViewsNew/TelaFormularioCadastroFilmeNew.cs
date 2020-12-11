using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioCadastroFilmeNew
    {
        internal static void IniciaFomrulario()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" FORMULÁRIO DE CADASTRO - FILMES");

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
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Status]:");
            Console.ResetColor();

            Console.WriteLine(" [1] - Ativo");
            Console.WriteLine(" [2] - Inativo");

            int opcaoStatusInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]: ");

            bool resultadoValidacaoStatus = ControllerFilme.ValidaStatus(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeStatus();
            }

            return new Tuple<bool, int>(resultadoValidacaoStatus, opcaoStatusInformada);
        }

        internal static Tuple<bool, string> RecebeTitulo()
        {
            Console.WriteLine();

            string tituloInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Título]:");

            bool resultadoValidacaoTitulo = ControllerFilme.ValidaTitulo(tituloInformado);

            if (resultadoValidacaoTitulo == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Título inválido!");

                RecebeTitulo();
            }

            return new Tuple<bool, string>(resultadoValidacaoTitulo, tituloInformado);
        }

        internal static Tuple<bool, string> RecebeDiretor()
        {
            Console.WriteLine();

            string diretorInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Diretor]:");

            bool resultadoValidacaoDiretor = ControllerFilme.ValidaDiretor(diretorInformado);

            if (resultadoValidacaoDiretor == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Diretor inválido!");

                RecebeDiretor();
            }

            return new Tuple<bool, string>(resultadoValidacaoDiretor, diretorInformado);
        }

        internal static Tuple<bool, int> RecebeCategoria()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Categoria]:");
            Console.ResetColor();

            int contadorCategoriaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.WriteLine($" [{contadorCategoriaFilme}] - {opcaoEnum}");

                contadorCategoriaFilme++;
            }

            int opcaoCategoriaInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]: ");

            bool resultadoValidacaoCategoria = ControllerFilme.ValidaCategoria(opcaoCategoriaInformada);

            if (resultadoValidacaoCategoria == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeCategoria();
            }

            return new Tuple<bool, int>(resultadoValidacaoCategoria, opcaoCategoriaInformada);
        }

        internal static Tuple<bool, int> RecebeClassificacaoIndicativa()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Classificação Indicativa]:");
            Console.ResetColor();

            int contadorClassificacaoIndicativaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumClassificacaoIndicativaFilme)))
            {
                Console.WriteLine($" [{contadorClassificacaoIndicativaFilme}] - {opcaoEnum}");
                contadorClassificacaoIndicativaFilme++;
            }

            int opcaoClassificacaoIndicativaInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]: ");

            bool resultadoValidacaoClassificacaoIndicativa = ControllerFilme.ValidaClassificacaoIndicativa(opcaoClassificacaoIndicativaInformada);

            if (resultadoValidacaoClassificacaoIndicativa == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeClassificacaoIndicativa();
            }

            return new Tuple<bool, int>(resultadoValidacaoClassificacaoIndicativa, opcaoClassificacaoIndicativaInformada);
        }

        internal static Tuple<bool, double> RecebeValorLocacao()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Valor de locação]:");
            Console.ResetColor();

            Console.Write(" ");
            double.TryParse(Console.ReadLine(), out double valorInformadoLocacao);

            bool resultadoValidacaoValorLocacao = ControllerFilme.ValidaValorLocacao(valorInformadoLocacao);

            if (resultadoValidacaoValorLocacao == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Valor inválido!");

                RecebeValorLocacao();
            }

            return new Tuple<bool, double>(resultadoValidacaoValorLocacao, valorInformadoLocacao);
        }

        internal static Tuple<bool, int> RecebePeriodoDiasLocacao()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Período de dias permitido para locação]:");
            Console.ResetColor();

            int periodoDiasLocacaoInformado = UtilitariosGlobais.RecebeDadoCadastroIntEnum(" ");

            bool resultadoValidacaoPeriodoDiasLocacao = ControllerFilme.ValidaPeriodoDiasLocacao(periodoDiasLocacaoInformado);

            if (resultadoValidacaoPeriodoDiasLocacao == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Período inválido!");

                RecebePeriodoDiasLocacao();
            }

            return new Tuple<bool, int>(resultadoValidacaoPeriodoDiasLocacao, periodoDiasLocacaoInformado);
        }

        internal static Tuple<bool, int> RecebeQuantidadeDisponivel()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Quantidade disponível]:");
            Console.ResetColor();

            int quantidadeDisponivelInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum(" ");

            bool resultadoValidacaoQuantidadeDisponivel = ControllerFilme.ValidaQuantidadeDisponivel(quantidadeDisponivelInformada);

            if (resultadoValidacaoQuantidadeDisponivel == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Quantidade inválida!");

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
                UtilitariosGlobais.ApresentaMensagemSucesso(" Cadastro realizado com sucesso!");

                TelaMenuFilmeNew.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cadastro cancelado! Filme já cadastrado.");

                TelaMenuFilmeNew.ApresentaTela();
            }
        }
    }
}
