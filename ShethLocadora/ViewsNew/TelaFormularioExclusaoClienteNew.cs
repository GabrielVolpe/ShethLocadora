using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioExclusaoClienteNew
    {
        internal static string CpfInformado = null;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" FORMULÁRTIO DE EXCLUSÃO - CLIENTES", 80, 4, 0, 1);

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
            int opcaoConfirmacaoCpfLocalizado = TelaConfirmacaoBinaria.GeraTela(" Confirma cliente localizado?", 81, 1);

            VerificaOpcaoConfirmacaoCliente(opcaoConfirmacaoCpfLocalizado);
        }

        private static void VerificaOpcaoConfirmacaoCliente(int opcaoConfirmacaoCliente)
        {
            if (opcaoConfirmacaoCliente == 1)
            {
                RecebeConfirmacaoExclusao();
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

        private static void RecebeConfirmacaoExclusao()
        {
            int opcaoConfirmacaoExclusao = TelaConfirmacaoBinaria.GeraTela(" Prosseguir com a exclusão?", 81, 1);

            VerificaConfirmacaoExclusao(opcaoConfirmacaoExclusao);
        }

        private static void VerificaConfirmacaoExclusao(int opcaoConfirmacaoExclusaoInformada)
        {
            if (opcaoConfirmacaoExclusaoInformada == 1)
            {
                Console.Clear();

                ControllerCliente.ExcluiCliente(CpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão realizada com sucesso!");

                TelaMenuClienteNew.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusaoInformada == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão cancelada!");

                TelaMenuClienteNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeConfirmacaoExclusao();
            }
        }
    }
}
