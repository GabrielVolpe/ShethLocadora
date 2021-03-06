﻿using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaFormularioCadastroClienteNew
    {
        internal static void IniciaFormulario()
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" FORMULÁRIO DE CADASTRO - DADOS PESSOAIS");

            RecebeNome();
            RecebeDataNascimento();
            RecebeSexo();
            RecebeCpf();
            RecebeEmail();
            RecebeNumeroCelular();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" FORMULÁRIO DE CADASTRO - ENDEREÇO");

            RecebeUnidadeFederativa();
            RecebeCidade();
            RecebeBairro();
            RecebeLogradouro();
            RecebeComplemento();
            RecebeCep();

            Console.Clear();

            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" FORMULÁRIO DE CADASTRO - INFORMAÇÕES ADICIONAIS");

            RecebeStatus();

            FinalizaCadastro();
        }

        private static void RecebeNome()
        {
            Tuple<bool, string> retornoNome = TelaFormularioDadosPessoa.RecebeNome();

            if (retornoNome.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Nome inválido!");

                RecebeNome();
            }
        }

        private static void RecebeDataNascimento()
        {
            Tuple<bool, string> retornoDataNascimento = TelaFormularioDadosPessoa.RecebeDataNascimento();

            if (retornoDataNascimento.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Data de nascimento inválida!");

                RecebeDataNascimento();
            }
        }

        private static void RecebeSexo()
        {
            Tuple<bool, int> retornoSexo = TelaFormularioDadosPessoa.RecebeSexo();

            if (retornoSexo.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeSexo();
            }
        }

        private static void RecebeCpf()
        {
            Tuple<bool, string> retornoCpf = TelaFormularioDadosPessoa.RecebeCpf();

            if (retornoCpf.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" CPF inválido!");

                RecebeCpf();
            }
        }

        private static void RecebeEmail()
        {
            Tuple<bool, string> retornoEmail = TelaFormularioDadosPessoa.RecebeEmail();

            if (retornoEmail.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" E-mail inválido!");

                RecebeEmail();
            }
        }

        private static void RecebeNumeroCelular()
        {
            Tuple<bool, string> retornoNumeroCelular = TelaFormularioDadosPessoa.RecebeNumeroCelular();

            if (retornoNumeroCelular.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Número de celular inválido!");

                RecebeNumeroCelular();
            }
        }

        private static void RecebeUnidadeFederativa()
        {
            Tuple<bool, int> retornoUnidadeFederativa = TelaFormularioDadosEndereco.RecebeUnidadeFederativa();

            if (retornoUnidadeFederativa.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeUnidadeFederativa();
            }
        }

        private static void RecebeCidade()
        {
            Tuple<bool, string> retornoCidade = TelaFormularioDadosEndereco.RecebeCidade();

            if (retornoCidade.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cidade inválida!");

                RecebeCidade();
            }
        }

        private static void RecebeBairro()
        {
            Tuple<bool, string> retornoBairro = TelaFormularioDadosEndereco.RecebeBairro();

            if (retornoBairro.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Bairro inválido!");

                RecebeBairro();
            }
        }

        private static void RecebeLogradouro()
        {
            Tuple<bool, string> retornoLograoduro = TelaFormularioDadosEndereco.RecebeLogradouro();

            if (retornoLograoduro.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Lograoduro inválido!");

                RecebeLogradouro();
            }
        }

        private static void RecebeComplemento()
        {
            Tuple<bool, string> retornoComplemento = TelaFormularioDadosEndereco.RecebeComplemento();

            if (retornoComplemento.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Complemento inválido!");

                RecebeComplemento();
            }
        }

        private static void RecebeCep()
        {
            Tuple<bool, string> retornoCep = TelaFormularioDadosEndereco.RecebeCep();

            if (retornoCep.Item1 == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" CEP inválido!");

                RecebeCep();
            }
        }

        internal static Tuple<bool, int> RecebeStatus()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Status]:");
            Console.ResetColor();

            Console.WriteLine(" [1] - Ativo");
            Console.WriteLine(" [2] - Inativo");

            int opcaoStatusInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]:");

            bool resultadoValidacaoStatus = ControllerCliente.ValidaStatusInformado(opcaoStatusInformada);

            if (resultadoValidacaoStatus == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeStatus();
            }

            return new Tuple<bool, int>(resultadoValidacaoStatus, opcaoStatusInformada);
        }

        private static void FinalizaCadastro()
        {
            Console.Clear();

            bool resultadoFinalizacaoCadastro = ControllerCliente.FinalizaCadastro();

            if (resultadoFinalizacaoCadastro == true)
            {
                UtilitariosGlobais.ApresentaMensagemSucesso(" Cadastro realizado com sucesso!");

                TelaMenuClienteNew.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cadastro cancelado! Cliente já cadastrado.");

                TelaMenuClienteNew.ApresentaTela();
            }
        }
    }
}
