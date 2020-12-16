using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Repositories;
using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
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

            if (opcaoStatusInformada == 2)
            {
                _status = false;

                return true;
            }

            return false;
        }

        internal static bool ValidaPermissaoInformada(int permissaoInformada)
        {
            if (permissaoInformada == 1)
            {
                _permissao = 1;

                return true;
            }

            if (permissaoInformada == 2)
            {
                _permissao = 2;

                return true;
            }

            return false;
        }

        internal static bool ValidaUsuarioAutenticacao(string usuarioAutenticacaoInformado)
        {
            if (usuarioAutenticacaoInformado.Length >= 3 && !string.IsNullOrWhiteSpace(usuarioAutenticacaoInformado))
            {
                _usuarioAutenticacao = usuarioAutenticacaoInformado;

                return true;
            }

            return false;
        }

        internal static bool ValidaSenhaAutenticacao(string senhaoAutenticacaoInformada)
        {
            if (senhaoAutenticacaoInformada.Length >= 3 && !string.IsNullOrWhiteSpace(senhaoAutenticacaoInformada))
            {
                _senhaAutenticacao = senhaoAutenticacaoInformada;

                return true;
            }

            return false;
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

            return false;
        }

        // ================================================== CONSULTAR

        private static int _contador;

        internal static void ListaTodos()
        {
            _contador = 4;

            foreach (var item in BancoDados.Usuarios)
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ListaNome(string nomeInformado)
        {
            _contador = 4;

            foreach (var item in BancoDados.Usuarios.Where(x => x.Nome.Contains(nomeInformado.ToUpper()) && !string.IsNullOrWhiteSpace(nomeInformado)))
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ConsultaId(int idInformado)
        {
            ConsultaGeral(idInformado);
        }

        internal static void ConsultaCpf(string cpfInformado)
        {
            ConsultaGeral(cpf: cpfInformado);
        }

        private static void ConsultaGeral(int id = 0, string cpf = null)
        {
            if (id > 0)
            {
                foreach (var item in BancoDados.Usuarios.Where(x => x.Id == id))
                {
                    ExibeModeloConsulta(item);
                }
            }

            if (cpf != null)
            {
                foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpf.ToUpper()))
                {
                    ExibeModeloConsulta(item);
                }
            }
        }

        private static void ExibeModeloConsulta(Usuario item)
        {
            UtilitariosGlobais.ApresentaCabecalhoAzulEscuro(" [DADOS DO USUÁRIO]");
            TelaSemTitulo.GeraTela(80, 16, 0, 6);

            Console.SetCursorPosition(0, 6);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(item);
            Console.ResetColor();
        }

        private static void ExibeModeloListagem(Usuario item, int linha)
        {
            for (int i = 0; i <= 79; i++)
            {
                for (int j = 0; j <= linha; j++)
                {
                    Console.SetCursorPosition(0 + i, 1 + j);

                    // Linha superior
                    if (Console.CursorTop == 1)
                    {
                        Console.Write("=");
                    }

                    // Coluna esquerda
                    if (Console.CursorLeft == 0)
                    {
                        Console.Write("|");
                    }

                    if (Console.CursorLeft == 8)
                    {
                        Console.Write("|");
                    }

                    if (Console.CursorLeft == 64)
                    {
                        Console.Write("|");
                    }

                    // Coluna direita
                    if (Console.CursorLeft == 79)
                    {
                        Console.Write("|");
                    }
                }
            }

            Console.SetCursorPosition(1, 2);
            UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro("[ID]   ");
            Console.SetCursorPosition(1, linha);
            if (item.Status == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(item.Id);
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(item.Id);
                Console.ResetColor();
            }

            Console.SetCursorPosition(9, 2);
            UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro("[NOME]                                                 ");
            Console.SetCursorPosition(9, linha);
            Console.WriteLine(item.Nome);

            Console.SetCursorPosition(65, 2);
            UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro("[CPF]         ");
            Console.SetCursorPosition(65, linha);
            Console.WriteLine(item.Cpf);
        }

        // ================================================== ALTERAR

        internal static void AlteraNome(string cpfInformado, string nomeInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Nome = nomeInformado.ToUpper();
            }
        }

        internal static void AlteraDataNascimento(string cpfInformado, string dataNascimentoInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.DataNascimento = DateTime.Parse(dataNascimentoInformada);
            }
        }

        internal static void AlteraSexo(string cpfInformado, int opcaoSexoInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Sexo = (EnumSexoPessoa)opcaoSexoInformada;
            }
        }

        internal static void AlteraCpf(string cpfInformadoBusca, string cpfInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Cpf = cpfInformado.ToUpper();
            }
        }

        internal static void AlteraEmail(string cpfInformado, string emailInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Email = emailInformado.ToUpper();
            }
        }

        internal static void AlteraNumeroCelular(string cpfInformado, string numeroCelularInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.NumeroCelular = numeroCelularInformado.ToUpper();
            }
        }

        internal static void AlteraUnidadeFederativa(string cpfInformado, int opcaoUnidadeFederativaInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.UnidadeFederativa = (EnumUnidadeFederativaEndereco)opcaoUnidadeFederativaInformada;
            }
        }

        internal static void AlteraCidade(string cpfInformado, string cidadeInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Cidade = cidadeInformada.ToUpper();
            }
        }

        internal static void AlteraBairro(string cpfInformado, string bairroInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Bairro = bairroInformado.ToUpper();
            }
        }

        internal static void AlteraLogradouro(string cpfInformado, string logradouroInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Logradouro = logradouroInformado.ToUpper();
            }
        }

        internal static void AlteraComplemento(string cpfInformado, string complementoInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Complemento = complementoInformado.ToUpper();
            }
        }

        internal static void AlteraCep(string cpfInformado, string cepInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Endereco.Cep = cepInformado.ToUpper();
            }
        }

        internal static void AlteraStatus(string cpfInformado, int opcaoStatusInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
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

        internal static void AlteraPermissao(string cpfInformado, int opcaoPermissaoInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Permissao = opcaoPermissaoInformada;
            }
        }

        internal static void AlteraUsuarioAutenticacao(string cpfInformado, string usuarioAutenticacaoInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.UsuarioAutenticacao = usuarioAutenticacaoInformado;
            }
        }

        internal static void AlteraSenhaAutenticacao(string cpfInformado, string senhaAutenticacaoInformada)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.SenhaAutenticacao = senhaAutenticacaoInformada;
            }
        }

        // ================================================== EXCLUIR

        public static void ExcluiUsuario(string cpfInformado)
        {
            foreach (var item in BancoDados.Usuarios.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                BancoDados.Usuarios.Remove(item);
            }
        }
    }
}
