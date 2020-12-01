using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Repositories;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShethLocadora.Controllers
{
    static class ControllerFilme
    {
        // ================================================== CADASTRAR

        private static int _id;
        private static bool _status;
        private static string _titulo;
        private static string _diretor;
        private static EnumCategoriaFilme _categoria;
        private static EnumClassificacaoIndicativaFilme _classificacaoIndicativa;
        private static double _valorLocacao;
        private static int _periodoDiasLocacao;
        private static int _quantidadeDisponivel;

        internal static bool ValidaStatus(int opcaoStatusInformada)
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

        internal static bool ValidaTitulo(string tituloInformado)
        {
            Regex regexTitulo = new Regex(@"^(?<Titulo>[\w^_]){1,}(?<Espaco>\s)?(?<Titulo>[\w^_]\s?)*$");

            if (tituloInformado.Length >= 2 && regexTitulo.IsMatch(tituloInformado))
            {
                _titulo = tituloInformado.ToUpper();

                return true;
            }

            return false;
        }

        internal static bool ValidaDiretor(string diretorInformado)
        {
            Regex regexDiretor = new Regex(@"^(?<PrimeiroNome>[a-zA-Z]){1,}(?<EspacoEntreNomes>\s?)(?<OutrosNomes>[a-zA-Z]\s?)*$");

            if (diretorInformado.Length >= 5 && regexDiretor.IsMatch(diretorInformado))
            {
                _diretor = diretorInformado.ToUpper();

                return true;
            }

            return false;
        }

        internal static bool ValidaCategoria(int opcaoCategoriaInformada)
        {
            if (opcaoCategoriaInformada >= 1 && opcaoCategoriaInformada <= 16)
            {
                _categoria = (EnumCategoriaFilme)opcaoCategoriaInformada;

                return true;
            }

            return false;
        }

        internal static bool ValidaClassificacaoIndicativa(int opcaoClassificacaoIndicativaInformada)
        {
            if (opcaoClassificacaoIndicativaInformada >= 1 && opcaoClassificacaoIndicativaInformada <= 6)
            {
                _classificacaoIndicativa = (EnumClassificacaoIndicativaFilme)opcaoClassificacaoIndicativaInformada;

                return true;
            }

            return false;
        }

        internal static bool ValidaValorLocacao(double valorInformadoLocacao)
        {
            if (valorInformadoLocacao > 0)
            {
                _valorLocacao = valorInformadoLocacao;

                return true;
            }

            return false;
        }

        internal static bool ValidaPeriodoDiasLocacao(int periodoDiasLocacaoInformado)
        {
            if (periodoDiasLocacaoInformado > 0)
            {
                _periodoDiasLocacao = periodoDiasLocacaoInformado;

                return true;
            }

            return false;
        }

        internal static bool ValidaQuantidadeDisponivel(int quantidadeDisponivelInformada)
        {
            if (quantidadeDisponivelInformada > 0)
            {
                _quantidadeDisponivel = quantidadeDisponivelInformada;

                return true;
            }

            return false;
        }

        internal static bool FinalizaCadastro()
        {
            if (BancoDados.Filmes.Count == 0)
            {
                _id = 1;
            }
            else
            {
                foreach (var item in BancoDados.Filmes)
                {
                    if (_id <= item.Id)
                    {
                        _id = item.Id + 1;
                    }
                }
            }

            Filme filme = new Filme(_id, _status, _titulo, _diretor, _categoria, _classificacaoIndicativa, _valorLocacao, _periodoDiasLocacao, _quantidadeDisponivel);

            bool filmeDuplicado = false;

            foreach (var item in BancoDados.Filmes)
            {
                if (item.GetHashCode() == filme.GetHashCode() && item.Equals(filme))
                {
                    filmeDuplicado = true;
                }
            }

            if (filmeDuplicado == false)
            {
                BancoDados.Filmes.Add(filme);

                return true;
            }

            return false;
        }

        // ================================================== CONSULTAR

        internal static void ListaTodos()
        {
            foreach (var item in BancoDados.Filmes)
            {
                ExibeModeloListagem(item);
            }
        }

        internal static void ConsultaId(int idInformado)
        {
            ConsultaGeral(id: idInformado);
        }

        internal static void ConsultaTitulo(string tituloInformado)
        {
            ConsultaGeral(titulo: tituloInformado);
        }

        internal static void ConsultaDiretor(string diretorInformado)
        {
            ConsultaGeral(diretor: diretorInformado);
        }

        internal static void ListaCategoria(int opcaoCategoriaInformada)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Categoria == (EnumCategoriaFilme)opcaoCategoriaInformada))
            {
                ExibeModeloListagem(item);
            };
        }

        private static void ConsultaGeral(int id = 0, string titulo = null, string diretor = null, EnumCategoriaFilme categoria = 0)
        {
            if (id > 0)
            {
                foreach (var item in BancoDados.Filmes.Where(x => x.Id == id))
                {
                    Console.WriteLine(item);
                }
            }

            if (titulo != null)
            {
                foreach (var item in BancoDados.Filmes.Where(x => x.Titulo == titulo.ToUpper() && !string.IsNullOrWhiteSpace(titulo)))
                {
                    Console.WriteLine(item);
                }
            }

            if (diretor != null)
            {
                foreach (var item in BancoDados.Filmes.Where(x => x.Diretor == diretor.ToUpper() && !string.IsNullOrWhiteSpace(titulo)))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void ExibeModeloListagem(Filme item)
        {
            Console.WriteLine(" ID.......: " + item.Id);
            Console.WriteLine(" Título...: " + item.Titulo);
            Console.WriteLine(" Diretor..: " + item.Diretor + "\n");
        }

        // ================================================== ALTERAR

        internal static void AlteraStatus(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.Status = _status;
            }
        }

        internal static void AlteraTitutlo(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.Titulo = _titulo.ToUpper();
            }
        }

        internal static void AlteraDiretor(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.Diretor = _diretor.ToUpper();
            }
        }

        internal static void AlteraCategoria(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.Categoria = _categoria;
            }
        }

        internal static void AlteraClassificacaoIndicativa(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.ClassificacaoIndicativa = _classificacaoIndicativa;
            }
        }

        internal static void AlteraValorLocacao(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.ValorLocacao = _valorLocacao;
            }
        }

        internal static void AlteraPeriodoDiasLocacao(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.PeriodoDiasLocacao = _periodoDiasLocacao;
            }
        }

        internal static void AlteraQuantidadeDisponivel(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                item.QuantidadeDisponivel = _quantidadeDisponivel;
            }
        }

        // ================================================== EXCLUIR

        internal static void ExcluiFilme(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.Where(x => x.Id == idInformado).ToArray())
            {
                BancoDados.Filmes.Remove(item);
            }
        }
    }
}
