using ShethLocadora.Models.Enums;
using System;
using System.Text;

namespace ShethLocadora.Models
{
    class Endereco
    {
        public EnumUnidadeFederativaEndereco UnidadeFederativa { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public Endereco()
        {

        }

        public Endereco(EnumUnidadeFederativaEndereco unidadeFederativa, string cidade, string bairro, string logradouro, string complemento, string cep)
        {
            UnidadeFederativa = unidadeFederativa;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Complemento = complemento;
            Cep = cep;
        }

        public override string ToString()
        {
            StringBuilder stringEndereco = new StringBuilder();

            stringEndereco.AppendLine(" Unidade Federativa: " + UnidadeFederativa);
            stringEndereco.AppendLine(" Cidade............: " + Cidade);
            stringEndereco.AppendLine(" Bairro............: " + Bairro);
            stringEndereco.AppendLine(" Logradouro........: " + Logradouro);
            stringEndereco.AppendLine(" Complemento.......: " + Complemento);
            stringEndereco.Append(" CEP...............: " + Cep);

            return stringEndereco.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Endereco endereco &&
                   UnidadeFederativa == endereco.UnidadeFederativa &&
                   Cidade == endereco.Cidade &&
                   Bairro == endereco.Bairro &&
                   Logradouro == endereco.Logradouro &&
                   Complemento == endereco.Complemento &&
                   Cep == endereco.Cep;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UnidadeFederativa, Cidade, Bairro, Logradouro, Complemento, Cep);
        }
    }
}
