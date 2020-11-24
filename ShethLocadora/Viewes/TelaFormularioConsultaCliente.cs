using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaCliente
    {
        internal static void ConsultaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR TODOS OS CLIENTES");

            Console.WriteLine();
            ControllerCliente.ConsultaTodos();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaCliente.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR CLIENTES POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerCliente.ConsultaId(idInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaCliente.ApresentaTela();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR CLIENTES POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerCliente.ConsultaCpf(cpfInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaCliente.ApresentaTela();
        }

        internal static void ConsultaNome()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR CLIENTES POR NOME");

            string nomeInformado;

            Console.Write("\n Informe o nome: ");
            nomeInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerCliente.ConsultaNome(nomeInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaCliente.ApresentaTela();
        }
    }
}
