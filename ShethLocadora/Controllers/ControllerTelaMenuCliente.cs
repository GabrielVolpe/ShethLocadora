using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuCliente
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
                        TelaFormularioCadastroClienteNew.IniciaFormulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaClienteNew.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoClienteNew.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoClienteNew.ApresentaTela();
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

                        TelaMenuClienteNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
