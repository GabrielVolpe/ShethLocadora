using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioCadastroCliente
    {
        internal static void IniciaFomrulario()
        {
            FuncoesTexto.ApresentaCabecalho("FORMULÁRIO DE CADASTRO - CLIENTES");

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

            bool resultadoValidacaoStatus = ControllerCliente.ValidaStatusInformado(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        private static void FinalizaCadastro()
        {
            Console.Clear();

            bool resultadoFinalizacaoCadastro = ControllerCliente.FinalizaCadastro();

            if (resultadoFinalizacaoCadastro == true)
            {
                FuncoesTexto.ApresentaMensagemSucesso("Cadastro realizado com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                FuncoesTexto.ApresentaMensagemErro("Cadastro cancelado! Cliente já cadastrado.");

                TelaMenuCliente.ApresentaTela();
            }
        }
    }
}
