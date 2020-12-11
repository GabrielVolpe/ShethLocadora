//using ShethLocadora.Controllers;
//using ShethLocadora.Repositories;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioExclusaoUsuario
//    {
//        internal static string CpfInformado = null;

//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("FORMULÁRIO DE EXCLUSÃO - USUÁRIOS");

//            RecebeCpf();
//        }

//        private static void RecebeCpf()
//        {
//            Console.Write("\n Informe o CPF do usuário que deseja excluir: ");
//            CpfInformado = Console.ReadLine();

//            Console.WriteLine();

//            LocalizaCpf(CpfInformado);
//        }

//        private static void LocalizaCpf(string cpfInformado)
//        {
//            bool cpfLocalizado = false;

//            foreach (var item in BancoDados.Usuarios)
//            {
//                if (item.Cpf == CpfInformado)
//                {
//                    cpfLocalizado = true;

//                    Console.WriteLine(item);

//                    break;
//                }
//            }

//            VerificaResultadoLocalizacaoCpf(cpfLocalizado);
//        }

//        private static void VerificaResultadoLocalizacaoCpf(bool cpfLocalizado)
//        {
//            if (cpfLocalizado == true)
//            {
//                ApresentaConfirmacao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum usuário localizado!");

//                TelaMenuUsuarioNew.ApresentaTela();
//            }
//        }

//        private static void ApresentaConfirmacao()
//        {
//            int opcaoConfirmacaoExclusao = 0;

//            Console.Write(" Deseja realmente prosseguir com a exclusão? (1 = SIM / 2 = NÃO): ");
//            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoExclusao);

//            if (opcaoConfirmacaoExclusao == 1)
//            {
//                Console.Clear();

//                ControllerUsuario.ExcluiUsuario(CpfInformado);

//                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão realizada com sucesso!");

//                TelaMenuUsuarioNew.ApresentaTela();
//            }
//            else if (opcaoConfirmacaoExclusao == 2)
//            {
//                Console.Clear();

//                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão cancelada!");

//                TelaMenuUsuarioNew.ApresentaTela();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro("\n Opção inválida!");

//                ApresentaConfirmacao();
//            }
//        }
//    }
//}