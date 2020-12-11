using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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
                        TelaFormularioCadastroUsuarioNew.IniciaFomrulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaUsuarioNew.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoUsuarioNew.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoUsuarioNew.ApresentaTela();
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

                        TelaMenuUsuarioNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
