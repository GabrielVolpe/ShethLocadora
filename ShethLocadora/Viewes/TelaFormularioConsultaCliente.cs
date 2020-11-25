using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaCliente
    {
        internal static void ListaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR TODOS OS CLIENTES");

            Console.WriteLine();

            ControllerCliente.ListaTodos();

            FinalConsulta();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR CLIENTES POR ID");

            int idInformado = UtilitariosGlobais.ConsultasInt("\n ID: ");

            ControllerCliente.ConsultaId(idInformado);

            FinalConsulta();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR CLIENTES POR CPF");

            string cpfInformado = UtilitariosGlobais.ConsultasString("\n CPF: ");

            ControllerCliente.ConsultaCpf(cpfInformado);

            FinalConsulta();
        }

        internal static void ConsultaNome()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR CLIENTES POR NOME");

            string nomeInformado = UtilitariosGlobais.ConsultasString("\n Nome: ");

            ControllerCliente.ConsultaNome(nomeInformado);

            FinalConsulta();
        }



        private static void FinalConsulta()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaCliente.ApresentaTela();
        }
    }
}
