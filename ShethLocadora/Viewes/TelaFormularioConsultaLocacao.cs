using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaLocacao
    {
        internal static void ConsultaTodas()
        {
            FuncoesTexto.ApresentaCabecalho("CONSULTAR TODAS AS LOCAÇÕES");

            Console.WriteLine();

            ControllerLocacao.ConsultaTodas();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerLocacao.ConsultaId(idInformado);

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaCpf()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine();

            Console.WriteLine();

            ControllerLocacao.ConsultaCpf(cpfInformado);

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaAtivas()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES ATIVAS");

            Console.WriteLine();

            ControllerLocacao.ConsultaAtivas();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaInativas()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES INATIVAS");

            Console.WriteLine();

            ControllerLocacao.ConsultaInativas();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaRegulares()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES REGULARES");

            Console.WriteLine();

            ControllerLocacao.ConsultaRegulares();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }

        internal static void ConsultaIrregulares()
        {
            FuncoesTexto.ApresentaCabecalho("CONTULAR LOCAÇÕES IRREGULARES");

            Console.WriteLine();

            ControllerLocacao.ConsultaIrregulares();

            FuncoesTexto.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }
    }
}
