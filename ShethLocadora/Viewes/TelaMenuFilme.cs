﻿using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.Viewes
{
    static class TelaMenuFilme
    {
        internal static void ApresentaTela()
        {
            UtilitariosGlobais.ApresentaCabecalho("F I L M E S");

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenu();

            ControllerTelaMenuFilme.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.WriteLine("\n 1 - Cadastrar");
            //Console.WriteLine(" 2 - Listar");
            Console.WriteLine(" 2 - Consultar");
            Console.WriteLine(" 3 - Alterar");
            Console.WriteLine(" 4 - Excluir");
            Console.WriteLine(" 9 - Início");
        }
    }
}
