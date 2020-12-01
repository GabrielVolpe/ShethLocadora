using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaUsuario
    {
        internal static void ListaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR TODOS OS USUÁRIOS");

            Console.WriteLine();

            ControllerUsuario.ListaTodos();

            FinalizaConsulta();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR USUÁRIOS POR ID");

            int idInformado = UtilitariosGlobais.ConsultasInt("\n ID: ");

            ControllerUsuario.ConsultaId(idInformado);

            FinalizaConsulta();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR USUÁRIOS POR CPF");

            string cpfInformado = UtilitariosGlobais.ConsultasString("\n CPF: ");

            ControllerUsuario.ConsultaCpf(cpfInformado);

            FinalizaConsulta();
        }

        internal static void ListaNome()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR USUÁRIOS POR NOME");

            string nomeInformado = UtilitariosGlobais.ConsultasString("\n Nome: ");

            ControllerUsuario.ListaNome(nomeInformado);

            FinalizaConsulta();
        }

        private static void FinalizaConsulta()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }
    }
}
