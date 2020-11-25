using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.Viewes;
using System;


namespace ShethLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "S H E T H   L O C A D O R A";

            BancoDados.GeraDadosTestes();

            Locacao.AtualizaLocacoes();

            TelaLogin.ApresentaTela();
        }
    }
}