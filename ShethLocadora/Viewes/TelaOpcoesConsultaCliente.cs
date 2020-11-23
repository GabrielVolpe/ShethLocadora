using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaCliente
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("C O N S U L T A R   C L I E N T E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            Console.WriteLine("\n 1 - Todos");
            Console.WriteLine(" 2 - Id");
            Console.WriteLine(" 3 - CPF");
            Console.WriteLine(" 4 - Nome");
            Console.WriteLine(" 9 - Menu Úsuários");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.Clear();

            ControllerTelaOpcoesConsultaCliente.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
