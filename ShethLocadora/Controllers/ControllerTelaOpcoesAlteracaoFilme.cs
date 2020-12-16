using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesAlteracaoFilme
    {
        internal static void RecebeOpcaoMenu(int opcaoInformada)
        {
            ExecutaOpcaoMenu(opcaoInformada);
        }

        private static void ExecutaOpcaoMenu(int opcaoInformada)
        {
            switch (opcaoInformada)
            {
                case 1:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeStatus();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeTitulo();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeDiretor();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeCategoria();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeClassificacaoIndicativa();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeValorLocacao();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebePeriodoDiasLocacao();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoFilmeNew.RecebeQuantidadeDisponivel();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuFilmeNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        Console.SetCursorPosition(0, 0);
                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesAlteracaoFilmeNew.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
