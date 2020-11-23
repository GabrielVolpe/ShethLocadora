using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    class TelaFormularioDevolveLocacao
    {
        private static int _idInformado;

        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE DEVOLUÇÃO - LOCAÇÕES");

            Locacao.AtualizaLocacoes();

            LocalizaLocacao();
        }

        private static void LocalizaLocacao()
        {
            Console.Write("\n Informe o ID da locação que deseja devolver: ");
            int.TryParse(Console.ReadLine(), out _idInformado);

            bool resultadoValidacaoId = ControllerLocacao.ValidaIdLocacao(_idInformado);

            Console.WriteLine();

            if (resultadoValidacaoId == true)
            {
                foreach (var item in BancoDados.Locacoes)
                {
                    if (item.Id == _idInformado)
                    {
                        Console.Write(item);
                    }
                }

                Console.WriteLine();

                ConfirmaEstadoDevolucao();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Nenhuma locação ativa localizada!");

                TelaMenuLocacao.ApresentaTela();
            }
        }

        private static void ConfirmaEstadoDevolucao()
        {
            int opcaoConfirmacaoEstadoDevolucao;

            Console.Write($" O filme está em perfeitas condições de uso? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoEstadoDevolucao);

            Console.WriteLine();

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

                ConfirmaAplicacaoMulta();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                ConfirmaEstadoDevolucao();
            }
        }

        private static void ConfirmaAplicacaoMulta()
        {
            int opcaoConfirmacaoAplicarMulta;

            Console.Write(" Deseja aplicar a multa? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoAplicarMulta);

            Console.WriteLine();

            if (opcaoConfirmacaoAplicarMulta == 1)
            {
                ControllerLocacao.AplicaMulta(_idInformado);
            }
            else if (opcaoConfirmacaoAplicarMulta == 2)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(" Aplicação de multa cancelada!");
                Console.ResetColor();

                ExibeValoresAhPagar();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                ConfirmaAplicacaoMulta();
            }
        }

        internal static void ExibeValoresAhPagar()
        {
            foreach (var item in BancoDados.Locacoes)
            {
                if (item.Id == _idInformado)
                {
                    item.DataOcorreuDevolucao = DateTime.Now;

                    Console.WriteLine(" ================================================== V A L O R   A   P A G A R");
                    Console.WriteLine($" Valor de locação no prazo: {item.ValorPrazo.ToString("F2")}");
                    Console.WriteLine($" Dias em atraso...........: {DateTime.Now.Day - item.DataPrevistaDevolucao.Day}");
                    Console.WriteLine($" Taxa de juros......... ..: {item.TaxaJurosAtraso}%" + " a.d");
                    Console.WriteLine($" Valor da multa...........: R$ {item.ValorMulta.ToString("F2")}");
                    Console.WriteLine($" Valor dos juros..........: R$ {item.ValorJuros.ToString("F2")}");
                    Console.WriteLine($"\n TOTAL..................: R$ {item.ValorFinal.ToString("F2")}");
                }
            }

            ApresentaConfirmacao();
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoDevolucao;

            Console.Write($"\n Deseja confirmar a devolução (1 = SIM / 2 = NÃO)? ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoDevolucao);

            Console.WriteLine();

            if (opcaoConfirmacaoDevolucao == 1)
            {
                Console.Clear();

                ControllerLocacao.ConcluiDevolucao(_idInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Devolução realizada com sucesso!");

                TelaMenuLocacao.ApresentaTela();
            }
            else if (opcaoConfirmacaoDevolucao == 2)
            {
                Console.Clear();
                ControllerLocacao.RetiraMulta(_idInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Devolução cancelada!");

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
