using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaComTitulo
    {
        /// <summary>
        /// Para um quadrado perfeito no console a largura deve ser o dobro da altura.
        /// Para uma distância entre as bordas superiores e laterais com mesma proporção, a distância lateral deve ser o dobro da distância superior.
        /// </summary>
        /// <param name="largura"></param>
        /// <param name="altura"></param>
        /// <param name="distanciaLateral"></param>
        /// <param name="distanciaSuperior"></param>
        internal static void GeraTela(string tituloTela, int largura, int altura, int distanciaLateral = 0, int distanciaSuperior = 0)
        {
            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    Console.SetCursorPosition(distanciaLateral + i, distanciaSuperior + j);

                    if (Console.CursorTop == distanciaSuperior + 1)
                    {
                        Console.Write("=");
                    }

                    if (Console.CursorTop == altura || Console.CursorTop == (altura * 2) + 1)
                    {
                        Console.Write("=");
                    }

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" ");
                }
            }

            Console.SetCursorPosition(distanciaLateral, distanciaSuperior);
            Console.Write($"{tituloTela.ToUpper()}");

            Console.ResetColor();
        }
    }
}
