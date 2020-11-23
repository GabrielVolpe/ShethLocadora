using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaUsuario
    {
        internal static void ConsultaTodos()
        {
            FuncoesTexto.ApresentaCabecalho("CONSULTAR TODOS OS USUÁRIOS");

            Console.WriteLine();
            ControllerUsuario.ConsultaTodos();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR USUÁRIOS POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerUsuario.ConsultaId(idInformado);

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaCpf()
        {
            FuncoesTexto.ApresentaCabecalho("CONSULTAR USUÁRIOS POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerUsuario.ConsultaCpf(cpfInformado);

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }

        internal static void ConsultaNome()
        {
            FuncoesTexto.ApresentaCabecalho("CONSULTAR USUÁRIOS POR NOME");

            string nomeInformado;

            Console.Write("\n Informe o nome: ");
            nomeInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerUsuario.ConsultaNome(nomeInformado);

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaUsuarios.ApresentaTela();
        }
    }
}
