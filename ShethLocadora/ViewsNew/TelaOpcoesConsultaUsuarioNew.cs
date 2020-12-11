using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesConsultaUsuarioNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" C O N S U L T A R   U S U Á R I O S", 80, 10, 0, 1);

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaOpcoesConsultaUsuario.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Listar todos");
            Console.WriteLine(" [2] - Listar por Nome");
            Console.WriteLine(" [3] - Consultar ID");
            Console.WriteLine(" [4] - Consultar CPF");
            Console.WriteLine(" [9] - Menu Usuarios");
            Console.ResetColor();
        }
    }
}
