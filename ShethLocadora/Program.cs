using ShethLocadora.Repositories;
using ShethLocadora.Services;
using ShethLocadora.ViewsNew;
using System;


namespace ShethLocadora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;

            Console.Title = $"...::: S H E T H   L O C A D O R A :::... ({dataAtual.ToString("dd/MM/yyyy")})";

            Console.SetWindowSize(120, 40);

            BancoDados.GeraDadosTestes();

            Locacao.AtualizaLocacoes();

            TelaLoginNew.ApresentaTela();
        }
    }
}