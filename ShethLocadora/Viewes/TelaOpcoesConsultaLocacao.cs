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
            Console.WriteLine("\n 1 - Listar todas");
            Console.WriteLine(" 2 - Listar ativas");
            Console.WriteLine(" 3 - Listar inativas");
            Console.WriteLine(" 4 - Listar regulares");
            Console.WriteLine(" 5 - Listar irregulares");

            //Consultas
            Console.WriteLine(" 6 - Consultar ID");
            Console.WriteLine(" 7 - Consultar CPF");

            Console.WriteLine(" 9 - Menu Locações");
        }
    }
}
