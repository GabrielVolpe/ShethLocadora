using ShethLocadora.Controllers;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaOpcoesAlteracaoUsuario
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE ALTERAÇÕES - USUÁRIOS");

            LocalizaUsuarioAlteracao();
        }

        internal static string CpfInformado;

        private static void LocalizaUsuarioAlteracao()
        {
            Console.Write("\n Informe o CPF do usuário que deseja alterar: ");
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

                ApresentaMenu();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Nenhum usuário localizado!");

                TelaMenuUsuario.ApresentaTela();
            }
        }

        internal static void ApresentaMenu()
        {
            Console.WriteLine(" Opções de alteração:");

            Console.WriteLine("\n 1 - Nome");
            Console.WriteLine(" 2 - Data de nascimento");
            Console.WriteLine(" 3 - Sexo");
            Console.WriteLine(" 4 - CPF");
            Console.WriteLine(" 5 - E-mail");
            Console.WriteLine(" 6 - Número de celular");
            Console.WriteLine(" 7 - Unidade Federativa");
            Console.WriteLine(" 8 - Cidade");
            Console.WriteLine(" 9 - Bairro");
            Console.WriteLine(" 10 - Logradouro");
            Console.WriteLine(" 11 - Complemento");
            Console.WriteLine(" 12 - Cep");
            Console.WriteLine(" 13 - Status");
            Console.WriteLine(" 14 - Permissão");
            Console.WriteLine(" 15 - Usuário de autenticação");
            Console.WriteLine(" 16 - Senha de autenticação");
            Console.WriteLine(" 19 - Menu Filmes");

            int opcaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            ControllerTelaOpcoesAlteracaoUsuario.RecebeOpcaoMenu(opcaoInformada);
        }
    }
}
