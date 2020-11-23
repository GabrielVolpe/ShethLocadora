using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioCadastroUsuario
    {
        internal static void IniciaFomrulario()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE CADASTRO - USUÁRIOS");

            Console.WriteLine("\n Informe os dados abaixo para efetuar o cadastro: ");

            TelaFormularioCadastroPessoa.RecebeNome();
            TelaFormularioCadastroPessoa.RecebeDataNascimento();
            TelaFormularioCadastroPessoa.RecebeSexo();
            TelaFormularioCadastroPessoa.RecebeCpf();
            TelaFormularioCadastroPessoa.RecebeEmail();
            TelaFormularioCadastroPessoa.RecebeNumeroCelular();
            TelaFormularioCadastroEndereco.RecebeUnidadeFederativa();
            TelaFormularioCadastroEndereco.RecebeCidade();
            TelaFormularioCadastroEndereco.RecebeBairro();
            TelaFormularioCadastroEndereco.RecebeLogradouro();
            TelaFormularioCadastroEndereco.RecebeComplemento();
            TelaFormularioCadastroEndereco.RecebeCep();
            RecebeStatus();
            RecebePermissao();
            RecebeUsuarioAutenticacao();
            RecebeSenhaAutenticacao();
            FinalizaCadastro();
        }

        private static void RecebeStatus()
        {
            Console.WriteLine("\n ================================================== Status");

            Console.WriteLine("\n 1 - Ativo");
            Console.WriteLine(" 2 - Inativo");

            int opcaoStatusInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoStatusInformada);

            bool resultadoValidacaoStatus = ControllerUsuario.ValidaStatusInformado(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        private static void RecebePermissao()
        {
            Console.WriteLine("\n ================================================== Permissão");

            Console.WriteLine("\n 1 - Administrador");
            Console.WriteLine(" 2 - Operador");

            int opcaoPermissaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoPermissaoInformada);

            bool resultadoValidacaoPermissao = ControllerUsuario.ValidaPermissaoInformada(opcaoPermissaoInformada);

            if (resultadoValidacaoPermissao == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebePermissao();
            }
        }

        private static void RecebeUsuarioAutenticacao()
        {
            Console.WriteLine("\n ================================================== Usuário de autenticação");

            string usuarioAutenticacaoInformado;

            Console.Write("\n ");

            usuarioAutenticacaoInformado = Console.ReadLine();

            bool resultadoValidacaoUsuarioAutenticacao = ControllerUsuario.ValidaUsuarioAutenticacao(usuarioAutenticacaoInformado);

            if (resultadoValidacaoUsuarioAutenticacao == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Usuário inválido!");

                RecebeUsuarioAutenticacao();
            }
        }

        private static void RecebeSenhaAutenticacao()
        {
            Console.WriteLine("\n ================================================== Senha de autenticação");

            string senhaAutenticacaoInformado;

            Console.Write("\n ");

            senhaAutenticacaoInformado = Console.ReadLine();

            bool resultadoValidacaoSenhaAutenticacao = ControllerUsuario.ValidaSenhaAutenticacao(senhaAutenticacaoInformado);

            if (resultadoValidacaoSenhaAutenticacao == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Senha inválida!");

                RecebeUsuarioAutenticacao();
            }
        }

        private static void FinalizaCadastro()
        {
            Console.Clear();

            bool resultadoFinalizacaoCadastro = ControllerUsuario.FinalizaCadastro();

            if (resultadoFinalizacaoCadastro == true)
            {
                FuncoesTexto.ApresentaMensagemSucesso("Cadastro realizado com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Cadastro cancelado! Usuário já cadastrado.");

                TelaMenuUsuario.ApresentaTela();
            }
        }
    }
}
