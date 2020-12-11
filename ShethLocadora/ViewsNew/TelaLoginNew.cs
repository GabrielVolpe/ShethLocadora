using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaLoginNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" L O G I N", 80, 6, 0, 1);

            RecebeDadosAutenticacao();
        }

        private static void RecebeDadosAutenticacao()
        {
            Console.SetCursorPosition(0, 3);
            string usuarioInformado = SolicitaDadosAutenticacao(" [Usuário]: ");

            Console.SetCursorPosition(0, 5);
            string senhaInformada = SolicitaDadosAutenticacao(" [Senha]: ");

            bool resultadoAutenticacao = ControllerLogin.ValidaDadosAutenticacao(usuarioInformado, senhaInformada);

            VerificaResultadoDadosAutenticao(resultadoAutenticacao);
        }

        private static void VerificaResultadoDadosAutenticao(bool resultadoAutenticacao)
        {
            Console.Clear();

            if (resultadoAutenticacao == true)
            {
                UtilitariosGlobais.ApresentaMensagemSucesso($" Bem-Vindo(a) {ControllerLogin.NomeUsuarioLogado}!");

                TelaMenuInicioNew.ApresentaTela();
            }
            else
            {
                UtilitariosGlobais.ApresentaMensagemErro(" Acesso negado!");

                ApresentaTela();
            }
        }

        private static string SolicitaDadosAutenticacao(string nomeDoDado)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.Write(nomeDoDado);
            string dado = Console.ReadLine();

            Console.ResetColor();

            return dado;
        }
    }
}
