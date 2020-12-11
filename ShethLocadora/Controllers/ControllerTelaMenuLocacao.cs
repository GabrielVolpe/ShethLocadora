using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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
                        TelaFormularioEfetuaLocacaoNew.ApresentaTela();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioDevolveLocacaoNew.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesConsultaLocacaoNew.ApresentaTela();
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

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida! ");

                        TelaMenuLocacaoNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
