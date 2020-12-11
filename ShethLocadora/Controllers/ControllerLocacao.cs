using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Utilities;
using ShethLocadora.ViewsNew;
using System;
using System.Linq;

namespace ShethLocadora.Controllers
{
    static class ControllerLocacao
    {
        private static int _id = 1;

        private static int _idFilme;
        private static bool _statusFilme;
        private static string _titulo;
        private static string _diretor;
        private static EnumCategoriaFilme _categoriaFilme;
        private static EnumClassificacaoIndicativaFilme _classificacaoIndicativa;
        private static double _valorLocacao;
        private static int _periodoDiasLocacao;
        private static int _quantidadeDisponivel;

        private static int _IdCliente;
        private static string _nome;
        private static DateTime _dataNascimento;
        private static EnumSexoPessoa _sexo;
        private static string _cpf;
        private static string _email;
        private static string _numeroCelular;
        private static Endereco _endereco;
        private static bool _statusCliente;

        // ================================================== LOCAR

        internal static bool VerificaStatusFilme(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado))
            {
                if (item.Status == true)
                {
                    return true;
                }
            }

            return false;
        }

        internal static int VerificaQuantidadeDisponivelFilme(int idInformado)
        {
            int quantidadeDisponivel = 0;

            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado))
            {
                quantidadeDisponivel = item.QuantidadeDisponivel;
            }

            return quantidadeDisponivel;
        }

        internal static bool VerificaStatusCliente(string cpfInformado)
        {
            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado))
            {
                if (item.Status == true)
                {
                    return true;
                }
            }

            return false;
        }

        internal static void ConcluiLocacao(int idInformado, string cpfInformado)
        {

            if (BancoDados.Locacoes.Count == 0)
            {
                _id = 1;
            }
            else
            {
                foreach (var item in BancoDados.Locacoes)
                {
                    if (_id <= item.Id)
                    {
                        _id = item.Id + 1;
                    }
                }
            }

            for (int i = 0; i < BancoDados.Filmes.Count; i++)
            {
                var item = BancoDados.Filmes[i];

                if (item.Id == idInformado)
                {
                    _idFilme = item.Id;
                    _statusFilme = item.Status;
                    _titulo = item.Titulo;
                    _diretor = item.Diretor;
                    _categoriaFilme = item.Categoria;
                    _classificacaoIndicativa = item.ClassificacaoIndicativa;
                    _valorLocacao = item.ValorLocacao;
                    _periodoDiasLocacao = item.PeriodoDiasLocacao;
                    _quantidadeDisponivel = item.QuantidadeDisponivel;

                    item.QuantidadeDisponivel -= 1;

                    if (item.QuantidadeDisponivel == 0)
                    {
                        item.Status = false;
                    }
                }
            }

            for (int i = 0; i < BancoDados.Clientes.Count; i++)
            {
                var item = BancoDados.Clientes[i];

                if (item.Cpf == cpfInformado)
                {
                    _IdCliente = item.Id;
                    _nome = item.Nome;
                    _dataNascimento = item.DataNascimento;
                    _sexo = item.Sexo;
                    _cpf = item.Cpf;
                    _email = item.Email;
                    _numeroCelular = item.NumeroCelular;
                    _endereco = item.Endereco;
                    _statusCliente = item.Status;
                }
            }

            Filme filme = new Filme(_idFilme, _statusFilme, _titulo, _diretor, _categoriaFilme, _classificacaoIndicativa, _valorLocacao, _periodoDiasLocacao, _quantidadeDisponivel);

            Cliente cliente = new Cliente(_nome, _dataNascimento, _sexo, _cpf, _email, _numeroCelular, _IdCliente, _endereco, _statusCliente);

            Locacao locacao = new Locacao(_id, filme, cliente);

            BancoDados.Locacoes.Add(locacao);

            foreach (var item in BancoDados.Clientes.Where(x => x.Cpf == cpfInformado).ToArray())
            {
                item.Locacoes.Add(locacao);
            }
        }

        // ================================================== DEVOLVER

        internal static bool ValidaIdLocacao(int idInformado)
        {
            foreach (var item in BancoDados.Locacoes.Where(x => x.Id == idInformado))
            {
                if (item.Status == true)
                {
                    return true;
                }
            }

            return false;
        }

        internal static void AplicaMulta(int idInformado)
        {
            foreach (var item in BancoDados.Locacoes.Where(x => x.Id == idInformado).ToArray())
            {
                item.ValorMulta += 150.00;
            }

            Locacao.AtualizaLocacoes();

            TelaFormularioDevolveLocacaoNew.ExibeValoresAhPagar();
        }

        internal static void RetiraMulta(int idInformado)
        {
            foreach (var item in BancoDados.Locacoes.Where(x => x.Id == idInformado).ToArray())
            {
                item.ValorMulta = 0.00;
            }

            Locacao.AtualizaLocacoes();
        }

        internal static void ConcluiDevolucao(int idInformado)
        {
            int idFilme = 0;

            foreach (var item in BancoDados.Locacoes.Where(x => x.Id == idInformado).ToArray())
            {
                item.DataOcorreuDevolucao = DateTime.Now;

                item.Status = false;

                item.Situacao = true;

                idFilme = item.Filme.Id;
            }

            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idFilme).ToArray())
            {
                item.QuantidadeDisponivel += 1;

                if (item.QuantidadeDisponivel > 0 && item.Status == false)
                {
                    item.Status = true;
                }
            }
        }

        // ================================================== CONSULTAR

        private static int _contador;

        internal static void ListaTodos()
        {
            _contador = 4;

            foreach (var item in BancoDados.Locacoes)
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ListaAtivas()
        {
            _contador = 4;

            foreach (var item in BancoDados.Locacoes.Where(x => x.Status == true))
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ListaInativas()
        {
            _contador = 4;

            foreach (var item in BancoDados.Locacoes.Where(x => x.Status == false))
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ListaRegulares()
        {
            _contador = 4;

            foreach (var item in BancoDados.Locacoes.Where(x => x.Situacao == true))
            {
                ExibeModeloListagem(item, _contador);

                _contador++;
            }
        }

        internal static void ListaIrregulares()
        {
            _contador = 4;

            foreach (var item in BancoDados.Locacoes.Where(x => x.Situacao == false))
            {
                ExibeModeloListagem(item, _contador);
            }

            _contador++;
        }

        internal static void ConsultaId(int idInformado)
        {
            ConsultaGeral(id: idInformado);
        }

        internal static void ConsultaCpf(string cpfInformado)
        {
            ConsultaGeral(cpf: cpfInformado);
        }

        private static void ConsultaGeral(int id = 0, string cpf = null)
        {
            if (id > 0)
            {
                foreach (var item in BancoDados.Locacoes.Where(x => x.Id == id))
                {
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                    UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro(" [DADOS DA LOCAÇÃO]: \n");

                    Console.WriteLine(item);

                    UtilitariosGlobais.ApresentaResumoValores(item.Id);
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                }
            }

            if (cpf != null)
            {
                foreach (var item in BancoDados.Locacoes.Where(x => x.Cliente.Cpf == cpf))
                {
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                    UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro(" [DADOS DA LOCAÇÃO]: \n");

                    Console.WriteLine(item);

                    UtilitariosGlobais.ApresentaResumoValores(item.Id);
                    Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                }
            }
        }

        private static void ExibeModeloListagem(Locacao item, int linha)
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

                    // Separador ID
                    if (Console.CursorLeft == 8)
                    {
                        Console.Write("|");
                    }

                    // Separador título
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
            if (item.Situacao == true)
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
            UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro("[TÍTULO]                                               ");
            Console.SetCursorPosition(9, linha);
            Console.WriteLine(item.Filme.Titulo);

            Console.SetCursorPosition(65, 2);
            UtilitariosGlobais.ApresentaCabecalhoCinzaEscuro("[CPF]         ");
            Console.SetCursorPosition(65, linha);
            Console.WriteLine(item.Cliente.Cpf);
        }
    }
}
