using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaFormularioAlteracaoCliente.RecebeNome();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioAlteracaoCliente.RecebeDataNascimento();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioAlteracaoCliente.RecebeSexo();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioAlteracaoCliente.RecebeCpf();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioAlteracaoCliente.RecebeEmail();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioAlteracaoCliente.RecebeNumeroCelular();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioAlteracaoCliente.RecebeUnidadeFederativa();
                    }
                    break;
                case 8:
                    {
                        TelaFormularioAlteracaoCliente.RecebeCidade();
                    }
                    break;
                case 9:
                    {
                        TelaFormularioAlteracaoCliente.RecebeBairro();
                    }
                    break;
                case 10:
                    {
                        TelaFormularioAlteracaoCliente.RecebeLogradouro();
                    }
                    break;
                case 11:
                    {
                        TelaFormularioAlteracaoCliente.RecebeComplemento();
                    }
                    break;
                case 12:
                    {
                        TelaFormularioAlteracaoCliente.RecebeCep();
                    }
                    break;
                case 13:
                    {
                        TelaFormularioAlteracaoCliente.RecebeStatus();
                    }
                    break;
                case 19:
                    {
                        Console.Clear();

                        TelaMenuCliente.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.WriteLine();

                        FuncoesTexto.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesAlteracaoCliente.ApresentaMenu();
                    }
                    break;
            }
        }
    }
}
