using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Repositories;
using System;
using System.Linq;

namespace ShethLocadora.Controllers
{
    static class ControllerCliente
    {
        // ================================================== CADASTRAR

        private static int _id;
        private static bool _status;

        internal static bool ValidaStatusInformado(int opcaoStatusInformada)
        {
            if (opcaoStatusInformada == 1)
            {
                _status = true;

                return true;
            }

            if (opcaoStatusInformada == 2)
            {
                _status = false;

                return true;
            }

            return false;
        }

        internal static bool FinalizaCadastro()
        {
            if (BancoDados.Clientes.Count == 0)
            {
                _id = 1;
            }
            else
            {
                foreach (var item in BancoDados.Clientes)
                {
                    if (_id <= item.Id)
                    {
                        _id = item.Id + 1;
                    }
                }
            }

            Endereco endereco = new Endereco(ControllerEndereco.unidadeFederativa, ControllerEndereco.cidade, ControllerEndereco.bairro, ControllerEndereco.logradouro, ControllerEndereco.complemento,
                ControllerEndereco.cep);

            Cliente cliente = new Cliente(ControllerPessoa.nome, ControllerPessoa.dataNascimento, ControllerPessoa.sexo, ControllerPessoa.cpf, ControllerPessoa.email, ControllerPessoa.numeroCelular, _id,
                endereco, _status);

            bool clienteDuplicado = false;

            foreach (var item in BancoDados.Clientes)
            {
                if (item.GetHashCode() == cliente.GetHashCode() && item.Equals(cliente))
                {
                    clienteDuplicado = true;
                }
            }

            if (clienteDuplicado == false)
            {
                BancoDados.Clientes.Add(cliente);

                return true;
            }

            return false;
        }

        // ================================================== CONSULTAR

        internal static void ListaTodos()
        {
            foreach (var item in BancoDados.Clientes)
            {
                ExibeModeloListagem(item);
            }
        }

        internal static void ConsultaId(int IdInformado)
        {
            ConsultaGeral(id: IdInformado);
        }

        internal static void ConsultaCpf(string cpfInformado)
        {
            ConsultaGeral(cpf: cpfInformado);
        }

        internal static void ListaNome(string nomeInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Nome.Contains(nomeInformado.ToUpper()) && !string.IsNullOrWhiteSpace(nomeInformado)))
            {
                ExibeModeloListagem(item);
            }
        }

        private static void ConsultaGeral(int id = 0, string cpf = null)
        {
            if (id > 0)
            {
                foreach (var item in BancoDados.Clientes.Where(x => x.Id == id))
                {
                    Console.WriteLine(item);
                }
            }

            if (cpf != null)
            {
                foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpf.ToUpper()))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void ExibeModeloListagem(Cliente item)
        {
            Console.WriteLine(" ID: " + item.Id);
            Console.WriteLine(" Nome: " + item.Nome);
            Console.WriteLine(" CPF: " + item.Cpf + "\n");
        }

        // ================================================== ALTERAR

        internal static void AlteraNome(string cpfInformado, string nomeInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Nome = nomeInformado.ToUpper();
            }
        }

        internal static void AlteraDataNascimento(string cpfInformado, string dataNascimentoInformada)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.DataNascimento = DateTime.Parse(dataNascimentoInformada);
            }
        }

        internal static void AlteraSexo(string cpfInformado, int opcaoSexoInformada)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Sexo = (EnumSexoPessoa)opcaoSexoInformada;
            }
        }

        internal static void AlteraCpf(string cpfInformadoBusca, string cpfInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Cpf = cpfInformado.ToUpper();
            }
        }

        internal static void AlteraEmail(string cpfInformado, string emailInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Email = emailInformado.ToUpper();
            }
        }

        internal static void AlteraNumeroCelular(string cpfInformado, string numeroCelularInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.NumeroCelular = numeroCelularInformado.ToUpper();
            }
        }

        internal static void AlteraUnidadeFederativa(string cpfInformado, int opcaoUnidadeFederativaInformada)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.UnidadeFederativa = (EnumUnidadeFederativaEndereco)opcaoUnidadeFederativaInformada;
            }
        }

        internal static void AlteraCidade(string cpfInformado, string cidadeInformada)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Cidade = cidadeInformada.ToUpper();
            }
        }

        internal static void AlteraBairro(string cpfInformado, string bairroInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Bairro = bairroInformado.ToUpper();
            }
        }

        internal static void AlteraLogradouro(string cpfInformado, string logradouroInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Logradouro = logradouroInformado.ToUpper();
            }
        }

        internal static void AlteraComplemento(string cpfInformado, string complementoInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Complemento = complementoInformado.ToUpper();
            }
        }

        internal static void AlteraCep(string cpfInformado, string cepInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Cep = cepInformado.ToUpper();
            }
        }

        internal static void AlteraStatus(string cpfInformado, int opcaoStatusInformada)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                if (opcaoStatusInformada == 1)
                {
                    item.Status = true;
                }
                else
                {
                    item.Status = false;
                }
            }
        }

        // ================================================== EXCLUIR

        public static void ExcluiCliente(string cpfInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                BancoDados.Clientes.Remove(item);
            }
        }
    }
}
