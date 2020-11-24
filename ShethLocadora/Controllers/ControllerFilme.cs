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

        internal static bool ValidaTitulo(string tituloInformado)
        {
            Regex regexTitulo = new Regex(@"^(?<Titulo>[\w^_]){1,}(?<Espaco>\s)?(?<Titulo>[\w^_]\s?)*$");

            if (tituloInformado.Length >= 2 && regexTitulo.IsMatch(tituloInformado))
            {
                _titulo = tituloInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaDiretor(string diretorInformado)
        {
            Regex regexDiretor = new Regex(@"^(?<PrimeiroNome>[a-zA-Z]){1,}(?<EspacoEntreNomes>\s?)(?<OutrosNomes>[a-zA-Z]\s?)*$");

            if (diretorInformado.Length >= 5 && regexDiretor.IsMatch(diretorInformado))
            {
                _diretor = diretorInformado.ToUpper();

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaCategoria(int opcaoCategoriaInformada)
        {
            if (opcaoCategoriaInformada >= 1 && opcaoCategoriaInformada <= 16)
            {
                _categoria = (EnumCategoriaFilme)opcaoCategoriaInformada;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaClassificacaoIndicativa(int opcaoClassificacaoIndicativaInformada)
        {
            if (opcaoClassificacaoIndicativaInformada >= 1 && opcaoClassificacaoIndicativaInformada <= 6)
            {
                _classificacaoIndicativa = (EnumClassificacaoIndicativaFilme)opcaoClassificacaoIndicativaInformada;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaValorLocacao(double valorInformadoLocacao)
        {
            if (valorInformadoLocacao > 0)
            {
                _valorLocacao = valorInformadoLocacao;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaPeriodoDiasLocacao(int periodoDiasLocacaoInformado)
        {
            if (periodoDiasLocacaoInformado > 0)
            {
                _periodoDiasLocacao = periodoDiasLocacaoInformado;

                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaQuantidadeDisponivel(int quantidadeDisponivelInformada)
        {
            if (quantidadeDisponivelInformada > 0)
            {
                _quantidadeDisponivel = quantidadeDisponivelInformada;

                return true;
            }
            else
            {
                return false;
            }
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
            else
            {
                return false;
            }
        }

        // ================================================== CONSULTAR

        internal static void ConsultaTodos()
        {
            foreach (var item in BancoDados.Filmes)
            {
                Console.WriteLine(item);
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

        internal static void ConsultaCategoria(int opcaoCategoriaInformada)
        {
            ConsultaGeral(categoria: (EnumCategoriaFilme)opcaoCategoriaInformada);
        }

        private static void ConsultaGeral(int id = 0, EnumCategoriaFilme categoria = 0, string titulo = null, string diretor = null)
        {
            var filmes = BancoDados.Filmes.AsEnumerable();

            if (id > 0)
            {
                BancoDados.Filmes.Where(x => x.Id == id);
            }

            if (categoria > 0)
            {
                filmes = filmes.Where(x => x.Categoria == categoria);
            }

            if (titulo != null)
            {
                filmes = filmes.Where(x => x.Titulo.Contains(titulo));
            }

            if (diretor != null)
            {
                filmes = filmes.Where(x => x.Diretor.Contains(diretor));
            }

            foreach (var item in filmes)
            {
                Console.WriteLine(item);
            }
        }

        // ================================================== ALTERAR

        internal static void AlteraStatus(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.Status = _status;
                }
            }
        }

        internal static void AlteraTitutlo(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.Titulo = _titulo;
                }
            }
        }

        internal static void AlteraDiretor(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.Diretor = _diretor;
                }
            }
        }

        internal static void AlteraCategoria(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.Categoria = _categoria;
                }
            }
        }

        internal static void AlteraClassificacaoIndicativa(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.ClassificacaoIndicativa = _classificacaoIndicativa;
                }
            }
        }

        internal static void AlteraValorLocacao(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.ValorLocacao = _valorLocacao;
                }
            }
        }

        internal static void AlteraPeriodoDiasLocacao(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.PeriodoDiasLocacao = _periodoDiasLocacao;
                }
            }
        }

        internal static void AlteraQuantidadeDisponivel(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    item.QuantidadeDisponivel = _quantidadeDisponivel;
                }
            }
        }

        // ================================================== EXCLUIR

        internal static void ExcluiFilme(int idInformado)
        {
            foreach (var item in BancoDados.Filmes.ToArray())
            {
                if (item.Id == idInformado)
                {
                    BancoDados.Filmes.Remove(item);
                }
            }
        }
    }
}
