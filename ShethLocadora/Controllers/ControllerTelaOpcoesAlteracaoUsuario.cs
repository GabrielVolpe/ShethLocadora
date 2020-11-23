using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesAlteracaoUsuario
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
                        TelaFormularioAlteracaoUsuario.RecebeNome();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeDataNascimento();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeSexo();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeCpf();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeEmail();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeNumeroCelular();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeUnidadeFederativa();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeCidade();
                    }
                    break;
                case 9:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeBairro();
                    }
                    break;
                case 10:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeLogradouro();
                    }
                    break;
                case 11:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeComplemento();
                    }
                    break;
                case 12:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeCep();
                    }
                    break;
                case 13:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeStatus();
                    }
                    break;
                case 14:
                    {
                        TelaFormularioAlteracaoUsuario.RecebePermissao();
                    }
                    break;
                case 15:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeUsuarioAutenticacao();
                    }
                    break;
                case 16:
                    {
                        TelaFormularioAlteracaoUsuario.RecebeSenhaAutenticacao();
                    }
                    break;
                case 19:
                    {
                        Console.Clear();

                        TelaMenuUsuario.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        FuncoesTexto.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesAlteracaoUsuario.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
