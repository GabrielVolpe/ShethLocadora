using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuInicio
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
                        TelaMenuLocacaoNew.ApresentaTela();
                    }
                    break;
                case 2:
                    {
                        TelaMenuClienteNew.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaMenuFilmeNew.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        if (ControllerLogin.PermissaoUsuarioLogado == 1)
                        {
                            TelaMenuUsuarioNew.ApresentaTela();
                        }
                        else
                        {
                            Console.Clear();

                            UtilitariosGlobais.ApresentaMensagemErro(" Usuário sem permissão!");

                            TelaMenuInicioNew.ApresentaTela();
                        }
                    }
                    break;
                case 9:
                    {
                        UtilitariosGlobais.ApresentaMensagemSucesso("Usuário desconectado!");

                        TelaLoginNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida! ");

                        TelaMenuInicioNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
