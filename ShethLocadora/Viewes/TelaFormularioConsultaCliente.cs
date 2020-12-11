//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioConsultaCliente
//    {
//        internal static void ListaTodos()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR TODOS OS CLIENTES");

//            Console.WriteLine();

//            ControllerCliente.ListaTodos();

//            FinalizaConsulta();
//        }

//        internal static void ConsultaId()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONTULAR CLIENTES POR ID");

//            int idInformado = UtilitariosGlobais.ConsultasInt("\n ID: ");

//            ControllerCliente.ConsultaId(idInformado);

//            FinalizaConsulta();
//        }

//        internal static void ConsultaCpf()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONSULTAR CLIENTES POR CPF");

//            string cpfInformado = UtilitariosGlobais.ConsultasString("\n CPF: ");

//            ControllerCliente.ConsultaCpf(cpfInformado);

//            FinalizaConsulta();
//        }

//        internal static void ListaNome()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR CLIENTES POR NOME");

//            string nomeInformado = UtilitariosGlobais.ConsultasString("\n Nome: ");

//            ControllerCliente.ListaNome(nomeInformado);

//            FinalizaConsulta();
//        }

//        private static void FinalizaConsulta()
//        {
//            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

//            TelaOpcoesConsultaClienteNew.ApresentaTela();
//        }
//    }
//}
