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

        ///// <summary>
        ///// Recomendado:
        ///// Para um quadrado perfeito, considere a altura como a metade da largura.
        ///// </summary>
        ///// <param name="alturaTela"></param>
        ///// <param name="larguraTela"></param>
        //public static void CriaTela(int alturaTela, int larguraTela)
        //{
        //    for (int i = 1; i < alturaTela + 1; i++)
        //    {
        //        for (int j = 2; j < larguraTela + 2; j++)
        //        {
        //            Console.SetCursorPosition(j, i);
        //            Console.BackgroundColor = ConsoleColor.DarkBlue;
        //            Console.WriteLine(" ");
        //        }
        //        Console.ResetColor();
        //    }
        //}
    }
}