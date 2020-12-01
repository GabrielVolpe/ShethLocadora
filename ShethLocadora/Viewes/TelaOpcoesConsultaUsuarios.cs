using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaUsuarios
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("C O N S U L T A R   U S U Á R I O S");

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
            //Listagem
            Console.WriteLine("\n 1 - Listar todos");
            Console.WriteLine(" 2 - Listar por nome");

            //Consultas
            Console.WriteLine(" 3 - Consultar ID");
            Console.WriteLine(" 4 - Consultar CPF");

            Console.WriteLine(" 9 - Menu Úsuários");
        }
    }
}