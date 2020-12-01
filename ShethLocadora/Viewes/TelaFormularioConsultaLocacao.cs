using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaLocacao
    {
        internal static void ListaTodas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR TODAS AS LOCAÇÕES");

            Console.WriteLine();

            ControllerLocacao.ListaTodos();

            FinalizaConsulta();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR LOCAÇÕES POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerLocacao.ConsultaId(idInformado);

            FinalizaConsulta();
        }

        internal static void ConsultaCpf()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR LOCAÇÕES POR CPF");

            string cpfInformado;

            Console.Write("\n Informe o CPF: ");
            cpfInformado = Console.ReadLine();

            Console.WriteLine();

            ControllerLocacao.ConsultaCpf(cpfInformado);

            FinalizaConsulta();
        }

        internal static void ListaAtivas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES ATIVAS");

            Console.WriteLine();

            ControllerLocacao.ListaAtivas();

            FinalizaConsulta();
        }

        internal static void ListaInativas()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES INATIVAS");

            Console.WriteLine();

            ControllerLocacao.ListaInativas();

            FinalizaConsulta();
        }

        internal static void ListaRegulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES REGULARES");

            Console.WriteLine();

            ControllerLocacao.ListaRegulares();

            FinalizaConsulta();
        }

        internal static void ListaIrregulares()
        {
            UtilitariosGlobais.ApresentaCabecalho("LISTAR LOCAÇÕES IRREGULARES");

            Console.WriteLine();

            ControllerLocacao.ListaIrregulares();

            FinalizaConsulta();
        }

        private static void FinalizaConsulta()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaLocacao.ApresentaTela();
        }
    }
}
