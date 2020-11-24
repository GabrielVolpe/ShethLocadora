using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioEfetuaLocacao
    {
        private static int _idInformado = 0;

        private static string _cpfInformado = null;

        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE LOCAÇÃO - LOCAÇÕES");

            Locacao.AtualizaLocacoes();

            RecebeIdFilme();
        }

        private static void RecebeIdFilme()
        {
            Console.Write("\n Informe o ID do filme que deseja locar: ");
            int.TryParse(Console.ReadLine(), out _idInformado);

            bool resultadoValidacaoId = UtilitariosGlobais.ValidaIdFilme(_idInformado);

            Console.WriteLine();

            VerificaResultadoIdFilme(resultadoValidacaoId);
        }

        private static void VerificaResultadoIdFilme(bool resultadoValidacaoId)
        {
            if (resultadoValidacaoId == true)
            {
                foreach (var item in BancoDados.Filmes)
                {
                    if (item.Id == _idInformado)
                    {
                        Console.Write(item);

                        break;
                    }
                }

                VerificaStatusFilme();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro("Nenhum filme localizado!");

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

                UtilitariosGlobais.ApresentaMensagemErro("Filme Indisponível para locação!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void VerificaQuantidadeDisponivelFilme()
        {
            int quantidadeDisponivelFilme = ControllerLocacao.VerificaQuantidadeDisponivelFilme(_idInformado);

            if (quantidadeDisponivelFilme > 0)
            {
                RecebeCpfCliente();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro("Filme Indisponível para locação!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void RecebeCpfCliente()
        {
            Console.Write("\n Informe o CPF do cliente que deseja vincular a locação: ");
            _cpfInformado = Console.ReadLine();

            bool resultadoValidacaoCpf = UtilitariosGlobais.ValidaCpfCliente(_cpfInformado);

            Console.WriteLine();

            VerificaResultadoCpfCliente(resultadoValidacaoCpf);
        }

        private static void VerificaResultadoCpfCliente(bool resultadoValidacaoCpf)
        {
            if (resultadoValidacaoCpf == true)
            {
                foreach (var item in BancoDados.Clientes)
                {
                    if (item.Cpf == _cpfInformado)
                    {
                        Console.WriteLine(item);

                        break;
                    }
                }

                VerificaStatusCliente();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro("Nenhum cliente localizado para o CPF informado!");

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

                UtilitariosGlobais.ApresentaMensagemErro("Cliente inativo!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoLocacao = 0;

            Console.Write($" Deseja confirmar a locação (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoLocacao);

            Console.WriteLine();

            VerificaOpcaoConfirmacao(opcaoConfirmacaoLocacao);
        }

        private static void VerificaOpcaoConfirmacao(int opcaoConfirmacaoLocacao)
        {
            if (opcaoConfirmacaoLocacao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiLocacao(_idInformado, _cpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Locação realizada com sucesso!");

                TelaMenuLocacao.ApresentaTela();
            }
            else if (opcaoConfirmacaoLocacao == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso("Locação cancelada!");

                TelaMenuLocacao.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
