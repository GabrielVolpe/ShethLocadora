using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuUsuario
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
                        TelaFormularioCadastroUsuario.IniciaFomrulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaUsuarios.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoUsuario.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoUsuario.ApresentaTela();
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

                        TelaMenuUsuario.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
