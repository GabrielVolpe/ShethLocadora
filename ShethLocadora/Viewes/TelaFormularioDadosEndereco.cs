using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioDadosEndereco
    {
        internal static Tuple<bool, int> RecebeUnidadeFederativa()
        {
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" [Unidade federativa]:");
            Console.ResetColor();

            int contadorUnidadeFederativa = 1;

            foreach (var opcaoEnum in Enum.GetValues(typeof(EnumUnidadeFederativaEndereco)))
            {
                Console.WriteLine($" [{contadorUnidadeFederativa}] - {opcaoEnum}");

                contadorUnidadeFederativa++;
            }

            int opcaoUnidadeFederativaInformada = UtilitariosGlobais.RecebeDadoCadastroIntEnum("\n [Opção]: ");

            bool resultadoValidacaoUnidadeFederativa = ControllerEndereco.ValidaUnidadeFederativa(opcaoUnidadeFederativaInformada);

            return new Tuple<bool, int>(resultadoValidacaoUnidadeFederativa, opcaoUnidadeFederativaInformada);
        }

        internal static Tuple<bool, string> RecebeCidade()
        {
            Console.WriteLine();

            string cidadeInformada = UtilitariosGlobais.RecebeDadoCadastroString(" [Cidade]:");

            bool resultadoValidacaoCidade = ControllerEndereco.ValidaCidadeInformada(cidadeInformada);

            return new Tuple<bool, string>(resultadoValidacaoCidade, cidadeInformada);
        }

        internal static Tuple<bool, string> RecebeBairro()
        {
            Console.WriteLine();

            string bairroInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Bairro]:");

            bool resultadoValidacaoBairro = ControllerEndereco.ValidaBairroInformado(bairroInformado);

            return new Tuple<bool, string>(resultadoValidacaoBairro, bairroInformado);
        }

        internal static Tuple<bool, string> RecebeLogradouro()
        {
            Console.WriteLine();

            string logradouroInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Logradouro]:");

            bool resultadoValidacaoLogradouro = ControllerEndereco.ValidaLogradouroInformado(logradouroInformado);

            return new Tuple<bool, string>(resultadoValidacaoLogradouro, logradouroInformado);
        }

        internal static Tuple<bool, string> RecebeComplemento()
        {
            Console.WriteLine();

            string complementoInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [Complemento]:");

            bool resultadoValidacaoComplemento = ControllerEndereco.ValidaComplementoInformado(complementoInformado);

            return new Tuple<bool, string>(resultadoValidacaoComplemento, complementoInformado);
        }

        internal static Tuple<bool, string> RecebeCep()
        {
            Console.WriteLine();

            string cepInformado = UtilitariosGlobais.RecebeDadoCadastroString(" [CEP (Somente números)]:");

            bool resultadoValidacaoCep = ControllerEndereco.ValidaCepInformado(cepInformado);

            return new Tuple<bool, string>(resultadoValidacaoCep, cepInformado);
        }
    }
}
