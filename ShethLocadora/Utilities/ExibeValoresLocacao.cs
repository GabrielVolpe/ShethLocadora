using ShethLocadora.Repositories;
using System;

namespace ShethLocadora.Utilities
{
    static class ExibeValoresLocacao
    {
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
