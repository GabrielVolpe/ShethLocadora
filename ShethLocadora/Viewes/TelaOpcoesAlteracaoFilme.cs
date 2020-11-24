using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesAlteracaoFilme
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE ALTERAÇÕES - FILMES");

            LocalizaFilmeAlteracao();
        }

        internal static int IdInformado;

        private static void LocalizaFilmeAlteracao()
        {
            Console.Write("\n Informe o ID do filme que deseja alterar: ");
            int.TryParse(Console.ReadLine(), out IdInformado);

            bool resultadoValidacaoId = UtilitariosGlobais.ValidaIdFilme(IdInformado);

            Console.WriteLine();

            if (resultadoValidacaoId == true)
            {
                foreach (var item in BancoDados.Filmes)
                {
                    if (item.Id == IdInformado)
                    {
                        Console.WriteLine(item);
                    }
                }

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

            Console.WriteLine("\n 1 - Status");
            Console.WriteLine(" 2 - Título");
            Console.WriteLine(" 3 - Diretor");
            Console.WriteLine(" 4 - Categoria");
            Console.WriteLine(" 5 - Classificação indicativa");
            Console.WriteLine(" 6 - Valor de locação");
            Console.WriteLine(" 7 - Período de dias permitido para locação");
            Console.WriteLine(" 8 - Quantidade disponível");
            Console.WriteLine(" 9 - Menu Filmes");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            ControllerTelaOpcoesAlteracaoFilme.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
