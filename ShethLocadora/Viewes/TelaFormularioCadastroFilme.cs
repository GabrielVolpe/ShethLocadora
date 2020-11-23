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
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE CADASTRO - FILMES");

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

        private static void RecebeStatus()
        {
            Console.WriteLine("\n ================================================== Status");

            Console.WriteLine("\n 1 - Disonível");
            Console.WriteLine(" 2 - Indisonível");

            int opcaoStatusInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoStatusInformada);

            bool resultadoValidacaoStatus = ControllerFilme.ValidaStatus(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        private static void RecebeTitulo()
        {
            Console.WriteLine("\n ================================================== Título");

            string tituloInformado;

            Console.Write("\n ");

            tituloInformado = Console.ReadLine();

            bool resultadoValidacaoTitulo = ControllerFilme.ValidaTitulo(tituloInformado);

            if (resultadoValidacaoTitulo == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Título inválido!");

                RecebeTitulo();
            }
        }

        private static void RecebeDiretor()
        {
            Console.WriteLine("\n ================================================== Diretor (Nome completo): ");

            string diretorInformado;

            Console.Write("\n ");

            diretorInformado = Console.ReadLine();

            bool resultadoValidacaoDiretor = ControllerFilme.ValidaDiretor(diretorInformado);

            if (resultadoValidacaoDiretor == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Diretor inválido!");

                RecebeDiretor();
            }
        }

        private static void RecebeCategoria()
        {
            Console.WriteLine("\n ================================================== Categoria");

            int contadorCategoriaFilme = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.WriteLine($" {contadorCategoriaFilme} - {opcaoEnum}");

                contadorCategoriaFilme++;
            }

            int opcaoCategoriaInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoCategoriaInformada);

            bool resultadoValidacaoCategoria = ControllerFilme.ValidaCategoria(opcaoCategoriaInformada);

            if (resultadoValidacaoCategoria == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeCategoria();
            }
        }

        private static void RecebeClassificacaoIndicativa()
        {
            Console.WriteLine("\n ================================================== Classificação Indicativa");

            int contadorClassificacaoIndicativaFilme = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumClassificacaoIndicativaFilme)))
            {
                Console.WriteLine($" {contadorClassificacaoIndicativaFilme} - {opcaoEnum}");
                contadorClassificacaoIndicativaFilme++;
            }

            int opcaoClassificacaoIndicativaInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoClassificacaoIndicativaInformada);

            bool resultadoValidacaoClassificacaoIndicativa = ControllerFilme.ValidaClassificacaoIndicativa(opcaoClassificacaoIndicativaInformada);

            if (resultadoValidacaoClassificacaoIndicativa == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeClassificacaoIndicativa();
            }
        }

        private static void RecebeValorLocacao()
        {
            Console.WriteLine("\n ================================================== Valor de locação: ");

            double valorInformadoLocacao;

            Console.Write("\n ");

            double.TryParse(Console.ReadLine(), out valorInformadoLocacao);

            bool resultadoValidacaoValorLocacao = ControllerFilme.ValidaValorLocacao(valorInformadoLocacao);

            if (resultadoValidacaoValorLocacao == false)
            {

                FuncoesTexto.ApresentaMensagemErro("Valor inválido!");

                RecebeValorLocacao();
            }
        }

        private static void RecebePeriodoDiasLocacao()
        {
            Console.WriteLine("\n ================================================== Período de dias permitido para locação: ");

            int periodoDiasLocacaoInformado;

            Console.Write("\n ");

            int.TryParse(Console.ReadLine(), out periodoDiasLocacaoInformado);

            bool resultadoValidacaoPeriodoDiasLocacao = ControllerFilme.ValidaPeriodoDiasLocacao(periodoDiasLocacaoInformado);

            if (resultadoValidacaoPeriodoDiasLocacao == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Período inválido!");

                RecebePeriodoDiasLocacao();
            }
        }

        private static void RecebeQuantidadeDisponivel()
        {
            Console.WriteLine("\n ================================================== Quantidade disponível: ");

            int quantidadeDisponivelInformada;

            Console.Write("\n ");

            int.TryParse(Console.ReadLine(), out quantidadeDisponivelInformada);

            bool resultadoValidacaoQuantidadeDisponivel = ControllerFilme.ValidaQuantidadeDisponivel(quantidadeDisponivelInformada);

            if (resultadoValidacaoQuantidadeDisponivel == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Quantidade inválida!");

                RecebeQuantidadeDisponivel();
            }
        }

        private static void FinalizaCadastro()
        {
            Console.Clear();

            bool resultadoFinalizacaoCadastro = ControllerFilme.FinalizaCadastro();

            if (resultadoFinalizacaoCadastro == true)
            {
                FuncoesTexto.ApresentaMensagemSucesso("Cadastro realizado com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Cadastro cancelado! Filme já cadastrado.");

                TelaMenuFilme.ApresentaTela();
            }
        }
    }
}
