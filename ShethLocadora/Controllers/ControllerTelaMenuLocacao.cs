using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuLocacao
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
                        TelaFormularioEfetuaLocacao.ApresentaTela();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioDevolveLocacao.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesConsultaLocacao.ApresentaTela();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuInicio.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        FuncoesTexto.ApresentaMensagemErro("Opcão inválida! ");

                        TelaMenuLocacao.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
