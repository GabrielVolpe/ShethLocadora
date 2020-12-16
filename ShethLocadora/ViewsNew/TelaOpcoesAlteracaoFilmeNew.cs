using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesAlteracaoFilmeNew
    {
        internal static int IdInformado = 0;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" LOCALIZAR FILME", 80, 4, 0, 1);

            RecebeId();
        }

        private static void RecebeId()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [ID]: ");
            int.TryParse(Console.ReadLine(), out IdInformado);
            Console.ResetColor();

            Console.WriteLine("\n");

            LocalizaId(IdInformado);
        }

        private static void LocalizaId(int idInformado)
        {
            bool idLocalizado = false;

            foreach (var item in BancoDados.Filmes)
            {
                if (item.Id == IdInformado)
                {
                    idLocalizado = true;

                    break;
                }
            }

            if (idLocalizado == true)
            {
                ControllerFilme.ConsultaId(idInformado);
            }

            VerificaResultadoLocalizacaoId(idLocalizado);
        }

        private static void VerificaResultadoLocalizacaoId(bool idLocalizado)
        {
            if (idLocalizado == true)
            {
                ApresentaConfirmacaoFilme();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum filme localizado!");

                TelaMenuFilmeNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacaoFilme()
        {
            int opcaoConfirmacaoLocalizacaoId = TelaConfirmacaoBinaria.GeraTela(" Confirma filme localizado?", 81, 1);

            VerificaOpcaoConfirmacaoFilme(opcaoConfirmacaoLocalizacaoId);
        }

        private static void VerificaOpcaoConfirmacaoFilme(int opcaoConfirmacaoFilme)
        {
            if (opcaoConfirmacaoFilme == 1)
            {
                Console.Clear();

                ApresentaMenu();
            }
            else if (opcaoConfirmacaoFilme == 2)
            {
                Console.Clear();

                TelaMenuFilmeNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaConfirmacaoFilme();
            }
        }

        internal static void ApresentaMenu()
        {
            TelaComTitulo.GeraTela(" Opções de alteração", 80, 14, 0, 1);

            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenu();

            ControllerTelaOpcoesAlteracaoFilme.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" 1 - Status");
            Console.WriteLine(" 2 - Título");
            Console.WriteLine(" 3 - Diretor");
            Console.WriteLine(" 4 - Categoria");
            Console.WriteLine(" 5 - Classificação indicativa");
            Console.WriteLine(" 6 - Valor de locação");
            Console.WriteLine(" 7 - Período de dias permitido para locação");
            Console.WriteLine(" 8 - Quantidade disponível");
            Console.WriteLine(" 9 - Menu Filmes");
            Console.ResetColor();
        }
    }
}
