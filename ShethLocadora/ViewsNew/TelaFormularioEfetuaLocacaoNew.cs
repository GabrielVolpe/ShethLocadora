using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioEfetuaLocacaoNew
    {
        private static int _idInformado = 0;

        private static string _cpfInformado = null;

        internal static void ApresentaTela()
        {
            Locacao.AtualizaLocacoes();

            TelaComTitulo.GeraTela(" FORMULÁRIO DE LOCAÇÃO", 80, 33, 0, 1);

            RecebeIdFilme();
        }

        private static void RecebeIdFilme()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write($" [ID do filme]: ");
            int.TryParse(Console.ReadLine(), out _idInformado);
            Console.ResetColor();

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
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(item);
                        Console.ResetColor();

                        break;
                    }
                }

                VerificaStatusFilme();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum filme localizado!");

                TelaMenuLocacaoNew.ApresentaTela();
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

                UtilitariosGlobais.ApresentaMensagemErro(" Filme Indisponível para locação!");

                TelaMenuLocacaoNew.ApresentaTela();
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

                UtilitariosGlobais.ApresentaMensagemErro(" Filme Indisponível para locação!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
        }

        private static void RecebeCpfCliente()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n [CPF do cliente]: ");
            _cpfInformado = Console.ReadLine();
            Console.ResetColor();

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
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(item);
                        Console.ResetColor();

                        break;
                    }
                }

                VerificaStatusCliente();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum cliente localizado para o CPF informado!");

                TelaMenuLocacaoNew.ApresentaTela();
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

                UtilitariosGlobais.ApresentaMensagemErro(" Cliente inativo!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoLocacao = TelaConfirmacaoBinaria.GeraTela(" Confirmar locação?", 81, 1);

            VerificaOpcaoConfirmacao(opcaoConfirmacaoLocacao);
        }

        private static void VerificaOpcaoConfirmacao(int opcaoConfirmacaoLocacao)
        {
            if (opcaoConfirmacaoLocacao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiLocacao(_idInformado, _cpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Locação realizada com sucesso!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
            else if (opcaoConfirmacaoLocacao == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso(" Locação cancelada!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
