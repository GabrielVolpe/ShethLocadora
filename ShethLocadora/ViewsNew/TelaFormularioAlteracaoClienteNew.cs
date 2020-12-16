using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using ShethLocadora.Viewes;
using System;

namespace ShethLocadora.ViewsNew
{
    class TelaFormularioAlteracaoClienteNew
    {
        internal static void RecebeNome()
        {
            Tuple<bool, string> retornoNome = TelaFormularioDadosPessoa.RecebeNome();

            if (retornoNome.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNome(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoNome.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Nome inválido!");

                RecebeNome();
            }
        }

        internal static void RecebeDataNascimento()
        {
            Tuple<bool, string> retornoDataNascimento = TelaFormularioDadosPessoa.RecebeDataNascimento();

            if (retornoDataNascimento.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraDataNascimento(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoDataNascimento.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Data inválida!");

                RecebeDataNascimento();
            }
        }

        internal static void RecebeSexo()
        {
            Tuple<bool, int> retornoSexo = TelaFormularioDadosPessoa.RecebeSexo();

            if (retornoSexo.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraSexo(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoSexo.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeSexo();
            }
        }

        internal static void RecebeCpf()
        {
            Tuple<bool, string> retornoCpf = TelaFormularioDadosPessoa.RecebeCpf();

            if (retornoCpf.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCpf(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoCpf.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cpf inválido!");

                RecebeCpf();
            }
        }

        internal static void RecebeEmail()
        {
            Tuple<bool, string> retornoEmail = TelaFormularioDadosPessoa.RecebeEmail();

            if (retornoEmail.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraEmail(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoEmail.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" E-mail inválido!");

                RecebeEmail();
            }
        }

        internal static void RecebeNumeroCelular()
        {
            Tuple<bool, string> retornoNumeroCelular = TelaFormularioDadosPessoa.RecebeNumeroCelular();

            if (retornoNumeroCelular.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNumeroCelular(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoNumeroCelular.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Número de celular inválido!");

                RecebeNumeroCelular();
            }
        }

        internal static void RecebeUnidadeFederativa()
        {
            Tuple<bool, int> retornoUnidadeFederativa = TelaFormularioDadosEndereco.RecebeUnidadeFederativa();

            if (retornoUnidadeFederativa.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraUnidadeFederativa(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoUnidadeFederativa.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

                RecebeUnidadeFederativa();
            }
        }

        internal static void RecebeCidade()
        {
            Tuple<bool, string> retornoCidade = TelaFormularioDadosEndereco.RecebeCidade();

            if (retornoCidade.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCidade(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoCidade.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cidade inválida!");

                RecebeCidade();
            }
        }

        internal static void RecebeBairro()
        {
            Tuple<bool, string> retornoBairro = TelaFormularioDadosEndereco.RecebeBairro();

            if (retornoBairro.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraBairro(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoBairro.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Bairro inválido!");

                RecebeBairro();
            }
        }

        internal static void RecebeLogradouro()
        {
            Tuple<bool, string> retornoLogradouro = TelaFormularioDadosEndereco.RecebeLogradouro();

            if (retornoLogradouro.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraLogradouro(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoLogradouro.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Logradouro inválido!");

                RecebeLogradouro();
            }
        }

        internal static void RecebeComplemento()
        {
            Tuple<bool, string> retornoComplemento = TelaFormularioDadosEndereco.RecebeComplemento();

            if (retornoComplemento.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraComplemento(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoComplemento.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Complemento inválido!");

                RecebeComplemento();
            }
        }

        internal static void RecebeCep()
        {
            Tuple<bool, string> retornoCep = TelaFormularioDadosEndereco.RecebeCep();

            if (retornoCep.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCep(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoCep.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Cep inválido!");

                RecebeCep();
            }
        }

        internal static void RecebeStatus()
        {
            Tuple<bool, int> retornoStatus = TelaFormularioCadastroClienteNew.RecebeStatus();

            Console.Clear();

            ControllerCliente.AlteraStatus(TelaOpcoesAlteracaoClienteNew.CpfInformado, retornoStatus.Item2);

            FinalizaAlteracao();
        }

        private static void FinalizaAlteracao()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso(" Alteração realizada com sucesso!");

            TelaMenuClienteNew.ApresentaTela();
        }
    }
}