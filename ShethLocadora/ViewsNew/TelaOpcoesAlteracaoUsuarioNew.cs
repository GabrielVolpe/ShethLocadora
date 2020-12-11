using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesAlteracaoUsuarioNew
    {
        internal static string CpfInformado = null;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" LOCALIZAR USUÁRIO", 80, 4, 0, 1);

            RecebeCpf();
        }

        private static void RecebeCpf()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(1, 2);
            Console.Write("\n [CPF]: ");
            CpfInformado = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("\n");

            LocalizaCpf(CpfInformado);
        }

        private static void LocalizaCpf(string cpfInformado)
        {
            bool cpfLocalizado = false;

            foreach (var item in BancoDados.Usuarios)
            {
                if (item.Cpf == cpfInformado)
                {
                    cpfLocalizado = true;

                    break;
                }
            }

            if (cpfLocalizado == true)
            {
                ControllerUsuario.ConsultaCpf(cpfInformado);
            }

            VerificaResultadoLocalizacaoCpf(cpfLocalizado);
        }

        private static void VerificaResultadoLocalizacaoCpf(bool cpfLocalizado)
        {
            if (cpfLocalizado == true)
            {
                ApresentaConfirmacaoCliente();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum usuário localizado!");

                TelaMenuUsuarioNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacaoCliente()
        {
            int opcaoConfirmacaoLocalizacaoCpf = TelaConfirmacaoBinaria.GeraTela(" Confirma usuário localizado?", 81, 1);

            VerificaOpcaoConfirmacaoUsuario(opcaoConfirmacaoLocalizacaoCpf);
        }

        private static void VerificaOpcaoConfirmacaoUsuario(int opcaoConfirmacaoCliente)
        {
            if (opcaoConfirmacaoCliente == 1)
            {
                Console.Clear();

                ApresentaMenu();
            }
            else if (opcaoConfirmacaoCliente == 2)
            {
                Console.Clear();

                TelaMenuUsuarioNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaConfirmacaoCliente();
            }
        }

        internal static void ApresentaMenu()
        {
            TelaComTitulo.GeraTela(" Opções de alteração", 80, 22, 0, 1);

            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenu();

            ControllerTelaOpcoesAlteracaoUsuario.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Nome");
            Console.WriteLine(" [2] - Data de nascimento");
            Console.WriteLine(" [3] - Sexo");
            Console.WriteLine(" [4] - CPF");
            Console.WriteLine(" [5] - E-mail");
            Console.WriteLine(" [6] - Número de celular");
            Console.WriteLine(" [7] - Unidade Federativa");
            Console.WriteLine(" [8] - Cidade");
            Console.WriteLine(" [9] - Bairro");
            Console.WriteLine(" [10] - Logradouro");
            Console.WriteLine(" [11] - Complemento");
            Console.WriteLine(" [12] - Cep");
            Console.WriteLine(" [13] - Status");
            Console.WriteLine(" [14] - Permissão");
            Console.WriteLine(" [15] - Usuário de autenticação");
            Console.WriteLine(" [16] - Senha de autenticação");
            Console.WriteLine(" [19] - Menu usuário");
            Console.ResetColor();
        }
    }
}
