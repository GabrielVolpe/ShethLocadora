using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaMenuFilme
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
                        TelaFormularioCadastroFilme.IniciaFomrulario();
                    }
                    break;
                case 2:
                    {
                        TelaOpcoesConsultaFilme.ApresentaTela();
                    }
                    break;
                case 3:
                    {
                        TelaOpcoesAlteracaoFilme.ApresentaTela();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioExclusaoFilme.ApresentaTela();
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

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaMenuInicio.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
