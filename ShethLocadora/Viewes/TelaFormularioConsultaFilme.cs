//using ShethLocadora.Controllers;
//using ShethLocadora.Models.Enums;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioConsultaFilme
//    {
//        internal static void ListaTodos()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR TODOS OS FILMES");

//            Console.WriteLine();

//            ControllerFilme.ListaTodos();

//            FinalizaConsulta();
//        }

//        internal static void ConsultaId()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("CONSULTAR FILMES POR ID");

//            int idInformado;

//            Console.Write("\n Informe o ID: ");
//            int.TryParse(Console.ReadLine(), out idInformado);

//            Console.WriteLine();

//            ControllerFilme.ConsultaId(idInformado);

//            FinalizaConsulta();
//        }

//        internal static void ListaTitulo()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR FILMES POR TÍTULO");

//            string tituloInformado;

//            Console.Write("\n Informe o título: ");
//            tituloInformado = Console.ReadLine().ToUpper();

//            Console.WriteLine();

//            ControllerFilme.ListaTitulo(tituloInformado);

//            FinalizaConsulta();
//        }

//        internal static void ListaDiretor()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR FILMES POR DIRETOR");

//            string diretorInformado;

//            Console.Write("\n Informe o diretor: ");
//            diretorInformado = Console.ReadLine().ToUpper();

//            Console.WriteLine();

//            ControllerFilme.ListaDiretor(diretorInformado);

//            FinalizaConsulta();
//        }

//        internal static void ListaCategoria()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("LISTAR FILMES POR CATEGORIA");

//            int contadorCategoriaFilme = 1;

//            Console.WriteLine();

//            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
//            {
//                Console.WriteLine($" {contadorCategoriaFilme} - {opcaoEnum}");
//                contadorCategoriaFilme++;
//            }

//            int opcaoCategoriaInformada;

//            Console.Write("\n Opção: ");
//            int.TryParse(Console.ReadLine(), out opcaoCategoriaInformada);

//            Console.WriteLine();

//            ControllerFilme.ListaCategoria(opcaoCategoriaInformada);

//            FinalizaConsulta();
//        }

//        private static void FinalizaConsulta()
//        {
//            UtilitariosGlobais.ApresentaMensagemSucesso("Consulta finalizada!");

//            TelaOpcoesConsultaFilmeNew.ApresentaTela();
//        }
//    }
//}
