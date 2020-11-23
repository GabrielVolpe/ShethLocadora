using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaFilme
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("C O N S U L T A R   F I L M E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            Console.WriteLine("\n 1 - Todos");
            Console.WriteLine(" 2 - Id");
            Console.WriteLine(" 3 - Título");
            Console.WriteLine(" 4 - Diretor");
            Console.WriteLine(" 5 - Categoria");
            Console.WriteLine(" 9 - Menu Filmes");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.Clear();

            ControllerTelaOpcoesConsultaFilme.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
