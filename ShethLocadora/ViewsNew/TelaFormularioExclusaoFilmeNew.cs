using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioExclusaoFilmeNew
    {
        internal static int IdInformado = 0;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" FORMULÁRTIO DE EXCLUSÃO - FILMES", 80, 4, 0, 1);

            RecebeId();
        }

        private static void RecebeId()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [ID]: ");
            int.TryParse(Console.ReadLine(), out IdInformado);
            Console.ResetColor();

            Console.WriteLine("\n");

            LocalizaId(IdInformado);
        }

        private static void LocalizaId(int idInformado)
        {
            bool IdLocalizado = false;

            foreach (var item in BancoDados.Filmes)
            {
                if (item.Id == idInformado)
                {
                    IdLocalizado = true;

                    break;
                }
            }

            if (IdLocalizado == true)
            {
                ControllerFilme.ConsultaId(idInformado);
            }

            VerificaResultadoLocalizacaoId(IdLocalizado);
        }

        private static void VerificaResultadoLocalizacaoId(bool IdLocalizado)
        {
            if (IdLocalizado == true)
            {
                ApresentaConfirmacaoFilme();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum filme localizado!");

                TelaMenuFilmeNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacaoFilme()
        {
            int opcaoConfirmacaoIdLocalizado = TelaConfirmacaoBinaria.GeraTela(" Confirma filme localizado?", 81, 1);

            VerificaOpcaoConfirmacaoFilme(opcaoConfirmacaoIdLocalizado);
        }

        private static void VerificaOpcaoConfirmacaoFilme(int opcaoConfirmacaoCliente)
        {
            if (opcaoConfirmacaoCliente == 1)
            {
                RecebeConfirmacaoExclusao();
            }
            else if (opcaoConfirmacaoCliente == 2)
            {
                Console.Clear();

                TelaMenuFilmeNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaConfirmacaoFilme();
            }
        }

        private static void RecebeConfirmacaoExclusao()
        {
            int opcaoConfirmacaoExclusao = TelaConfirmacaoBinaria.GeraTela(" Prosseguir com a exclusão?", 81, 1);

            VerificaConfirmacaoExclusao(opcaoConfirmacaoExclusao);
        }

        private static void VerificaConfirmacaoExclusao(int opcaoConfirmacaoExclusaoInformada)
        {
            if (opcaoConfirmacaoExclusaoInformada == 1)
            {
                Console.Clear();

                ControllerFilme.ExcluiFilme(IdInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão realizada com sucesso!");

                TelaMenuFilmeNew.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusaoInformada == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão cancelada!");

                TelaMenuFilmeNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeConfirmacaoExclusao();
            }
        }
    }
}
