using ShethLocadora.Controllers;
using ShethLocadora.Models.Enums;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaFormularioCadastroEndereco
    {
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

            if (resultadoValidacaoUnidadeFederativa == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

                RecebeUnidadeFederativa();
            }
        }

        internal static void RecebeCidade()
        {
            Console.WriteLine("\n ================================================== Cidade (Sem acentos)");

            string cidadeInformada;

            Console.Write("\n ");

            cidadeInformada = Console.ReadLine();

            bool resultadoValidacaoCidade = ControllerEndereco.ValidaCidadeInformada(cidadeInformada);

            if (resultadoValidacaoCidade == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Cidade inválida!");

                RecebeCidade();
            }
        }

        internal static void RecebeBairro()
        {
            Console.WriteLine("\n ================================================== Bairro (Sem acentos)");

            string bairroInformado;

            Console.Write("\n ");

            bairroInformado = Console.ReadLine();

            bool resultadoValidacaoBairro = ControllerEndereco.ValidaBairroInformado(bairroInformado);

            if (resultadoValidacaoBairro == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Bairro inválido!");

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

            if (resultadoValidacaoLogradouro == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Logradouro inválido!");

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

            if (resultadoValidacaoComplemento == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("Complemento inválido!");

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

            if (resultadoValidacaoCep == false)
            {
                UtilitariosGlobais.ApresentaMensagemErro("CEP inválido!");

                RecebeCep();
            }
        }
    }
}
