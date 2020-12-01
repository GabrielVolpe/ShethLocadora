using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesConsultaUsuario
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
                        TelaFormularioConsultaUsuario.ListaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaUsuario.ListaNome();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaUsuario.ConsultaId();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaUsuario.ConsultaCpf();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuUsuario.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesConsultaUsuarios.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
