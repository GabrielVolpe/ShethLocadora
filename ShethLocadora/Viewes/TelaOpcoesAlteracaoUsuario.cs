//using ShethLocadora.Controllers;
//using ShethLocadora.Repositories;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaOpcoesAlteracaoUsuario
//    {
//        internal static string CpfInformado = null;

//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro("FORMULÁRIO DE ALTERAÇÕES - USUÁRIOS");

//            RecebeCpf();
//        }

//        private static void RecebeCpf()
//        {
//            Console.Write("\n Informe o CPF do usuário que deseja alterar: ");
//            CpfInformado = Console.ReadLine();

//            Console.WriteLine();

//            LocalizaCpf(CpfInformado);
//        }

//        private static void LocalizaCpf(string CpfInformado)
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
//                ApresentaMenu();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum usuário localizado!");

//                TelaMenuUsuarioNew.ApresentaTela();
//            }
//        }

//        internal static void ApresentaMenu()
//        {
//            Console.WriteLine(" Opções de alteração:");

//            OpcoesMenu();

//            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

//            ControllerTelaOpcoesAlteracaoUsuario.RecebeOpcaoMenu(opcaoInformada);
//        }

//        private static void OpcoesMenu()
//        {
//            Console.WriteLine("\n 1 - Nome");
//            Console.WriteLine(" 2 - Data de nascimento");
//            Console.WriteLine(" 3 - Sexo");
//            Console.WriteLine(" 4 - CPF");
//            Console.WriteLine(" 5 - E-mail");
//            Console.WriteLine(" 6 - Número de celular");
//            Console.WriteLine(" 7 - Unidade Federativa");
//            Console.WriteLine(" 8 - Cidade");
//            Console.WriteLine(" 9 - Bairro");
//            Console.WriteLine(" 10 - Logradouro");
//            Console.WriteLine(" 11 - Complemento");
//            Console.WriteLine(" 12 - Cep");
//            Console.WriteLine(" 13 - Status");
//            Console.WriteLine(" 14 - Permissão");
//            Console.WriteLine(" 15 - Usuário de autenticação");
//            Console.WriteLine(" 16 - Senha de autenticação");
//            Console.WriteLine(" 19 - Menu Filmes");
//        }
//    }
//}