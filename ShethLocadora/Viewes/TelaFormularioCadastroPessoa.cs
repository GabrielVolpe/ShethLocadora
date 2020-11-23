using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioCadastroPessoa
    {
        internal static void RecebeNome()
        {
            Console.WriteLine("\n ================================================== Nome Completo (Sem acentos)");

            string nomeInformado;

            Console.Write("\n ");

            nomeInformado = Console.ReadLine();

            bool resultadoValidacaoNome = ControllerPessoa.ValidaNome(nomeInformado);

            if (resultadoValidacaoNome == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Nome inválido!");

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

            if (resultadoValidacaoDataNascimento == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Data inválida!");

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

            if (resultadoValidacaoSexo == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Opção inválida!");

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

            if (resultadoValidacaoCpf == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Cpf inválido!");

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

            if (resultadoValidacaoEmail == false)
            {
                FuncoesTexto.ApresentaMensagemErro("E-mail inválido!");

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

            if (resultadoValidacaoNumeroCelular == false)
            {
                FuncoesTexto.ApresentaMensagemErro("Número de celular inválido!");

                RecebeNumeroCelular();
            }
        }
    }
}
