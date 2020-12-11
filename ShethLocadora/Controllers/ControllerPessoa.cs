using ShethLocadora.Models.Enums;
using System;
using System.Text.RegularExpressions;

namespace ShethLocadora.Controllers
{
    static class ControllerPessoa
    {
        internal static string nome;
        internal static DateTime dataNascimento = new DateTime();
        internal static EnumSexoPessoa sexo;
        internal static string cpf;
        internal static string email;
        internal static string numeroCelular;

        // ================================================== CADASTRAR

        internal static bool ValidaNome(string nomeInformado)
        {
            Regex regexNome = new Regex(@"^(?<PrimeiroNome>[a-zA-Z]){1,}(?<EspacoEntreNomes>\s)(?<OutrosNomes>[a-zA-Z]\s?){1,}$");

            if (nomeInformado.Length >= 5 && regexNome.IsMatch(nomeInformado))
            {
                nome = nomeInformado.ToUpper();

                return true;
            }

            return false;
        }

        internal static bool ValidaDataNascimento(string dataNascimentoInformada)
        {
            DateTime dataValidar;
            DateTime.TryParse(dataNascimentoInformada, out dataValidar);

            if (DateTime.TryParse(dataNascimentoInformada, out dataNascimento))
            {
                return true;
            }

            return false;
        }

        internal static bool ValidaSexo(int opcaoSexoInformada)
        {
            if (opcaoSexoInformada >= 1 && opcaoSexoInformada <= 2)
            {
                sexo = (EnumSexoPessoa)opcaoSexoInformada;

                return true;
            }

            return false;
        }

        internal static bool ValidaCpf(string cpfInformado)
        {
            Regex regexCpf = new Regex(@"^(?<SomenteNumeros>[0-9]){11}$");

            if (regexCpf.IsMatch(cpfInformado))
            {
                cpf = cpfInformado.ToUpper();

                return true;
            }

            return false;
        }

        internal static bool ValidaEmail(string emailInformado)
        {
            Regex regexEmail = new Regex(@"^(?<AntesDeArrouba>[\w\.?\-?]){1,}(?<Arrouba>\@)(?<Dominio>[\w^_]){1,}(?<Ponto>\.)(?<TipoDeDominio>[\w^_]){1,}(?<IdentificacaoPais>[\.\w^_])*$");

            if (regexEmail.IsMatch(emailInformado))
            {
                email = emailInformado.ToUpper();

                return true;
            }

            return false;
        }

        internal static bool ValidaNumeroCelular(string numeroCelularInformado)
        {
            Regex regexNumeroCelular = new Regex(@"^(?<DDD>[\d]){2}(?<DemaisNumeros>[\d]){8,9}$");

            if (regexNumeroCelular.IsMatch(numeroCelularInformado))
            {
                numeroCelular = numeroCelularInformado;

                return true;
            }

            return false;

        }
    }
}
