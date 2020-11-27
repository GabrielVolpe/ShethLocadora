using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioAlteracaoCliente
    {
        internal static void RecebeNome()
        {
            Tuple<bool, string> retornoNome = TelaFormularioDadosPessoa.RecebeNome();

            if (retornoNome.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNome(TelaOpcoesAlteracaoCliente.CpfInformado, retornoNome.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Nome inválido!");

                RecebeNome();
            }
        }

        internal static void RecebeDataNascimento()
        {
            Tuple<bool, string> retornoDataNascimento = TelaFormularioDadosPessoa.RecebeDataNascimento();

            if (retornoDataNascimento.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraDataNascimento(TelaOpcoesAlteracaoCliente.CpfInformado, retornoDataNascimento.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Data inválida!");

                RecebeDataNascimento();
            }
        }

        internal static void RecebeSexo()
        {
            Tuple<bool, int> retornoSexo = TelaFormularioDadosPessoa.RecebeSexo();

            if (retornoSexo.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraSexo(TelaOpcoesAlteracaoCliente.CpfInformado, retornoSexo.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeSexo();
            }
        }

        internal static void RecebeCpf()
        {
            Tuple<bool, string> retornoCpf = TelaFormularioDadosPessoa.RecebeCpf();

            if (retornoCpf.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCpf(TelaOpcoesAlteracaoCliente.CpfInformado, retornoCpf.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cpf inválido!");

                RecebeCpf();
            }
        }

        internal static void RecebeEmail()
        {
            Tuple<bool, string> retornoEmail = TelaFormularioDadosPessoa.RecebeEmail();

            if (retornoEmail.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraEmail(TelaOpcoesAlteracaoCliente.CpfInformado, retornoEmail.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("E-mail inválido!");

                RecebeEmail();
            }
        }

        internal static void RecebeNumeroCelular()
        {
            Tuple<bool, string> retornoNumeroCelular = TelaFormularioDadosPessoa.RecebeEmail();

            if (retornoNumeroCelular.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNumeroCelular(TelaOpcoesAlteracaoCliente.CpfInformado, retornoNumeroCelular.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Número de celular inválido!");

                RecebeNumeroCelular();
            }
        }

        internal static void RecebeUnidadeFederativa()
        {
            Tuple<bool, int> retornoUnidadeFederativa = TelaFormularioDadosEndereco.RecebeUnidadeFederativa();

            if (retornoUnidadeFederativa.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraUnidadeFederativa(TelaOpcoesAlteracaoCliente.CpfInformado, retornoUnidadeFederativa.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeUnidadeFederativa();
            }
        }

        internal static void RecebeCidade()
        {
            Tuple<bool, string> retornoCidade = TelaFormularioDadosEndereco.RecebeCidade();

            if (retornoCidade.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCidade(TelaOpcoesAlteracaoCliente.CpfInformado, retornoCidade.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cidade inválida!");

                RecebeCidade();
            }
        }

        internal static void RecebeBairro()
        {
            Tuple<bool, string> retornoBairro = TelaFormularioDadosEndereco.RecebeBairro();

            if (retornoBairro.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraBairro(TelaOpcoesAlteracaoCliente.CpfInformado, retornoBairro.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Bairro inválido!");

                RecebeBairro();
            }
        }

        internal static void RecebeLogradouro()
        {
            Tuple<bool, string> retornoLogradouro = TelaFormularioDadosEndereco.RecebeLogradouro();

            if (retornoLogradouro.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraLogradouro(TelaOpcoesAlteracaoCliente.CpfInformado, retornoLogradouro.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Logradouro inválido!");

                RecebeLogradouro();
            }
        }

        internal static void RecebeComplemento()
        {
            Tuple<bool, string> retornoComplemento = TelaFormularioDadosEndereco.RecebeComplemento();

            if (retornoComplemento.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraComplemento(TelaOpcoesAlteracaoCliente.CpfInformado, retornoComplemento.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Complemento inválido!");

                RecebeComplemento();
            }
        }

        internal static void RecebeCep()
        {
            Tuple<bool, string> retornoCep = TelaFormularioDadosEndereco.RecebeCep();

            if (retornoCep.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCep(TelaOpcoesAlteracaoCliente.CpfInformado, retornoCep.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cep inválido!");

                RecebeCep();
            }
        }

        internal static void RecebeStatus()
        {
            Tuple<bool, int> retornoStatus = TelaFormularioCadastroCliente.RecebeStatus();

            if (retornoStatus.Item1 == true)
            {
                Console.Clear();

                ControllerCliente.AlteraStatus(TelaOpcoesAlteracaoCliente.CpfInformado, retornoStatus.Item2);

                FinalizaAlteracao();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        private static void FinalizaAlteracao()
        {
            UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

            TelaMenuCliente.ApresentaTela();
        }
    }
}
