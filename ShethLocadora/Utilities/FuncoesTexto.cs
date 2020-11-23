using System;

namespace ShethLocadora.Utilities
{
    static class FuncoesTexto
    {
        internal static void ApresentaCabecalho(string textoCabecalho)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" >>> >> > { textoCabecalho} < << <<< ");
            Console.ResetColor();
        }
        internal static void ApresentaMensagemSucesso(string textoSucesso)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" { textoSucesso} ");
            Console.ResetColor();
        }
        internal static void ApresentaMensagemErro(string textoErro)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" { textoErro} ");
            Console.ResetColor();
        }
    }
}
