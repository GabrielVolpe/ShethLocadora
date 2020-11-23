using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioExclusaoUsuario
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE EXCLUSÃO - USUÁRIOS");

            LocalizaUsuarioExclusao();
        }

        internal static string CpfInformado;

        private static void LocalizaUsuarioExclusao()
        {
            Console.Write("\n Informe o CPF do usuário que deseja excluir: ");
            CpfInformado = Console.ReadLine();

            bool resultadoValidacaoCpf = ValidaCpfInformado.ValidaCpfUsuario(CpfInformado);

            Console.WriteLine();

            if (resultadoValidacaoCpf == true)
            {
                foreach (var item in BancoDados.Usuarios)
                {
                    if (item.Cpf == CpfInformado)
                    {
                        Console.WriteLine(item);
                    }
                }

                ApresentaConfirmacao();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Nenhum usuário localizado!");

                TelaMenuUsuario.ApresentaTela();
            }
        }

        private static void ApresentaConfirmacao()
        {
            int opcaoConfirmacaoExclusao = 0;

            Console.Write(" Deseja realmente prosseguir com a exclusão? (1 = SIM / 2 = NÃO): ");
            int.TryParse(Console.ReadLine(), out opcaoConfirmacaoExclusao);

            if (opcaoConfirmacaoExclusao == 1)
            {
                Console.Clear();

                ControllerUsuario.ExcluiUsuario(CpfInformado);

                FuncoesTexto.ApresentaMensagemSucesso("Exclusão realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusao == 2)
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemSucesso("Exclusão cancelada!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("\nOpção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
