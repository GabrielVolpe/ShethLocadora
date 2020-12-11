using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioDadosPessoa
    {
        internal static Tuple<bool, string> RecebeNome()
        {
            Console.WriteLine();

            string nomeInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Nome completo]:");

            bool resultadoValidacaoNome = ControllerPessoa.ValidaNome(nomeInformado);

            return new Tuple<bool, string>(resultadoValidacaoNome, nomeInformado);
        }

        internal static Tuple<bool, string> RecebeDataNascimento()
        {
            Console.WriteLine();

            string dataNascimentoInformada = UtilitariosGlobais.RecebeDadoCadastroString(" [Data de Nascimento (Dia/Mês/Ano)]:");

            bool resultadoValidacaoDataNascimento = ControllerPessoa.ValidaDataNascimento(dataNascimentoInformada);

            return new Tuple<bool, string>(resultadoValidacaoDataNascimento, dataNascimentoInformada);
        }

        internal static Tuple<bool, int> RecebeSexo()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Sexo]:");
            Console.ResetColor();

            int contadorSexoPessoa = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumSexoPessoa)))
            {
                Console.WriteLine($" [{contadorSexoPessoa}] - {opcaoEnum}");

                contadorSexoPessoa++;
            }

            int opcaoSexoInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]: ");

            bool resultadoValidacaoSexo = ControllerPessoa.ValidaSexo(opcaoSexoInformada);

            return new Tuple<bool, int>(resultadoValidacaoSexo, opcaoSexoInformada);
        }

        internal static Tuple<bool, string> RecebeCpf()
        {
            Console.WriteLine();

            string cpfInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [CPF (Somente números)]:");

            bool resultadoValidacaoCpf = ControllerPessoa.ValidaCpf(cpfInformado);

            return new Tuple<bool, string>(resultadoValidacaoCpf, cpfInformado);
        }

        internal static Tuple<bool, string> RecebeEmail()
        {
            Console.WriteLine();

            string emailInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [E-mail]:");

            bool resultadoValidacaoEmail = ControllerPessoa.ValidaEmail(emailInformado);

            return new Tuple<bool, string>(resultadoValidacaoEmail, emailInformado);
        }

        internal static Tuple<bool, string> RecebeNumeroCelular()
        {
            Console.WriteLine();

            string numeroCelularInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Celular (DDD+Numero - Somente Numeros)]:");

            bool resultadoValidacaoNumeroCelular = ControllerPessoa.ValidaNumeroCelular(numeroCelularInformado);

            return new Tuple<bool, string>(resultadoValidacaoNumeroCelular, numeroCelularInformado);
        }
    }
}
