﻿using ShethLocadora.Controllers;
using ShethLocadora.Utilities;
using System;

namespace ShethLocadora.ViewsNew
{
    static class TelaMenuClienteNew
    {
        internal static void ApresentaTela()
        {
            TelaComTitulo.GeraTela(" C L I E N T E S", 80, 10, 0, 1);

            ApresentaMenu();
        }

        private static void ApresentaMenu()
        {
            OpcoesMenu();

            int opcaoInformada = UtilitariosGlobais.RecebeOpcaoMenuClear();

            ControllerTelaMenuCliente.RecebeOpcaoMenu(opcaoInformada);
        }

        private static void OpcoesMenu()
        {
            Console.SetCursorPosition(0, 3);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" [1] - Cadastrar");
            Console.WriteLine(" [2] - Consultar");
            Console.WriteLine(" [3] - Alterar");
            Console.WriteLine(" [4] - Excluir");
            Console.WriteLine(" [9] - Início");
            Console.ResetColor();
        }
    }
}
