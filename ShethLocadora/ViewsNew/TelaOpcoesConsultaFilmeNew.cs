using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesConsultaFilmeNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" C O N S U L T A R   F I L M E S", 80, 11, 0, 1);

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaOpcoesConsultaFilme.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Listar todos");
            Console.WriteLine(" [2] - Listar por título");
            Console.WriteLine(" [3] - Listar por diretor");
            Console.WriteLine(" [4] - Listar categoria");
            Console.WriteLine(" [5] - Consultar ID");
            Console.WriteLine(" [9] - Menu Filmes");
            Console.ResetColor();
        }
    }
}
