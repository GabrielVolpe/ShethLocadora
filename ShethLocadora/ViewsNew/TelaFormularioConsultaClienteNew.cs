using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioConsultaClienteNew
    {
        internal static void ListaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR TODOS OS CLIENTES");

            ControllerCliente.ListaTodos();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaNome()
        {
            TelaComTitulo.GeraTela(" LISTAR CLIENTES POR NOME", 80, 4, 0, 1);

            string nomeInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [Nome]: ");
            nomeInformado = Console.ReadLine();
            Console.ResetColor();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR CLIENTES POR NOME");

            ControllerCliente.ListaNome(nomeInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ConsultaId()
        {
            TelaComTitulo.GeraTela(" CONSULTAR CLIENTE POR ID", 80, 4, 0, 1);

            int idInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [ID]: ");
            int.TryParse(Console.ReadLine(), out idInformado);
            Console.ResetColor();

            Console.WriteLine("\n");

            ControllerCliente.ConsultaId(idInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ConsultaCpf()
        {
            TelaComTitulo.GeraTela(" CONSULTAR CLIENTE POR CPF", 80, 4, 0, 1);

            string cpfInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [CPF]: ");
            cpfInformado = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("\n");

            ControllerCliente.ConsultaCpf(cpfInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        private static void ConfirmaFimVisualizacaoListagem()
        {
            int opcaoFimVisualizacao = TelaConfirmacaoBinaria.GeraTela(" Sair da visualização?", 81, 1);

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

            TelaOpcoesConsultaClienteNew.ApresentaTela();
        }
    }
}
