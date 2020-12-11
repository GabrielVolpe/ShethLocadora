using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaMenuUsuarioNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" U S U Á R I O S", 80, 10, 0, 1);

            ApresentaMenu();
        }
        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaMenuUsuario.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 2);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n [1] - Cadastrar");
            Console.WriteLine(" [2] - Consultar");
            Console.WriteLine(" [3] - Alterar");
            Console.WriteLine(" [4] - Excluir");
            Console.WriteLine(" [9] - Início");
            Console.ResetColor();
        }
    }
}
