using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioAlteracaoFilmeNew
    {
        internal static void RecebeStatus()
        {
            TelaFormularioCadastroFilmeNew.RecebeStatus();

            Console.Clear();

            ControllerFilme.AlteraStatus(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeTitulo()
        {
            TelaFormularioCadastroFilmeNew.RecebeTitulo();

            Console.Clear();

            ControllerFilme.AlteraTitutlo(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeDiretor()
        {
            TelaFormularioCadastroFilmeNew.RecebeDiretor();

            Console.Clear();

            ControllerFilme.AlteraDiretor(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeCategoria()
        {
            TelaFormularioCadastroFilmeNew.RecebeCategoria();

            Console.Clear();

            ControllerFilme.AlteraCategoria(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeClassificacaoIndicativa()
        {
            TelaFormularioCadastroFilmeNew.RecebeClassificacaoIndicativa();

            Console.Clear();

            ControllerFilme.AlteraClassificacaoIndicativa(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeValorLocacao()
        {
            TelaFormularioCadastroFilmeNew.RecebeValorLocacao();

            Console.Clear();

            ControllerFilme.AlteraValorLocacao(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebePeriodoDiasLocacao()
        {
            TelaFormularioCadastroFilmeNew.RecebePeriodoDiasLocacao();

            Console.Clear();

            ControllerFilme.AlteraPeriodoDiasLocacao(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        internal static void RecebeQuantidadeDisponivel()
        {
            TelaFormularioCadastroFilmeNew.RecebeQuantidadeDisponivel();

            Console.Clear();

            ControllerFilme.AlteraQuantidadeDisponivel(TelaOpcoesAlteracaoFilmeNew.IdInformado);

            FinalizaAlteracao();
        }

        private static void FinalizaAlteracao()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso(" Alteração realizada com sucesso!");

            TelaMenuFilmeNew.ApresentaTela();
        }
    }
}
