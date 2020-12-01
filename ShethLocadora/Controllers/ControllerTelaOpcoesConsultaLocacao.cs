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
                        TelaFormularioConsultaLocacao.ListaTodas();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaLocacao.ListaAtivas();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaLocacao.ListaInativas();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaLocacao.ListaRegulares();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioConsultaLocacao.ListaIrregulares();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioConsultaLocacao.ConsultaId();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioConsultaLocacao.ConsultaCpf();
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

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesConsultaLocacao.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
