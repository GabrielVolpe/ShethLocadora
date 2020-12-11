//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioConsultaUsuario
//    {
//        internal static void ListaTodos()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR TODOS OS USUÁRIOS");

//            Console.WriteLine();

//            ControllerUsuario.ListaTodos();

//            FinalizaConsulta();
//        }

//        internal static void ListaNome()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR USUÁRIOS POR NOME");

//            string nomeInformado = UtilitariosGlobais.ConsultasString("\n Nome: ");

//            ControllerUsuario.ListaNome(nomeInformado);

//            FinalizaConsulta();
//        }

//        internal static void ConsultaId()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONTULAR USUÁRIOS POR ID");

//            int idInformado = UtilitariosGlobais.ConsultasInt("\n ID: ");

//            ControllerUsuario.ConsultaId(idInformado);

//            FinalizaConsulta();
//        }

//        internal static void ConsultaCpf()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONSULTAR USUÁRIOS POR CPF");

//            string cpfInformado = UtilitariosGlobais.ConsultasString("\n CPF: ");

//            ControllerUsuario.ConsultaCpf(cpfInformado);

//            FinalizaConsulta();
//        }

//        private static void FinalizaConsulta()
//        {
//            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

//            TelaOpcoesConsultaUsuarioNew.ApresentaTela();
//        }
//    }
//}