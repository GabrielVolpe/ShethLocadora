using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioEfetuaLocacao
    {
        private static int _idInformado;

        private static string _cpfInformado;

        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE LOCAÇÃO - LOCAÇÕES");

            Locacao.AtualizaLocacoes();

            LocalizaFilme();
        }

        private static void LocalizaFilme()
        {
            Console.Write("\n Informe o ID do filme que deseja locar: ");
            int.TryParse(Console.ReadLine(), out _idInformado);

            bool resultadoValidacaoId = ValidaIdInformado.ValidaIdFilme(_idInformado);

            Console.WriteLine();

            if (resultadoValidacaoId == true)
            {
                foreach (var item in BancoDados.Filmes)
                {
                    if (item.Id == _idInformado)
                    {
                        Console.Write(item);
                    }
                }

                VerificaStatusFilme();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Nenhum filme localizado!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void VerificaStatusFilme()
        {
            bool resultadoVerificacaoStatusFilme = ControllerLocacao.VerificaStatusFilme(_idInformado);

            if (resultadoVerificacaoStatusFilme == true)
            {
                VerificaQuantidadeDisponivelFilme();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Filme Indisponível para locação!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void VerificaQuantidadeDisponivelFilme()
        {
            int quantidadeDisponivelFilme = ControllerLocacao.VerificaQuantidadeDisponivelFilme(_idInformado);

            if (quantidadeDisponivelFilme > 0)
            {
                LocalizaCliente();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Filme Indisponível para locação!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void LocalizaCliente()
        {
            Console.Write("\n Informe o CPF do cliente que deseja vincular a locação: ");
            _cpfInformado = Console.ReadLine();

            bool resultadoValidacaoCpf = ValidaCpfInformado.ValidaCpfCliente(_cpfInformado);

            Console.WriteLine();

            if (resultadoValidacaoCpf == true)
            {
                foreach (var item in BancoDados.Clientes)
                {
                    if (item.Cpf == _cpfInformado)
                    {
                        Console.WriteLine(item);
                    }
                }

                VerificaStatusCliente();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Nenhum cliente localizado para o CPF informado!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void VerificaStatusCliente()
        {
            bool resultadoVerificacaoStatusCliente = ControllerLocacao.VerificaStatusCliente(_cpfInformado);

            if (resultadoVerificacaoStatusCliente == true)
            {
                ApresentaConfirmacao();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Cliente inativo!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoLocacao;

            Console.Write($" Deseja confirmar a locação (1 = SIM / 2 = NÃO)? ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoLocacao);

            Console.WriteLine();

            if (opcaoConfirmacaoLocacao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiLocacao(_idInformado, _cpfInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Locação realizada com sucesso!");

                TelaMenuLocacao.ApresentaTela();
            }
            else if (opcaoConfirmacaoLocacao == 2)
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemSucesso("Locação cancelada!");

                TelaMenuLocacao.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
