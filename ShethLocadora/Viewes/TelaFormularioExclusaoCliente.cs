using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioExclusaoCliente
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("FORMULÁRIO DE EXCLUSÃO - CLIENTES");

            LocalizaClienteExclusao();
        }

        internal static string CpfInformado;

        private static void LocalizaClienteExclusao()
        {
            Console.Write("\n Informe o CPF do cliente que deseja excluir: ");
            CpfInformado = Console.ReadLine();

            bool resultadoValidacaoCpf = UtilitariosGlobais.ValidaCpfCliente(CpfInformado);

            Console.WriteLine();

            if (resultadoValidacaoCpf == true)
            {
                foreach (var item in BancoDados.Clientes)
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
                UtilitariosGlobais.ApresentaMensagemErro("Nenhum cliente localizado!");

                TelaMenuCliente.ApresentaTela();
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

                ControllerCliente.ExcluiCliente(CpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else if (opcaoConfirmacaoExclusao == 2)
            {
                Console.Clear();

                UtilitariosGlobais.ApresentaMensagemSucesso("Exclusão cancelada!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("\nOpção inválida!");

                ApresentaConfirmacao();
            }
        }
    }
}
