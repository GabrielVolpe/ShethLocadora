using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaFormularioConsultaCliente.ConsultaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaCliente.ConsultaId();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaCliente.ConsultaCpf();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaCliente.ConsultaNome();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuCliente.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesConsultaCliente.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
