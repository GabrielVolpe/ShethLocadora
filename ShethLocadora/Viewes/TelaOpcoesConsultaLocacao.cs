using ShethLocadora.Controllers;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesConsultaLocacao
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("C O N S U L T A R   L O C A Ç Õ E S");

            Locacao.AtualizaLocacoes();

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaOpcoesConsultaLocacao.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            //Listagem
            Console.WriteLine("\n 1 - Todas");
            //Consultas
            Console.WriteLine(" 2 - Id");
            Console.WriteLine(" 3 - CPF");
            //Listagens
            Console.WriteLine(" 4 - Ativas");
            Console.WriteLine(" 5 - Inativas");
            Console.WriteLine(" 6 - Regulares");
            Console.WriteLine(" 7 - Irregulares");
            Console.WriteLine(" 9 - Menu Locações");
        }
    }
}
