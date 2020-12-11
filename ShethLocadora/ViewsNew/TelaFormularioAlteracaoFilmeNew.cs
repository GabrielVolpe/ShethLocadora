using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioAlteracaoFilmeNew
    {
        internal static void RecebeStatus()
        {
            Tuple<bool, int> retornoStatus = TelaFormularioCadastroFilmeNew.RecebeStatus();

            if (retornoStatus.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraStatus(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeTitulo()
        {
            Tuple<bool, string> retornoTitulo = TelaFormularioCadastroFilmeNew.RecebeTitulo();

            if (retornoTitulo.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraTitutlo(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeDiretor()
        {
            Tuple<bool, string> retornoDiretor = TelaFormularioCadastroFilmeNew.RecebeDiretor();

            if (retornoDiretor.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraDiretor(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeCategoria()
        {
            Tuple<bool, int> retornoCategoria = TelaFormularioCadastroFilmeNew.RecebeCategoria();

            if (retornoCategoria.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraCategoria(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeClassificacaoIndicativa()
        {
            Tuple<bool, int> retornoClassificacaoIndicativa = TelaFormularioCadastroFilmeNew.RecebeClassificacaoIndicativa();

            if (retornoClassificacaoIndicativa.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraClassificacaoIndicativa(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeValorLocacao()
        {
            Tuple<bool, double> retornoValorLocacao = TelaFormularioCadastroFilmeNew.RecebeValorLocacao();

            if (retornoValorLocacao.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraValorLocacao(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebePeriodoDiasLocacao()
        {
            Tuple<bool, int> retornoPeriodoDiasLocacao = TelaFormularioCadastroFilmeNew.RecebePeriodoDiasLocacao();

            if (retornoPeriodoDiasLocacao.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraPeriodoDiasLocacao(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        internal static void RecebeQuantidadeDisponivel()
        {
            Tuple<bool, int> retornoQuantidadeDisponivel = TelaFormularioCadastroFilmeNew.RecebeQuantidadeDisponivel();

            if (retornoQuantidadeDisponivel.Item1 == true)
            {
                Console.Clear();

                ControllerFilme.AlteraQuantidadeDisponivel(TelaOpcoesAlteracaoFilmeNew.IdInformado);

                FinalizaAlteracao();
            }
        }

        private static void FinalizaAlteracao()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso(" Alteração realizada com sucesso!");

            TelaMenuFilmeNew.ApresentaTela();
        }
    }
}
