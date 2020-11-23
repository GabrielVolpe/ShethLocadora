﻿using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioAlteracaoFilme
    {
        internal static void RecebeStatus()
        {
            Console.WriteLine("\n ================================================== Status");

            Console.WriteLine(" 1 - Disonível");
            Console.WriteLine(" 2 - Indisonível");

            int opcaoStatusInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoStatusInformada);

            bool resultadoValidacaoStatus = ControllerFilme.ValidaStatus(opcaoStatusInformada);

            if (resultadoValidacaoStatus == true)
            {
                Console.Clear();

                ControllerFilme.AlteraStatus(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        internal static void RecebeTitulo()
        {
            Console.WriteLine("\n ================================================== Título");

            string tituloInformado;

            Console.Write("\n ");

            tituloInformado = Console.ReadLine();

            bool resultadoValidacaoTitulo = ControllerFilme.ValidaTitulo(tituloInformado);

            if (resultadoValidacaoTitulo == true)
            {
                Console.Clear();

                ControllerFilme.AlteraTitutlo(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Título inválido!");

                RecebeTitulo();
            }
        }
        internal static void RecebeDiretor()
        {
            Console.WriteLine("\n ================================================== Diretor: ");

            string diretorInformado;

            Console.Write("\n ");

            diretorInformado = Console.ReadLine();

            bool resultadoValidacaoDiretor = ControllerFilme.ValidaDiretor(diretorInformado);

            if (resultadoValidacaoDiretor == true)
            {
                Console.Clear();

                ControllerFilme.AlteraDiretor(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Diretor inválido!");

                RecebeDiretor();
            }
        }

        internal static void RecebeCategoria()
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

            if (resultadoValidacaoCategoria == true)
            {
                Console.Clear();

                ControllerFilme.AlteraCategoria(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeCategoria();
            }
        }

        internal static void RecebeClassificacaoIndicativa()
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

            if (resultadoValidacaoClassificacaoIndicativa == true)
            {
                Console.Clear();

                ControllerFilme.AlteraClassificacaoIndicativa(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeClassificacaoIndicativa();
            }
        }

        internal static void RecebeValorLocacao()
        {
            Console.WriteLine("\n ================================================== Valor de locação: ");

            double valorInformadoLocacao;

            Console.Write("\n ");

            double.TryParse(Console.ReadLine(), out valorInformadoLocacao);

            bool resultadoValidacaoValorLocacao = ControllerFilme.ValidaValorLocacao(valorInformadoLocacao);

            if (resultadoValidacaoValorLocacao == true)
            {
                Console.Clear();

                ControllerFilme.AlteraValorLocacao(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Valor inválido!");

                RecebeValorLocacao();
            }
        }

        internal static void RecebePeriodoDiasLocacao()
        {
            Console.WriteLine("\n ================================================== Período de dias permitido para locação: ");

            int periodoDiasLocacaoInformado;

            Console.Write("\n ");

            int.TryParse(Console.ReadLine(), out periodoDiasLocacaoInformado);

            bool resultadoValidacaoPeriodoDiasLocacao = ControllerFilme.ValidaPeriodoDiasLocacao(periodoDiasLocacaoInformado);

            if (resultadoValidacaoPeriodoDiasLocacao == true)
            {
                Console.Clear();

                ControllerFilme.AlteraPeriodoDiasLocacao(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Período inválido!");

                RecebePeriodoDiasLocacao();
            }
        }

        internal static void RecebeQuantidadeDisponivel()
        {
            Console.WriteLine("\n ================================================== Quantidade disponível: ");

            int quantidadeDisponivelInformada;

            Console.Write("\n ");

            int.TryParse(Console.ReadLine(), out quantidadeDisponivelInformada);

            bool resultadoValidacaoQuantidadeDisponivel = ControllerFilme.ValidaQuantidadeDisponivel(quantidadeDisponivelInformada);

            if (resultadoValidacaoQuantidadeDisponivel == true)
            {
                Console.Clear();

                ControllerFilme.AlteraQuantidadeDisponivel(TelaOpcoesAlteracaoFilme.IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Quantidade inválido!");

                RecebeQuantidadeDisponivel();
            }
        }
    }
}