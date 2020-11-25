using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioDevolveLocacao
    {
        private static int _idInformado = 0;

        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE DEVOLUÇÃO - LOCAÇÕES");

            Locacao.AtualizaLocacoes();

            RecebeIdLocacao();
        }

        private static void RecebeIdLocacao()
        {
            Console.Write("\n Informe o ID da locação que deseja devolver: ");
            int.TryParse(Console.ReadLine(), out _idInformado);

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
                        Console.Write(item);

                        break;
                    }
                }

                Console.WriteLine();

                ApresentaOpcoesEstadoDevolucao();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro("Nenhuma locação ativa localizada!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void ApresentaOpcoesEstadoDevolucao()
        {
            int opcaoConfirmacaoEstadoDevolucao = 0;

            Console.Write($" O filme está em perfeitas condições de uso? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoEstadoDevolucao);

            Console.WriteLine();

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
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" ATENÇÃO! Devido ao estado de devolução do filme, uma multa de R$150,00 será acrescida ao valor da locação.\n");
                Console.ResetColor();

                ApresentaOpcoesAplicacaoMulta();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                ApresentaOpcoesEstadoDevolucao();
            }
        }

        private static void ApresentaOpcoesAplicacaoMulta()
        {
            int opcaoConfirmacaoAplicarMulta = 0;

            Console.Write(" Deseja aplicar a multa? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoAplicarMulta);

            Console.WriteLine();

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
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" Aplicação de multa cancelada!\n");
                Console.ResetColor();

                ExibeValoresAhPagar();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                ApresentaOpcoesAplicacaoMulta();
            }
        }

        internal static void ExibeValoresAhPagar()
        {
            Console.WriteLine(" ================================================== V A L O R   A   P A G A R");

            UtilitariosGlobais.ApresentaResumoValores(_idInformado);

            ApresentaConfirmacao();
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoDevolucao = 0;

            Console.Write($" Deseja confirmar a devolução (1 = SIM / 2 = NÃO)? ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoDevolucao);

            Console.WriteLine();

            VerificaOpcaoConfirmacao(opcaoConfirmacaoDevolucao);
        }

        private static void VerificaOpcaoConfirmacao(int opcaoConfirmacaoDevolucao)
        {
            if (opcaoConfirmacaoDevolucao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiDevolucao(_idInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Devolução realizada com sucesso!");

                TelaMenuLocacao.ApresentaTela();
            }
            else if (opcaoConfirmacaoDevolucao == 2)
            {
                Console.Clear();
                ControllerLocacao.RetiraMulta(_idInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Devolução cancelada!");

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
