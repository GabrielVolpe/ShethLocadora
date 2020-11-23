using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaFormularioCadastroCliente.IniciaFomrulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaCliente.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoCliente.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoCliente.ApresentaTela();
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

                        TelaMenuCliente.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
