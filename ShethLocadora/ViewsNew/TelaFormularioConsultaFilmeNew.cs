using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioConsultaFilmeNew
    {
        internal static void ListaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR TODOS OS FILMES");

            ControllerFilme.ListaTodos();

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaTitulo()
        {
            TelaComTitulo.GeraTela(" LISTAR FILMES POR TÍTULO", 80, 4, 0, 1);

            string tituloInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [Títúlo]: ");
            tituloInformado = Console.ReadLine();
            Console.ResetColor();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR FILMES POR TÍTULO");

            ControllerFilme.ListaTitulo(tituloInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaDiretor()
        {
            TelaComTitulo.GeraTela(" LISTAR FILMES POR DIRETOR", 80, 4, 0, 1);

            string diretorInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [Diretor]: ");
            diretorInformado = Console.ReadLine().ToUpper();
            Console.ResetColor();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR FILMES POR DIRETOR");

            ControllerFilme.ListaDiretor(diretorInformado);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ListaCategoria()
        {
            TelaComTitulo.GeraTela(" LISTAR FILMES POR CATEGORIA", 80, 21, 0, 1);

            int contadorCategoriaFilme = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.SetCursorPosition(1, contadorCategoriaFilme + 2);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"[{contadorCategoriaFilme}] - {opcaoEnum}");
                Console.ResetColor();

                contadorCategoriaFilme++;
            }

            int opcaoCategoriaInformada;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 19);
            Console.Write("\n [Opção]: ");
            int.TryParse(Console.ReadLine(), out opcaoCategoriaInformada);
            Console.ResetColor();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" LISTAR FILMES POR CATEGORIA");

            ControllerFilme.ListaCategoria(opcaoCategoriaInformada);

            ConfirmaFimVisualizacaoListagem();
        }

        internal static void ConsultaId()
        {
            TelaComTitulo.GeraTela(" COSULTAR FILMES POR ID", 80, 4, 0, 1);

            int idInformado;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [ID]: ");
            int.TryParse(Console.ReadLine(), out idInformado);
            Console.ResetColor();

            Console.WriteLine("\n");

            ControllerFilme.ConsultaId(idInformado);

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

            TelaOpcoesConsultaFilmeNew.ApresentaTela();
        }
    }
}
