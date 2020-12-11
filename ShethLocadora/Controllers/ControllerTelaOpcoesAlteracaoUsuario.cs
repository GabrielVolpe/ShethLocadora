using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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
                        TelaFormularioAlteracaoUsuarioNew.RecebeNome();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeDataNascimento();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeSexo();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeCpf();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeEmail();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeNumeroCelular();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeUnidadeFederativa();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeCidade();
                    }
                    break;
                case 9:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeBairro();
                    }
                    break;
                case 10:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeLogradouro();
                    }
                    break;
                case 11:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeComplemento();
                    }
                    break;
                case 12:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeCep();
                    }
                    break;
                case 13:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeStatus();
                    }
                    break;
                case 14:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebePermissao();
                    }
                    break;
                case 15:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeUsuarioAutenticacao();
                    }
                    break;
                case 16:
                    {
                        TelaFormularioAlteracaoUsuarioNew.RecebeSenhaAutenticacao();
                    }
                    break;
                case 19:
                    {
                        Console.Clear();

                        TelaMenuUsuarioNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        Console.SetCursorPosition(0, 0);
                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesAlteracaoUsuarioNew.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
