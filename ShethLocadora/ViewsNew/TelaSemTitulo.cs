using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaSemTitulo
    {
        internal static void GeraTela(int largura, int altura, int distanciaLateral = 0, int distanciaSuperior = 0)
        {
            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    Console.SetCursorPosition(distanciaLateral + i, distanciaSuperior + j);

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }
    }
}
