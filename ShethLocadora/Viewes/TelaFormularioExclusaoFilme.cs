//using ShethLocadora.Controllers;
//using ShethLocadora.Repositories;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioExclusaoFilme
//    {
//        internal static int IdInformado = 0;

//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("FORMULÁRIO DE EXCLUSÃO - FILMES");

//            RecebeId();
//        }

//        private static void RecebeId()
//        {
//            Console.Write("\n Informe o ID do filme que deseja excluir: ");
//            int.TryParse(Console.ReadLine(), out IdInformado);

//            Console.WriteLine();

//            LocalizaId(IdInformado);
//        }

//        private static void LocalizaId(int idInformado)
//        {
//            bool IdLocalizado = false;

//            foreach (var item in BancoDados.Filmes)
//            {
//                if (item.Id == idInformado)
//                {
//                    IdLocalizado = true;

//                    Console.WriteLine(item);

//                    break;
//                }
//            }

//            VerificaResultadoLocalizacaoId(IdLocalizado);
//        }

//        private static void VerificaResultadoLocalizacaoId(bool IdLocalizado)
//        {
//            if (IdLocalizado == true)
//            {
//                ApresentaConfirmacao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum filme localizado!");

//                TelaMenuFilmeNew.ApresentaTela();
//            }
//        }

//        private static void ApresentaConfirmacao()
//        {
//            int opcaoConfirmacaoExclusao = 0;

//            Console.Write(" Deseja realmente prosseguir com a exclusão? (1 = SIM / 2 = NÃO): ");
//            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoExclusao);

//            VerificaOpcaoConfirmacao(opcaoConfirmacaoExclusao);
//        }

//        private static void VerificaOpcaoConfirmacao(int opcaoConfirmacaoExclusao)
//        {
//            if (opcaoConfirmacaoExclusao == 1)
//            {
//                Console.Clear();

//                ControllerFilme.ExcluiFilme(IdInformado);

//                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão realizada com sucesso!");

//                TelaMenuFilmeNew.ApresentaTela();
//            }
//            else if (opcaoConfirmacaoExclusao == 2)
//            {
//                Console.Clear();

//                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão cancelada!");

//                TelaMenuFilmeNew.ApresentaTela();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro("\n Opção inválida!");

//                ApresentaConfirmacao();
//            }
//        }
//    }
//}