using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaMenuFilme
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("F I L M E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            Console.WriteLine("\n 1 - Cadastrar");
            Console.WriteLine(" 2 - Consultar");
            Console.WriteLine(" 3 - Alterar");
            Console.WriteLine(" 4 - Excluir");
            Console.WriteLine(" 9 - Início");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.Clear();

            ControllerTelaMenuFilme.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
