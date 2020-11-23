using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesConsultaLocacao
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
                        TelaFormularioConsultaLocacao.ConsultaTodas();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaLocacao.ConsultaId();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaLocacao.ConsultaCpf();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaLocacao.ConsultaAtivas();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioConsultaLocacao.ConsultaInativas();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioConsultaLocacao.ConsultaRegulares();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioConsultaLocacao.ConsultaIrregulares();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuLocacao.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        FuncoesTexto.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesConsultaLocacao.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
