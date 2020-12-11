using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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
                        TelaFormularioConsultaLocacaoNew.ListaTodas();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaLocacaoNew.ListaAtivas();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaLocacaoNew.ListaInativas();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaLocacaoNew.ListaRegulares();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioConsultaLocacaoNew.ListaIrregulares();
                    }
                    break;
                case 6:
                    {
                        TelaFormularioConsultaLocacaoNew.ConsultaId();
                    }
                    break;
                case 7:
                    {
                        TelaFormularioConsultaLocacaoNew.ConsultaCpf();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuLocacaoNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesConsultaLocacaoNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
