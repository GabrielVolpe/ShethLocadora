using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaMenuLocacao
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("L O C A Ç Õ E S");

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
            Console.WriteLine("\n 1 - Locar");
            Console.WriteLine(" 2 - Devolver");
            //Console.WriteLine(" 3 - Listar");
            Console.WriteLine(" 3 - Consultar");
            Console.WriteLine(" 9 - Início");
        }
    }
}
