using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;

namespace ShethLocadora.Controllers
{
    static class ControllerTelaOpcoesConsultaFilme
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
                        TelaFormularioConsultaFilmeNew.ListaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaFilmeNew.ListaTitulo();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaFilmeNew.ListaDiretor();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaFilmeNew.ListaCategoria();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioConsultaFilmeNew.ConsultaId();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuFilmeNew.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro(" Opcão inválida!");

                        TelaOpcoesConsultaFilmeNew.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
