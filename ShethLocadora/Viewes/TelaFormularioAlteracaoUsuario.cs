using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioAlteracaoUsuario
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

                ControllerUsuario.AlteraNome(TelaOpcoesAlteracaoUsuario.CpfInformado, nomeInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraDataNascimento(TelaOpcoesAlteracaoUsuario.CpfInformado, dataNascimentoInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraSexo(TelaOpcoesAlteracaoUsuario.CpfInformado, opcaoSexoInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraCpf(TelaOpcoesAlteracaoUsuario.CpfInformado, cpfInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraEmail(TelaOpcoesAlteracaoUsuario.CpfInformado, emailInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraNumeroCelular(TelaOpcoesAlteracaoUsuario.CpfInformado, numeroCelularInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraUnidadeFederativa(TelaOpcoesAlteracaoUsuario.CpfInformado, opcaoUnidadeFederativaInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraCidade(TelaOpcoesAlteracaoUsuario.CpfInformado, cidadeInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraBairro(TelaOpcoesAlteracaoUsuario.CpfInformado, bairroInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraLogradouro(TelaOpcoesAlteracaoUsuario.CpfInformado, logradouroInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraComplemento(TelaOpcoesAlteracaoUsuario.CpfInformado, complementoInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraCep(TelaOpcoesAlteracaoUsuario.CpfInformado, cepInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
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

                ControllerUsuario.AlteraStatus(TelaOpcoesAlteracaoUsuario.CpfInformado, opcaoStatusInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeStatus();
            }
        }

        internal static void RecebePermissao()
        {
            Console.WriteLine("\n ================================================== Permissão");

            Console.WriteLine("\n 1 - Administrador");
            Console.WriteLine(" 2 - Operador");

            int opcaoPermissaoInformada;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoPermissaoInformada);

            bool resultadoValidacaoPermissao = ControllerUsuario.ValidaPermissaoInformada(opcaoPermissaoInformada);

            if (resultadoValidacaoPermissao == true)
            {
                Console.Clear();

                ControllerUsuario.AlteraPermissao(TelaOpcoesAlteracaoUsuario.CpfInformado, opcaoPermissaoInformada);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebePermissao();
            }
        }

        internal static void RecebeUsuarioAutenticacao()
        {
            Console.WriteLine("\n ================================================== Usuário de autenticação");

            string usuarioAutenticacaoInformado;

            Console.Write("\n ");

            usuarioAutenticacaoInformado = Console.ReadLine();

            bool resultadoValidacaoUsuarioAutenticacao = ControllerUsuario.ValidaUsuarioAutenticacao(usuarioAutenticacaoInformado);

            if (resultadoValidacaoUsuarioAutenticacao == true)
            {
                Console.Clear();

                ControllerUsuario.AlteraUsuarioAutenticacao(TelaOpcoesAlteracaoUsuario.CpfInformado, usuarioAutenticacaoInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Usuário inválido!");

                RecebeUsuarioAutenticacao();
            }
        }

        internal static void RecebeSenhaAutenticacao()
        {
            Console.WriteLine("\n ================================================== Senha de autenticação");

            string senhaAutenticacaoInformado;

            Console.Write("\n ");

            senhaAutenticacaoInformado = Console.ReadLine();

            bool resultadoValidacaoSenhaAutenticacao = ControllerUsuario.ValidaSenhaAutenticacao(senhaAutenticacaoInformado);

            if (resultadoValidacaoSenhaAutenticacao == true)
            {
                Console.Clear();

                ControllerUsuario.AlteraSenhaAutenticacao(TelaOpcoesAlteracaoUsuario.CpfInformado, senhaAutenticacaoInformado);

                UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

                TelaMenuUsuario.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro("Senha inválido!");

                RecebeSenhaAutenticacao();
            }
        }
    }
}
