using ShethLocadora.Models;
using ShethLocadora.Models.Enums;
using ShethLocadora.Services;
using System;
using System.Collections.Generic;

namespace ShethLocadora.Repositories
{
    static class BancoDados
    {
        public static List<Usuario> Usuarios = new List<Usuario>();

        public static List<Cliente> Clientes = new List<Cliente>();

        public static List<Filme> Filmes = new List<Filme>();

        public static List<Locacao> Locacoes = new List<Locacao>();

        public static void GeraDadosTestes()
        {
            Endereco enderecoTeste = new Endereco(EnumUnidadeFederativaEndereco.PR, "CIDADE", "BAIRRO", "LOGRADOURO", "COMPLEMENTO", "00000000");

            Usuario usuarioTeste1 = new Usuario("GABRIEL VOLPE RODRIGUES", DateTime.Parse("15/08/1996"), EnumSexoPessoa.MASCULINO, "09630541980", "VOLPE.GABRIEL96@GMAIL.COM", "44998662249", 1, true, 1,
                enderecoTeste, "", "");

            Usuario usuarioTeste2 = new Usuario("HERBERT SILVA RUELIS RODRIGUES", DateTime.Parse("01/01/1988"), EnumSexoPessoa.MASCULINO, "00011122233", "HERBERT@GMAIL.COM", "44000000000", 2, true, 2,
                enderecoTeste, "ope", "2");

            Cliente clienteTeste1 = new Cliente("GABRIEL VOLPE RODRIGUES", DateTime.Parse("15/08/1996"), EnumSexoPessoa.MASCULINO, "09630541980", "VOLPE.GABRIEL96@GMAIL.COM", "44998662249", 1, enderecoTeste, true);

            Cliente clienteTeste2 = new Cliente("HERBERT SILVA RUELIS RODRIGUES", DateTime.Parse("01/01/1988"), EnumSexoPessoa.MASCULINO, "00011122233", "HERBERT@GMAIL.COM", "44000000000", 2, enderecoTeste, false);

            Filme filmeTeste1 = new Filme(1, true, "BASTARDOS INGLÓRIOS", "QUENTIN TARANTINO", EnumCategoriaFilme.GUERRA, EnumClassificacaoIndicativaFilme.DEZOITO, 5.00, 3, 3);

            Filme filmeTeste2 = new Filme(2, false, "SETE MINUTOS DEPOIS DA MEIA NOITE", "JUAN ANTONIO BAYONA", EnumCategoriaFilme.DRAMA, EnumClassificacaoIndicativaFilme.DOZE, 3.50, 3, 3);

            BancoDados.Usuarios.Add(usuarioTeste1);
            BancoDados.Usuarios.Add(usuarioTeste2);

            BancoDados.Clientes.Add(clienteTeste1);
            BancoDados.Clientes.Add(clienteTeste2);

            BancoDados.Filmes.Add(filmeTeste1);
            BancoDados.Filmes.Add(filmeTeste2);
        }
    }
}
