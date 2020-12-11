using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaMenuInicioNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" S H E T H   L O C A D O R A", 80, 10, 0, 1);

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaMenuInicio.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Locações");
            Console.WriteLine(" [2] - Clientes");
            Console.WriteLine(" [3] - Filmes");
            Console.WriteLine(" [4] - Usuários");
            Console.WriteLine(" [9] - Sair");
            Console.ResetColor();
        }
    }
}
