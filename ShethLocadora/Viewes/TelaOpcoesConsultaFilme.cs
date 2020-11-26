using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaFilme
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("C O N S U L T A R   F I L M E S");

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
            //Listagem
            Console.WriteLine("\n 1 - Todos");
            //Consultas
            Console.WriteLine(" 2 - Id");
            Console.WriteLine(" 3 - Título");
            Console.WriteLine(" 4 - Diretor");
            //Listagem
            Console.WriteLine(" 5 - Categoria");
            Console.WriteLine(" 9 - Menu Filmes");
        }
    }
}
