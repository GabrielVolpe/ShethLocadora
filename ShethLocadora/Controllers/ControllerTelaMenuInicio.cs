using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaMenuLocacao.ApresentaTela();
                    }
                    break;
                case 2:
                    {
                        TelaMenuCliente.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaMenuFilme.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        if (ControllerLogin.PermissaoUsuarioLogado == 1)
                        {
                            TelaMenuUsuario.ApresentaTela();
                        }
                        else
                        {
                            Console.Clear();

                            UtilitariosGlobais.ApresentaMensagemErro("Usuário sem permissão!");

                            TelaMenuInicio.ApresentaTela();
                        }
                    }
                    break;
                case 9:
                    {
                        UtilitariosGlobais.ApresentaMensagemSucesso("Usuário desconectado!");

                        TelaLogin.ApresentaTela();
                    }
                    break;
                default:
                    {
                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaMenuInicio.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
