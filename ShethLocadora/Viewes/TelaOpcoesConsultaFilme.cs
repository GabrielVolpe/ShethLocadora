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
            Console.WriteLine("\n 1 - Listar todos");
            //Consultas
            Console.WriteLine(" 2 - Consultar ID");
            Console.WriteLine(" 3 - Consultar Título");
            Console.WriteLine(" 4 - Consultar Diretor");
            //Listagem
            Console.WriteLine(" 5 - Listar categoria");
            Console.WriteLine(" 9 - Menu Filmes");
        }
    }
}
