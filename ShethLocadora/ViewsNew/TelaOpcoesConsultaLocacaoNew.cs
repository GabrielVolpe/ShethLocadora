using ShethLocadora.Controllers;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesConsultaLocacaoNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" C O N S U L T A R   L O C A Ç Õ E S", 80, 13, 0, 1);

            Locacao.AtualizaLocacoes();

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaOpcoesConsultaLocacao.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Listar todas");
            Console.WriteLine(" [2] - Listar ativas");
            Console.WriteLine(" [3] - Listar inativas");
            Console.WriteLine(" [4] - Listar regulares");
            Console.WriteLine(" [5] - Listar irregulares");
            Console.WriteLine(" [6] - Consultar ID");
            Console.WriteLine(" [7] - Consultar CPF");
            Console.WriteLine(" [9] - Menu Locações");
            Console.ResetColor();
        }
    }
}
