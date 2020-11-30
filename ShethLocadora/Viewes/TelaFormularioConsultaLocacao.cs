using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaLocacao
    {
        internal static void ConsultaTodas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR TODAS AS LOCAÇÕES");

            Console.WriteLine();

            ControllerLocacao.ListaTodos();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR LOCAÇÕES POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerLocacao.ConsultaId(idInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR LOCAÇÕES POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine();

            Console.WriteLine();

            ControllerLocacao.ConsultaCpf(cpfInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaAtivas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES ATIVAS");

            Console.WriteLine();

            ControllerLocacao.ListaAtivas();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaInativas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES INATIVAS");

            Console.WriteLine();

            ControllerLocacao.ListaInativas();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaRegulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES REGULARES");

            Console.WriteLine();

            ControllerLocacao.ListaRegulares();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaIrregulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES IRREGULARES");

            Console.WriteLine();

            ControllerLocacao.ListaIrregulares();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }
    }
}
