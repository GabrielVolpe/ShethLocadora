using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesConsultaCliente
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
                        TelaFormularioConsultaClienteNew.ListaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaClienteNew.ListaNome();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaClienteNew.ConsultaId();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaClienteNew.ConsultaCpf();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuClienteNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesConsultaClienteNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
