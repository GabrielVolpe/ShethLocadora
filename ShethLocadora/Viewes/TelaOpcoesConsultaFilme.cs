//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaOpcoesConsultaFilme
//    {
//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("C O N S U L T A R   F I L M E S");

//            ApresentaMenu();
//        }

//        private static void ApresentaMenu()
//        {
//            OpcoesMenu();

//            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

//            ControllerTelaOpcoesConsultaFilme.RecebeOpcaoMenu(opcaoInformada);
//        }

//        private static void OpcoesMenu()
//        {
//            Console.WriteLine("\n 1 - Listar todos");
//            Console.WriteLine(" 2 - Listar por título");
//            Console.WriteLine(" 3 - Listar por diretor");
//            Console.WriteLine(" 4 - Listar categoria");
//            Console.WriteLine(" 5 - Consultar ID");
//            Console.WriteLine(" 9 - Menu Filmes");
//        }
//    }
//}
