using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaMenuLocacao
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("L O C A Ç Õ E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            Console.WriteLine("\n 1 - Locar");
            Console.WriteLine(" 2 - Devolver");
            Console.WriteLine(" 3 - Consultar");
            Console.WriteLine(" 9 - Início");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.Clear();

            ControllerTelaMenuLocacao.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
