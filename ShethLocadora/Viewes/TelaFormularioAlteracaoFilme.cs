using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioAlteracaoFilme
    {
        internal static void RecebeStatus()
        {
            Tuple<bool, int> retornoStatus = TelaFormularioCadastroFilme.RecebeStatus();

            if (retornoStatus.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraStatus(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeTitulo()
        {
            Tuple<bool, string> retornoTitulo = TelaFormularioCadastroFilme.RecebeTitulo();

            if (retornoTitulo.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraTitutlo(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeDiretor()
        {
            Tuple<bool, string> retornoDiretor = TelaFormularioCadastroFilme.RecebeDiretor();

            if (retornoDiretor.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraDiretor(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeCategoria()
        {
            Tuple<bool, int> retornoCategoria = TelaFormularioCadastroFilme.RecebeCategoria();

            int contadorCategoriaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumCategoriaFilme)))
            {
                Console.WriteLine($" {contadorCategoriaFilme} - {opcaoEnum}");

                contadorCategoriaFilme++;
            }

            if (retornoCategoria.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraCategoria(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeClassificacaoIndicativa()
        {
            Tuple<bool, int> retornoClassificacaoIndicativa = TelaFormularioCadastroFilme.RecebeClassificacaoIndicativa();

            int contadorClassificacaoIndicativaFilme = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumClassificacaoIndicativaFilme)))
            {
                Console.WriteLine($" {contadorClassificacaoIndicativaFilme} - {opcaoEnum}");
                contadorClassificacaoIndicativaFilme++;
            }

            if (retornoClassificacaoIndicativa.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraClassificacaoIndicativa(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeValorLocacao()
        {
            Tuple<bool, double> retornoValorLocacao = TelaFormularioCadastroFilme.RecebeValorLocacao();

            if (retornoValorLocacao.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraValorLocacao(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebePeriodoDiasLocacao()
        {
            Tuple<bool, int> retornoPeriodoDiasLocacao = TelaFormularioCadastroFilme.RecebePeriodoDiasLocacao();

            if (retornoPeriodoDiasLocacao.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraPeriodoDiasLocacao(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeQuantidadeDisponivel()
        {
            Tuple<bool, int> retornoQuantidadeDisponivel = TelaFormularioCadastroFilme.RecebeQuantidadeDisponivel();

            if (retornoQuantidadeDisponivel.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraQuantidadeDisponivel(TelaOpcoesAlteracaoFilme.IdInformado);

                FinalizaAlteracao();
            }
        }

        private static void FinalizaAlteracao()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

            TelaMenuFilme.ApresentaTela();
        }
    }
}
