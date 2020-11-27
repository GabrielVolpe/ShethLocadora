using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesAlteracaoFilme
    {
        internal static int IdInformado = 0;

        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE ALTERAÇÕES - FILMES");

            RecebeId();
        }

        private static void RecebeId()
        {
            Console.Write("\n Informe o ID do filme que deseja alterar: ");
            int.TryParse(Console.ReadLine(), out IdInformado);

            Console.WriteLine();

            LocalizaId(IdInformado);
        }

        private static void LocalizaId(int idInformado)
        {
            bool idLocalizado = false;

            foreach (var item in BancoDados.Filmes)
            {
                if (item.Id == IdInformado)
                {
                    idLocalizado = true;

                    Console.WriteLine(item);

                    break;
                }
            }

            VerificaResultadoLocalizacaoId(idLocalizado);
        }

        private static void VerificaResultadoLocalizacaoId(bool idLocalizado)
        {
            if (idLocalizado == true)
            {
                ApresentaMenu();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Nenhum filme localizado!");

                TelaMenuFilme.ApresentaTela();
            }
        }

        internal static void ApresentaMenu()
        {

            Console.WriteLine(" Opções de alteração:");

            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenu();

            ControllerTelaOpcoesAlteracaoFilme.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.WriteLine("\n 1 - Status");
            Console.WriteLine(" 2 - Título");
            Console.WriteLine(" 3 - Diretor");
            Console.WriteLine(" 4 - Categoria");
            Console.WriteLine(" 5 - Classificação indicativa");
            Console.WriteLine(" 6 - Valor de locação");
            Console.WriteLine(" 7 - Período de dias permitido para locação");
            Console.WriteLine(" 8 - Quantidade disponível");
            Console.WriteLine(" 9 - Menu Filmes");
        }
    }
}
