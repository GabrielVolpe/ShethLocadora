//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaMenuFilme
//    {
//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("F I L M E S");

//            ApresentaMenu();
//        }

//        private static void ApresentaMenu()
//        {
//            OpcoesMenu();

//            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

//            ControllerTelaMenuFilme.RecebeOpcaoMenu(opcaoInformada);
//        }

//        private static void OpcoesMenu()
//        {
//            Console.WriteLine("\n 1 - Cadastrar");
//            Console.WriteLine(" 2 - Consultar");
//            Console.WriteLine(" 3 - Alterar");
//            Console.WriteLine(" 4 - Excluir");
//            Console.WriteLine(" 9 - Início");
//        }
//    }
//}
