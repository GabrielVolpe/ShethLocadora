using ShethLocadora.Repositories;
using System;

namespace ShethLocadora.Utilities
{
    static class UtilitariosGlobais
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

        internal static int RecebeOpcaoMenuClear()
        {
            int opcaoInformada = 0;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.Clear();

            return opcaoInformada;
        }

        internal static int RecebeOpcaoMenu()
        {
            int opcaoInformada = 0;

            Console.Write("\n Opção: ");
            int.TryParse(Console.ReadLine(), out opcaoInformada);

            Console.WriteLine();

            return opcaoInformada;
        }

        internal static string RecebeDadoCadastroString(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.Write(" ");

            string dadoString = null;
            dadoString = Console.ReadLine();

            return dadoString;
        }

        internal static int RecebeDadoCadastroIntEnum(string mensagem)
        {
            Console.Write(mensagem);

            int dadoEnum = 0;
            int.TryParse(Console.ReadLine(), out dadoEnum);

            return dadoEnum;
        }

        internal static string ConsultasString(string mensagem)
        {
            Console.Write(mensagem);

            string dadoString = null;
            dadoString = Console.ReadLine();

            Console.WriteLine();

            return dadoString;
        }

        internal static int ConsultasInt(string mensagem)
        {
            Console.Write(mensagem);

            int dadoInt = 0;
            int.TryParse(Console.ReadLine(), out dadoInt);

            Console.WriteLine();

            return dadoInt;
        }

        internal static bool ValidaCpfUsuario(string cpfInformado)
        {
            foreach (var item in BancoDados.Usuarios)
            {
                if (cpfInformado == item.Cpf)
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool ValidaCpfCliente(string cpfInformado)
        {
            foreach (var item in BancoDados.Clientes)
            {
                if (cpfInformado == item.Cpf)
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool ValidaIdFilme(int idInformado)
        {
            foreach (var item in BancoDados.Filmes)
            {
                if (idInformado == item.Id)
                {
                    return true;
                }
            }

            return false;
        }

        internal static void ApresentaResumoValores(int idInformado)
        {
            foreach (var item in BancoDados.Locacoes)
            {
                if (item.Id == idInformado)
                {
                    Console.WriteLine($" Valor de locação no prazo: {item.ValorPrazo.ToString("F2")}");
                    Console.WriteLine($" Dias em atraso...........: {DateTime.Now.Day - item.DataPrevistaDevolucao.Day}");
                    Console.WriteLine($" Taxa de juros......... ..: {item.TaxaJurosAtraso}%" + " a.d");
                    Console.WriteLine($" Valor da multa...........: R$ {item.ValorMulta.ToString("F2")}");
                    Console.WriteLine($" Valor dos juros..........: R$ {item.ValorJuros.ToString("F2")}");
                    Console.WriteLine($"\n TOTAL..................: R$ {item.ValorFinal.ToString("F2")}\n");
                }
            }
        }
    }
}
