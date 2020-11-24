using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaFormularioAlteracaoFilme.RecebeStatus();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoFilme.RecebeTitulo();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoFilme.RecebeDiretor();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoFilme.RecebeCategoria();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoFilme.RecebeClassificacaoIndicativa();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoFilme.RecebeValorLocacao();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoFilme.RecebePeriodoDiasLocacao();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoFilme.RecebeQuantidadeDisponivel();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuFilme.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesAlteracaoFilme.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
