using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaCliente
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("C O N S U L T A R   C L I E N T E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaOpcoesConsultaCliente.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            //Listagem
            Console.WriteLine("\n 1 - Listar todos");
            Console.WriteLine(" 2 - Listar por Nome");

            //Consulta
            Console.WriteLine(" 3 - Consultar ID");
            Console.WriteLine(" 4 - Consultar CPF");

            Console.WriteLine(" 9 - Menu Clientes");
        }
    }
}
