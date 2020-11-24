using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaLocacao
    {
        internal static void ConsultaTodas()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR TODAS AS LOCAÇÕES");

            Console.WriteLine();

            ControllerLocacao.ConsultaTodas();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES POR ID");

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
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES POR CPF");

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
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES ATIVAS");

            Console.WriteLine();

            ControllerLocacao.ConsultaAtivas();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaInativas()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES INATIVAS");

            Console.WriteLine();

            ControllerLocacao.ConsultaInativas();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaRegulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES REGULARES");

            Console.WriteLine();

            ControllerLocacao.ConsultaRegulares();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaIrregulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR LOCAÇÕES IRREGULARES");

            Console.WriteLine();

            ControllerLocacao.ConsultaIrregulares();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }
    }
}
