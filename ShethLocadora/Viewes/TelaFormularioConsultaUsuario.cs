using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaUsuario
    {
        internal static void ConsultaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR TODOS OS USUÁRIOS");

            Console.WriteLine();
            ControllerUsuario.ConsultaTodos();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR USUÁRIOS POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerUsuario.ConsultaId(idInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR USUÁRIOS POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerUsuario.ConsultaCpf(cpfInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaNome()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR USUÁRIOS POR NOME");

            string nomeInformado;

            Console.Write("\n Informe o nome: ");
            nomeInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerUsuario.ConsultaNome(nomeInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }
    }
}
