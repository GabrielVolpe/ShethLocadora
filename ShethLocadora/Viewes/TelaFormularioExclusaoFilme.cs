using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioExclusaoFilme
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE EXCLUSÃO - FILMES");

            LocalizaFilmeExclusao();
        }

        public static int IdInformado;

        private static void LocalizaFilmeExclusao()
        {
            Console.Write("\n Informe o ID do filme que deseja excluir: ");
            int.TryParse(Console.ReadLine(), out IdInformado);

            bool resultadoValidacaoId = ValidaIdInformado.ValidaIdFilme(IdInformado);

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

                ApresentaConfirmacao();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Nenhum filme localizado!");

                TelaMenuFilme.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoExclusao = 0;

            Console.Write(" Deseja realmente prosseguir com a exclusão? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoExclusao);

            if (opcaoConfirmacaoExclusao == 1)
            {
                Console.Clear();

                ControllerFilme.ExcluiFilme(IdInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Exclusão realizada com sucesso!");

                TelaMenuFilme.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusao == 2)
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemSucesso("Exclusão cancelada!");

                TelaMenuFilme.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("\nOpção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
