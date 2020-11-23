using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaLogin
    {
        internal static void ApresentaTela()
        {
            FuncoesTexto.ApresentaCabecalho("L O G I N");

            RecebeDadosAutenticacao();
        }

        private static void RecebeDadosAutenticacao()
        {
            Console.Write("\n Usuário: ");
            string usuarioInformado;
            usuarioInformado = Console.ReadLine();

            Console.Write(" Senha: ");
            string senhaInformada;
            senhaInformada = Console.ReadLine();

            bool resultadoAutenticacao = ControllerLogin.ValidaDadosAutenticacao(usuarioInformado, senhaInformada);

            if (resultadoAutenticacao == true)
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemSucesso($"Bem-Vindo(a) {ControllerLogin.NomeUsuarioLogado}!");

                TelaMenuInicio.ApresentaTela();
            }
            else
            {
                Console.Clear();

                FuncoesTexto.ApresentaMensagemErro("Acesso negado!");

                TelaLogin.ApresentaTela();
            }
        }
    }
}