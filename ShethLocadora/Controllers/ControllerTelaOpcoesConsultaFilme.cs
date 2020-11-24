using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
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
                        TelaFormularioConsultaFilme.ConsultaTodos();
                    }
                    break;
                case 2:
                    {
                        TelaFormularioConsultaFilme.ConsultaId();
                    }
                    break;
                case 3:
                    {
                        TelaFormularioConsultaFilme.ConsultaTitulo();
                    }
                    break;
                case 4:
                    {
                        TelaFormularioConsultaFilme.ConsultaDiretor();
                    }
                    break;
                case 5:
                    {
                        TelaFormularioConsultaFilme.ConsultaCategoria();
                    }
                    break;
                case 9:
                    {
                        Console.Clear();

                        TelaMenuFilme.ApresentaTela();
                    }
                    break;
                default:
                    {
                        Console.Clear();

                        UtilitariosGlobais.ApresentaMensagemErro("Opcão inválida! ");

                        TelaOpcoesConsultaFilme.ApresentaTela();
                    }
                    break;
            }
        }
    }
}
