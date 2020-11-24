using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioConsultaFilme
    {
        internal static void ConsultaTodos()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR TODOS OS FILMES");

            Console.WriteLine();
            ControllerFilme.ConsultaTodos();

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaFilme.ApresentaTela();
        }

        internal static void ConsultaId()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONTULAR FILMES POR ID");

            int idInformado;

            Console.Write("\n Informe o ID: ");
            int.TryParse(Console.ReadLine(), out idInformado);

            Console.WriteLine();

            ControllerFilme.ConsultaId(idInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaFilme.ApresentaTela();
        }

        internal static void ConsultaTitulo()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR FILMES POR TÍTULO");

            string tituloInformado;

            Console.Write("\n Informe o título: ");
            tituloInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerFilme.ConsultaTitulo(tituloInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaFilme.ApresentaTela();
        }

        internal static void ConsultaDiretor()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR FILMES POR DIRETOR");

            string diretorInformado;

            Console.Write("\n Informe o diretor: ");
            diretorInformado = Console.ReadLine().ToUpper();

            Console.WriteLine();

            ControllerFilme.ConsultaDiretor(diretorInformado);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaFilme.ApresentaTela();
        }

        internal static void ConsultaCategoria()
        {
            UtilitariosGlobais.ApresentaCabecalho("CONSULTAR FILMES POR CATEGORIA");

            int contadorCategoriaFilme = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.WriteLine($" {contadorCategoriaFilme} - {opcaoEnum}");
                contadorCategoriaFilme++;
            }

            int opcaoCategoriaInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoCategoriaInformada);

            Console.WriteLine();

            ControllerFilme.ConsultaCategoria(opcaoCategoriaInformada);

            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

            TelaOpcoesConsultaFilme.ApresentaTela();
        }
    }
}
