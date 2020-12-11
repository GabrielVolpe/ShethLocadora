//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioConsultaLocacao
//    {
//        internal static void ListaTodas()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR TODAS AS LOCAÇÕES");

//            Console.WriteLine();

//            ControllerLocacao.ListaTodos();

//            FinalizaConsulta();
//        }

//        internal static void ConsultaId()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONSULTAR LOCAÇÕES POR ID");

//            int idInformado;

//            Console.Write("\n Informe o ID: ");
//            int.TryParse(Console.ReadLine(), out idInformado);

//            Console.WriteLine();

//            ControllerLocacao.ConsultaId(idInformado);

//            FinalizaConsulta();
//        }

//        internal static void ConsultaCpf()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONSULTAR LOCAÇÕES POR CPF");

//            string cpfInformado;

//            Console.Write("\n Informe o CPF: ");
//            cpfInformado = Console.ReadLine();

//            Console.WriteLine();

//            ControllerLocacao.ConsultaCpf(cpfInformado);

//            FinalizaConsulta();
//        }

//        internal static void ListaAtivas()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR LOCAÇÕES ATIVAS");

//            Console.WriteLine();

//            ControllerLocacao.ListaAtivas();

//            FinalizaConsulta();
//        }

//        internal static void ListaInativas()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR LOCAÇÕES INATIVAS");

//            Console.WriteLine();

//            ControllerLocacao.ListaInativas();

//            FinalizaConsulta();
//        }

//        internal static void ListaRegulares()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR LOCAÇÕES REGULARES");

//            Console.WriteLine();

//            ControllerLocacao.ListaRegulares();

//            FinalizaConsulta();
//        }

//        internal static void ListaIrregulares()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR LOCAÇÕES IRREGULARES");

//            Console.WriteLine();

//            ControllerLocacao.ListaIrregulares();

//            FinalizaConsulta();
//        }

//        private static void FinalizaConsulta()
//        {

//            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

//            TelaOpcoesConsultaLocacaoNew.ApresentaTela();
//        }
//    }
//}
