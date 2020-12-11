using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioDevolveLocacaoNew
    {
        private static int _idInformado = 0;

        internal static void ApresentaTela()
        {
            Locacao.AtualizaLocacoes();

            TelaComTitulo.GeraTela(" FORMULÁRIO DE DEVOLUÇÃO", 80, 32, 0, 1);

            RecebeIdLocacao();
        }

        private static void RecebeIdLocacao()
        {
            Console.SetCursorPosition(0, 3);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" [ID da locação]: ");
            int.TryParse(Console.ReadLine(), out _idInformado);
            Console.ResetColor();

            bool resultadoValidacaoId = ControllerLocacao.ValidaIdLocacao(_idInformado);

            Console.WriteLine();

            VerificaResultadoIdLocacao(resultadoValidacaoId);
        }

        private static void VerificaResultadoIdLocacao(bool resultadoValidacaoId)
        {
            if (resultadoValidacaoId == true)
            {
                foreach (var item in BancoDados.Locacoes)
                {
                    if (item.Id == _idInformado)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(item);
                        Console.ResetColor();

                        break;
                    }
                }

                ApresentaOpcoesEstadoDevolucao();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhuma locação ativa localizada!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
        }

        private static void ApresentaOpcoesEstadoDevolucao()
        {
            int opcaoConfirmacaoEstadoDevolucao = TelaConfirmacaoBinaria.GeraTela(" Filme em perfeitas condições?", 81, 1);

            VerificaOpcaoEstadoDevolucao(opcaoConfirmacaoEstadoDevolucao);
        }

        private static void VerificaOpcaoEstadoDevolucao(int opcaoConfirmacaoEstadoDevolucao)
        {
            if (opcaoConfirmacaoEstadoDevolucao == 1)
            {
                ExibeValoresAhPagar();
            }
            else if (opcaoConfirmacaoEstadoDevolucao == 2)
            {
                ApresentaOpcoesAplicacaoMulta();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaOpcoesEstadoDevolucao();
            }
        }

        private static void ApresentaOpcoesAplicacaoMulta()
        {
            int opcaoConfirmacaoAplicarMulta = TelaConfirmacaoBinaria.GeraTela(" ATENÇÃO! Aplicar multa? R$150,00?", 81, 1);

            VerificaOpcaoAplicacaoMulta(opcaoConfirmacaoAplicarMulta);
        }

        private static void VerificaOpcaoAplicacaoMulta(int opcaoConfirmacaoAplicarMulta)
        {
            if (opcaoConfirmacaoAplicarMulta == 1)
            {
                ControllerLocacao.AplicaMulta(_idInformado);
            }
            else if (opcaoConfirmacaoAplicarMulta == 2)
            {
                ExibeValoresAhPagar();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaOpcoesAplicacaoMulta();
            }
        }

        internal static void ExibeValoresAhPagar()
        {
            Console.SetCursorPosition(0, 23);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [Valores a pagar]");
            Console.WriteLine();

            UtilitariosGlobais.ApresentaResumoValores(_idInformado);
            Console.ResetColor();

            ApresentaConfirmacao();
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoDevolucao = TelaConfirmacaoBinaria.GeraTela(" Confirmar devolução", 81, 1);

            VerificaOpcaoConfirmacao(opcaoConfirmacaoDevolucao);
        }

        private static void VerificaOpcaoConfirmacao(int opcaoConfirmacaoDevolucao)
        {
            if (opcaoConfirmacaoDevolucao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiDevolucao(_idInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Devolução realizada com sucesso!");

                TelaMenuLocacaoNew.ApresentaTela();
            }
            else if (opcaoConfirmacaoDevolucao == 2)
            {
                Console.Clear();

                ControllerLocacao.RetiraMulta(_idInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Devolução cancelada!");

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
