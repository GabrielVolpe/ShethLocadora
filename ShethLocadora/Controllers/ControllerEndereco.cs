using ShethLocadora.Models.Enums;
using System.Text.RegularExpressions;

namespace ShethLocadora.Controllers
{
    static class ControllerEndereco
    {
        internal static EnumUnidadeFederativaEndereco unidadeFederativa;
        internal static string cidade;
        internal static string bairro;
        internal static string logradouro;
        internal static string complemento;
        internal static string cep;

        // ================================================== CADASTRAR

        internal static bool ValidaUnidadeFederativa(int opcaoUnidadeFederativaInformada)
        {
            if (opcaoUnidadeFederativaInformada >= 1 && opcaoUnidadeFederativaInformada <= 27)
            {
                unidadeFederativa = (EnumUnidadeFederativaEndereco)opcaoUnidadeFederativaInformada;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaCidadeInformada(string cidadeInformada)
        {
            Regex regexCidade = new Regex(@"^(?<Nome>[\w^_]){1,}(?<Espaco>\s)?(?<Nome>[\w^_]\s?)*$");

            if (cidadeInformada.Length >= 2 && regexCidade.IsMatch(cidadeInformada))
            {
                cidade = cidadeInformada.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaBairroInformado(string bairroInformado)
        {
            Regex regexBairro = new Regex(@"^(?<Nome>[\w^_]){1,}(?<Espaco>\s)?(?<Nome>[\w^_]\s?)*$");

            if (bairroInformado.Length >= 2 && regexBairro.IsMatch(bairroInformado))
            {
                bairro = bairroInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaLogradouroInformado(string logradouroInformado)
        {
            Regex regexLogradouro = new Regex(@"^(?<Nome>[\w^_\,?\-?\/?]){1,}(?<Espaco>\s)?(?<Nome>[\w^_\,?\-?\/?]\s?)*$");

            if (logradouroInformado.Length >= 2 && regexLogradouro.IsMatch(logradouroInformado))
            {
                logradouro = logradouroInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaComplementoInformado(string complementoInformado)
        {
            Regex regexComplemento = new Regex(@"^(?<Complemento>[\w^_\,?\-?\/?])*(?<Espaco>\s?)(?<Complemento>[\w^_\,?\-?\/?]\s?)*$");

            if (regexComplemento.IsMatch(complementoInformado))
            {
                complemento = complementoInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaCepInformado(string cepInformado)
        {
            Regex regexCep = new Regex(@"^(?<Cep>\d){8}$");

            if (regexCep.IsMatch(cepInformado))
            {
                cep = cepInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
