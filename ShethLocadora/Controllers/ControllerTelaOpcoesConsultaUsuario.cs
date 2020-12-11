using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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
                        TelaFormularioConsultaUsuarioNew.ListaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaUsuarioNew.ListaNome();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaUsuarioNew.ConsultaId();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaUsuarioNew.ConsultaCpf();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuUsuarioNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesConsultaUsuarioNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
