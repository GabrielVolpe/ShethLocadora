using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuFilme
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
                        TelaFormularioCadastroFilmeNew.IniciaFomrulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaFilmeNew.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoFilmeNew.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoFilmeNew.ApresentaTela();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuInicioNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaMenuInicioNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
