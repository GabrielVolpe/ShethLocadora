//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using System;
//using ShethLocadora.ViewsNew;

//namespace ShethLocadora.Viewes
//{
//    static class TelaLogin
//    {
//        internal static void ApresentaTela()
//        {
//            UtilitariosGlobais.ApresentaCabecalho("L O G I N");

//            RecebeDadosAutenticacao();
//        }

//        private static void RecebeDadosAutenticacao()
//        {
//            string usuarioInformado = SolicitaDadosAutenticacao("\n Usuário: ");
//            string senhaInformada = SolicitaDadosAutenticacao(" Senha: ");

//            bool resultadoAutenticacao = ControllerLogin.ValidaDadosAutenticacao(usuarioInformado, senhaInformada);

//            VerificaResultadoDadosAutenticao(resultadoAutenticacao);
//        }

//        private static void VerificaResultadoDadosAutenticao(bool resultadoAutenticacao)
//        {
//            Console.Clear();

//            if (resultadoAutenticacao == true)
//            {
//                UtilitariosGlobais.ApresentaMensagemSucesso($"Bem-Vindo(a) {ControllerLogin.NomeUsuarioLogado}!");

//                TelaMenuInicioNew.ApresentaTela();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro("Acesso negado!");

//                ApresentaTela();
//            }
//        }

//        private static string SolicitaDadosAutenticacao(string nomeDoDado)
//        {
//            Console.Write(nomeDoDado);
//            string dado = Console.ReadLine();

//            return dado;
//        }
//    }
//}