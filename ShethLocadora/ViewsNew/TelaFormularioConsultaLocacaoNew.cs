using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioConsultaLocacaoNew
    {
        internal static void ListaTodas()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR TODAS AS LOCAÇÕES");

            ControllerLocacao.ListaTodos();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaAtivas()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR LOCAÇÕES ATIVAS");

            ControllerLocacao.ListaAtivas();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaInativas()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR LOCAÇÕES INATIVAS");

            ControllerLocacao.ListaInativas();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaRegulares()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR LOCAÇÕES REGULARES");

            ControllerLocacao.ListaRegulares();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaIrregulares()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR LOCAÇÕES IRREGULARES");

            ControllerLocacao.ListaIrregulares();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ConsultaId()
        {
            TelaComTitulo.GeraTela(" CONSULTAR LOCAÇÃO POR ID", 80, 4, 0, 1);

            int idInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [ID do filme]: ");
            int.TryParse(Console.ReadLine(), out idInformado);
            Console.ResetColor();

            Console.WriteLine("\n");

            ControllerLocacao.ConsultaId(idInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ConsultaCpf()
        {
            TelaComTitulo.GeraTela(" CONSULTAR LOCAÇÕES POR CPF", 80, 4, 0, 1);

            string cpfInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [CPF do cliente]: ");
            cpfInformado = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("\n");

            ControllerLocacao.ConsultaCpf(cpfInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        private static void ConfirmaFimVisualizacaoListagem()
        {
            int opcaoFimVisualizacao = 0;
            opcaoFimVisualizacao = TelaConfirmacaoBinaria.GeraTela(" Sair da visualização?", 81, 1);

            if (opcaoFimVisualizacao == 1)
            {
                Console.Clear();

                FinalizaConsulta();
            }
            else if (opcaoFimVisualizacao == 2)
            {
                ConfirmaFimVisualizacaoListagem();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ConfirmaFimVisualizacaoListagem();
            }
        }

        private static void FinalizaConsulta()
        {

            UtilitariosGlobais.ApresentaMensagemSucesso(" Consulta finalizada!");

            TelaOpcoesConsultaLocacaoNew.ApresentaTela();
        }
    }
}
