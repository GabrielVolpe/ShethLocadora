using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaOpcoesAlteracaoClienteNew
    {
        internal static string CpfInformado = null;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" LOCALIZAR CLIENTE", 80, 4, 0, 1);

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

            foreach (var item in BancoDados.Clientes)
            {
                if (item.Cpf == cpfInformado)
                {
                    cpfLocalizado = true;

                    break;
                }
            }

            if (cpfLocalizado == true)
            {
                ControllerCliente.ConsultaCpf(cpfInformado);
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

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum cliente localizado!");

                TelaMenuClienteNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacaoCliente()
        {
            int opcaoConfirmacaoLocalizacaoCpf = TelaConfirmacaoBinaria.GeraTela(" Confirma cliente localizado?", 81, 1);

            VerificaOpcaoConfirmacaoCliente(opcaoConfirmacaoLocalizacaoCpf);
        }

        private static void VerificaOpcaoConfirmacaoCliente(int opcaoConfirmacaoCliente)
        {
            if (opcaoConfirmacaoCliente == 1)
            {
                Console.Clear();

                ApresentaMenu();
            }
            else if (opcaoConfirmacaoCliente == 2)
            {
                Console.Clear();

                TelaMenuClienteNew.ApresentaTela();
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
            TelaComTitulo.GeraTela(" Opções de alteração", 80, 19, 0, 1);

            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenu();

            ControllerTelaOpcoesAlteracaoCliente.RecebeOpcaoMenu(opcaoInformada);
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
            Console.WriteLine(" [19] - Menu clientes");
            Console.ResetColor();
        }
    }
}