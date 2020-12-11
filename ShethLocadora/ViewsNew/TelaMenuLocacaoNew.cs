using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaMenuLocacaoNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" L O C A Ç Õ E S", 80, 9, 0, 1);

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaMenuLocacao.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Locar");
            Console.WriteLine(" [2] - Devolver");
            Console.WriteLine(" [3] - Consultar");
            Console.WriteLine(" [9] - Início");
            Console.ResetColor();
        }
    }
}
