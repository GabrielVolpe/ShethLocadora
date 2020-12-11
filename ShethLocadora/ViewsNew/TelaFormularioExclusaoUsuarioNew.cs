using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioExclusaoUsuarioNew
    {
        internal static string CpfInformado = null;

        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" FORMULÁRTIO DE EXCLUSÃO - USUÁRIOS", 80, 4, 0, 1);

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
                ApresentaConfirmacaoUsuario();
            }
            else
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemErro(" Nenhum usuário localizado!");

                TelaMenuUsuarioNew.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacaoUsuario()
        {
            int opcaoConfirmacaoCpfLocalizado = TelaConfirmacaoBinaria.GeraTela(" Confirma usuário localizado?", 81, 1);

            VerificaOpcaoConfirmacaoCliente(opcaoConfirmacaoCpfLocalizado);
        }

        private static void VerificaOpcaoConfirmacaoCliente(int opcaoConfirmacaoUsuario)
        {
            if (opcaoConfirmacaoUsuario == 1)
            {
                RecebeConfirmacaoExclusao();
            }
            else if (opcaoConfirmacaoUsuario == 2)
            {
                Console.Clear();

                TelaMenuUsuarioNew.ApresentaTela();
            }
            else
            {
                Console.SetCursorPosition(81, 0);
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                ApresentaConfirmacaoUsuario();
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

                ControllerUsuario.ExcluiUsuario(CpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão realizada com sucesso!");

                TelaMenuUsuarioNew.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusaoInformada == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso(" Exclusão cancelada!");

                TelaMenuUsuarioNew.ApresentaTela();
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
