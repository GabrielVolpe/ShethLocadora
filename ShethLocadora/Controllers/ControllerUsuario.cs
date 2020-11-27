using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Repositories;
using System;
using System.Linq;

namespace ShethLocadora.Controllers
{
    static class ControllerUsuario
    {
        // ================================================== CADASTRAR

        private static int _id;
        private static bool _status;
        private static int _permissao;
        private static string _usuarioAutenticacao;
        private static string _senhaAutenticacao;

        internal static bool ValidaStatusInformado(int opcaoStatusInformada)
        {
            if (opcaoStatusInformada == 1)
            {
                _status = true;

                return true;
            }
            else if (opcaoStatusInformada == 2)
            {
                _status = false;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaPermissaoInformada(int permissaoInformada)
        {
            if (permissaoInformada == 1)
            {
                _permissao = 1;

                return true;
            }
            else if (permissaoInformada == 2)
            {
                _permissao = 2;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaUsuarioAutenticacao(string usuarioAutenticacaoInformado)
        {
            if (usuarioAutenticacaoInformado.Length >= 3 && !string.IsNullOrWhiteSpace(usuarioAutenticacaoInformado))
            {
                _usuarioAutenticacao = usuarioAutenticacaoInformado;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaSenhaAutenticacao(string senhaoAutenticacaoInformada)
        {
            if (senhaoAutenticacaoInformada.Length >= 3 && !string.IsNullOrWhiteSpace(senhaoAutenticacaoInformada))
            {
                _senhaAutenticacao = senhaoAutenticacaoInformada;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool FinalizaCadastro()
        {
            if (BancoDados.Usuarios.Count == 0)
            {
                _id = 1;
            }
            else
            {
                foreach (var item in BancoDados.Usuarios)
                {
                    if (_id <= item.Id)
                    {
                        _id = item.Id + 1;
                    }
                }
            }

            Endereco endereco = new Endereco(ControllerEndereco.unidadeFederativa, ControllerEndereco.cidade, ControllerEndereco.bairro, ControllerEndereco.logradouro, ControllerEndereco.complemento,
                ControllerEndereco.cep);

            Usuario usuario = new Usuario(ControllerPessoa.nome, ControllerPessoa.dataNascimento, ControllerPessoa.sexo, ControllerPessoa.cpf, ControllerPessoa.email, ControllerPessoa.numeroCelular, _id,
                _status, _permissao, endereco, _usuarioAutenticacao, _senhaAutenticacao);

            bool usuarioDuplicado = false;

            foreach (var item in BancoDados.Usuarios)
            {
                if (item.GetHashCode() == usuario.GetHashCode() && item.Equals(usuario))
                {
                    usuarioDuplicado = true;
                }
            }

            if (usuarioDuplicado == false)
            {
                BancoDados.Usuarios.Add(usuario);

                return true;
            }
            else
            {
                return false;
            }
        }

        // ================================================== CONSULTAR

        internal static void ListaTodos()
        {
            foreach (var item in BancoDados.Usuarios)
            {
                Console.WriteLine(item);
            }
        }

        internal static void ConsultaId(int idInformado)
        {
            var usuariosPorId =
                from x in BancoDados.Usuarios
                where x.Id == idInformado
                select x;

            foreach (var item in usuariosPorId)
            {
                Console.WriteLine(item);
            }
        }

        internal static void ConsultaCpf(string cpfInformado)
        {
            var usuariosPorCpf =
                from x in BancoDados.Usuarios
                where x.Cpf == cpfInformado
                select x;

            foreach (var item in usuariosPorCpf)
            {
                Console.WriteLine(item);
            }
        }

        internal static void ConsultaNome(string nomeInformado)
        {
            var usuariosPorNome =
                from x in BancoDados.Usuarios
                where x.Nome.Contains(nomeInformado)
                select x;

            foreach (var item in usuariosPorNome)
            {
                Console.WriteLine(item);
            }
        }

        // ================================================== ALTERAR

        internal static void AlteraNome(string cpfInformado, string nomeInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Nome = nomeInformado.ToUpper();
                }
            }
        }

        internal static void AlteraDataNascimento(string cpfInformado, string dataNascimentoInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.DataNascimento = DateTime.Parse(dataNascimentoInformada);
                }
            }
        }

        internal static void AlteraSexo(string cpfInformado, int opcaoSexoInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Sexo = (EnumSexoPessoa)opcaoSexoInformada;
                }
            }
        }

        internal static void AlteraCpf(string cpfInformadoBusca, string cpfInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformadoBusca)
                {
                    item.Cpf = cpfInformado.ToUpper();
                }
            }
        }

        internal static void AlteraEmail(string cpfInformado, string emailInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Email = emailInformado.ToUpper();
                }
            }
        }

        internal static void AlteraNumeroCelular(string cpfInformado, string numeroCelularInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.NumeroCelular = numeroCelularInformado.ToUpper();
                }
            }
        }

        internal static void AlteraUnidadeFederativa(string cpfInformado, int opcaoUnidadeFederativaInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.UnidadeFederativa = (EnumUnidadeFederativaEndereco)opcaoUnidadeFederativaInformada;
                }
            }
        }

        internal static void AlteraCidade(string cpfInformado, string cidadeInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.Cidade = cidadeInformada.ToUpper();
                }
            }
        }

        internal static void AlteraBairro(string cpfInformado, string bairroInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.Bairro = bairroInformado.ToUpper();
                }
            }
        }

        internal static void AlteraLogradouro(string cpfInformado, string logradouroInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.Logradouro = logradouroInformado.ToUpper();
                }
            }
        }

        internal static void AlteraComplemento(string cpfInformado, string complementoInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.Complemento = complementoInformado.ToUpper();
                }
            }
        }

        internal static void AlteraCep(string cpfInformado, string cepInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Endereco.Cep = cepInformado.ToUpper();
                }
            }
        }

        internal static void AlteraStatus(string cpfInformado, int opcaoStatusInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
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
        }

        internal static void AlteraPermissao(string cpfInformado, int opcaoPermissaoInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.Permissao = opcaoPermissaoInformada;
                }
            }
        }

        internal static void AlteraUsuarioAutenticacao(string cpfInformado, string usuarioAutenticacaoInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.UsuarioAutenticacao = usuarioAutenticacaoInformado;
                }
            }
        }

        internal static void AlteraSenhaAutenticacao(string cpfInformado, string senhaAutenticacaoInformada)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    item.SenhaAutenticacao = senhaAutenticacaoInformada;
                }
            }
        }

        // ================================================== EXCLUIR

        public static void ExcluiUsuario(string cpfInformado)
        {
            foreach (var item in BancoDados.Usuarios.ToArray())
            {
                if (item.Cpf == cpfInformado)
                {
                    BancoDados.Usuarios.Remove(item);
                }
            }
        }
    }
}
