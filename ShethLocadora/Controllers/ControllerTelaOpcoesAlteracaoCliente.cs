using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesAlteracaoCliente
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
                        TelaFormularioAlteracaoClienteNew.RecebeNome();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeDataNascimento();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeSexo();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeCpf();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeEmail();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeNumeroCelular();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeUnidadeFederativa();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeCidade();
                    }
                    break;
                case 9:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeBairro();
                    }
                    break;
                case 10:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeLogradouro();
                    }
                    break;
                case 11:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeComplemento();
                    }
                    break;
                case 12:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeCep();
                    }
                    break;
                case 13:
                    {
                        TelaFormularioAlteracaoClienteNew.RecebeStatus();
                    }
                    break;
                case 19:
                    {
                        Console.Clear();

                        TelaMenuClienteNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        Console.SetCursorPosition(0, 0);
                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesAlteracaoClienteNew.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
