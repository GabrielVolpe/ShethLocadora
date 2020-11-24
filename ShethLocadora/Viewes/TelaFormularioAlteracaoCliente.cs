using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioAlteracaoCliente
    {
        internal static void RecebeNome()
        {
            Console.WriteLine("\n ================================================== Nome Completo (Sem acentos)");

            string nomeInformado;

            Console.Write("\n ");

            nomeInformado = Console.ReadLine();

            bool resultadoValidacaoNome = ControllerPessoa.ValidaNome(nomeInformado);

            if (resultadoValidacaoNome == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNome(TelaOpcoesAlteracaoCliente.CpfInformado, nomeInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Nome inválido!");

                RecebeNome();
            }
        }

        internal static void RecebeDataNascimento()
        {
            Console.WriteLine("\n ================================================== Data de Nascimento (Dia/Mes/Ano)");

            string dataNascimentoInformada;

            Console.Write("\n ");

            dataNascimentoInformada = Console.ReadLine();

            bool resultadoValidacaoDataNascimento = ControllerPessoa.ValidaDataNascimento(dataNascimentoInformada);

            if (resultadoValidacaoDataNascimento == true)
            {
                Console.Clear();

                ControllerCliente.AlteraDataNascimento(TelaOpcoesAlteracaoCliente.CpfInformado, dataNascimentoInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Data inválida!");

                RecebeDataNascimento();
            }
        }

        internal static void RecebeSexo()
        {
            Console.WriteLine("\n ================================================== Sexo");

            int contadorSexoPessoa = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumSexoPessoa)))
            {
                Console.WriteLine($" {contadorSexoPessoa} - {opcaoEnum}");

                contadorSexoPessoa++;
            }

            int opcaoSexoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoSexoInformada);

            bool resultadoValidacaoSexo = ControllerPessoa.ValidaSexo(opcaoSexoInformada);

            if (resultadoValidacaoSexo == true)
            {
                Console.Clear();

                ControllerCliente.AlteraSexo(TelaOpcoesAlteracaoCliente.CpfInformado, opcaoSexoInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeSexo();
            }
        }

        internal static void RecebeCpf()
        {
            Console.WriteLine("\n ================================================== CPF (Somente números)");

            string cpfInformado;

            Console.Write("\n ");

            cpfInformado = Console.ReadLine();

            bool resultadoValidacaoCpf = ControllerPessoa.ValidaCpf(cpfInformado);

            if (resultadoValidacaoCpf == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCpf(TelaOpcoesAlteracaoCliente.CpfInformado, cpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cpf inválido!");

                RecebeCpf();
            }
        }

        internal static void RecebeEmail()
        {
            Console.WriteLine("\n ================================================== E-mail");

            string emailInformado;

            Console.Write("\n ");

            emailInformado = Console.ReadLine();

            bool resultadoValidacaoEmail = ControllerPessoa.ValidaEmail(emailInformado);

            if (resultadoValidacaoEmail == true)
            {
                Console.Clear();

                ControllerCliente.AlteraEmail(TelaOpcoesAlteracaoCliente.CpfInformado, emailInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("E-mail inválido!");

                RecebeEmail();
            }
        }

        internal static void RecebeNumeroCelular()
        {
            Console.WriteLine("\n ================================================== Número de celular (Somente números)");

            string numeroCelularInformado;

            Console.Write("\n ");

            numeroCelularInformado = Console.ReadLine();

            bool resultadoValidacaoNumeroCelular = ControllerPessoa.ValidaNumeroCelular(numeroCelularInformado);

            if (resultadoValidacaoNumeroCelular == true)
            {
                Console.Clear();

                ControllerCliente.AlteraNumeroCelular(TelaOpcoesAlteracaoCliente.CpfInformado, numeroCelularInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Número de celular inválido!");

                RecebeNumeroCelular();
            }
        }

        internal static void RecebeUnidadeFederativa()
        {
            Console.WriteLine("\n ================================================== Unidade federativa");

            int contadorUnidadeFederativa = 1;

            Console.WriteLine();

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumUnidadeFederativaEndereco)))
            {
                Console.WriteLine($" {contadorUnidadeFederativa} - {opcaoEnum}");

                contadorUnidadeFederativa++;
            }

            int opcaoUnidadeFederativaInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoUnidadeFederativaInformada);

            bool resultadoValidacaoUnidadeFederativa = ControllerEndereco.ValidaUnidadeFederativa(opcaoUnidadeFederativaInformada);

            if (resultadoValidacaoUnidadeFederativa == true)
            {
                Console.Clear();

                ControllerCliente.AlteraUnidadeFederativa(TelaOpcoesAlteracaoCliente.CpfInformado, opcaoUnidadeFederativaInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeUnidadeFederativa();
            }
        }

        internal static void RecebeCidade()
        {
            Console.WriteLine("\n ================================================== Cidade");

            string cidadeInformada;

            Console.Write("\n ");

            cidadeInformada = Console.ReadLine();

            bool resultadoValidacaoCidade = ControllerEndereco.ValidaCidadeInformada(cidadeInformada);

            if (resultadoValidacaoCidade == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCidade(TelaOpcoesAlteracaoCliente.CpfInformado, cidadeInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cidade inválida!");

                RecebeCidade();
            }
        }

        internal static void RecebeBairro()
        {
            Console.WriteLine("\n ================================================== Bairro");

            string bairroInformado;

            Console.Write("\n ");

            bairroInformado = Console.ReadLine();

            bool resultadoValidacaoBairro = ControllerEndereco.ValidaBairroInformado(bairroInformado);

            if (resultadoValidacaoBairro == true)
            {
                Console.Clear();

                ControllerCliente.AlteraBairro(TelaOpcoesAlteracaoCliente.CpfInformado, bairroInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Bairro inválida!");

                RecebeBairro();
            }
        }

        internal static void RecebeLogradouro()
        {
            Console.WriteLine("\n ================================================== Logradouro (Sem acentos)");

            string logradouroInformado;

            Console.Write("\n ");

            logradouroInformado = Console.ReadLine();

            bool resultadoValidacaoLogradouro = ControllerEndereco.ValidaLogradouroInformado(logradouroInformado);

            if (resultadoValidacaoLogradouro == true)
            {
                Console.Clear();

                ControllerCliente.AlteraLogradouro(TelaOpcoesAlteracaoCliente.CpfInformado, logradouroInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Logradouro inválida!");

                RecebeLogradouro();
            }
        }

        internal static void RecebeComplemento()
        {
            Console.WriteLine("\n ================================================== Complemento (Sem acentos)");

            string complementoInformado;

            Console.Write("\n ");

            complementoInformado = Console.ReadLine();

            bool resultadoValidacaoComplemento = ControllerEndereco.ValidaComplementoInformado(complementoInformado);

            if (resultadoValidacaoComplemento == true)
            {
                Console.Clear();

                ControllerCliente.AlteraComplemento(TelaOpcoesAlteracaoCliente.CpfInformado, complementoInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Complemento inválida!");

                RecebeComplemento();
            }
        }

        internal static void RecebeCep()
        {
            Console.WriteLine("\n ================================================== CEP (Somente números)");

            string cepInformado;

            Console.Write("\n ");

            cepInformado = Console.ReadLine();

            bool resultadoValidacaoCep = ControllerEndereco.ValidaCepInformado(cepInformado);

            if (resultadoValidacaoCep == true)
            {
                Console.Clear();

                ControllerCliente.AlteraCep(TelaOpcoesAlteracaoCliente.CpfInformado, cepInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cep inválido!");

                RecebeCep();
            }
        }

        internal static void RecebeStatus()
        {
            Console.WriteLine("\n ================================================== Status");

            Console.WriteLine("\n 1 - Ativo");
            Console.WriteLine(" 2 - Inativo");

            int opcaoStatusInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoStatusInformada);

            bool resultadoValidacaoStatus = ControllerUsuario.ValidaStatusInformado(opcaoStatusInformada);

            if (resultadoValidacaoStatus == true)
            {
                Console.Clear();

                ControllerCliente.AlteraStatus(TelaOpcoesAlteracaoCliente.CpfInformado, opcaoStatusInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuCliente.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }
    }
}
