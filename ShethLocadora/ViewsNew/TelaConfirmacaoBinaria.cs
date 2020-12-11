using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaConfirmacaoBinaria
    {
        /// <summary>
        /// Por padrão, a altura é de 39 pontos e a largura de 7 pontos.
        /// O método retorna um inteiro referente a opção informada. Por padrão, 1 = sim e 2 = não.
        /// </summary>
        /// <param name="tituloTela"></param>
        /// <param name="distanciaLateral"></param>
        /// <param name="distanciaSuperior"></param>
        /// <returns></returns>
        internal static int GeraTela(string tituloTela, int distanciaLateral, int distanciaSuperior, int largura = 38, int altura = 7)
        {
            TelaComTitulo.GeraTela(tituloTela, largura, altura, distanciaLateral, distanciaSuperior);

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.SetCursorPosition(distanciaLateral, distanciaSuperior + 2);
            Console.Write(" [1] - Sim");

            Console.SetCursorPosition(distanciaLateral, distanciaSuperior + 3);
            Console.Write(" [2] - Não");

            Console.SetCursorPosition(distanciaLateral, distanciaSuperior + 5);
            Console.Write(" [Opção]: ");

            int opcaoInformada = 0;
            Console.SetCursorPosition(distanciaLateral + 10, distanciaSuperior + 5);
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.ResetColor();

            return opcaoInformada;
        }
    }
}
