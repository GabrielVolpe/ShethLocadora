using ShethLocadora.Repositories;

namespace ShethLocadora.Utilities
{
    static class ValidaIdInformado
    {
        internal static bool ValidaIdFilme(int idInformado)
        {
            bool filmeLocalizado = false;

            foreach (var item in BancoDados.Filmes)
            {
                if (idInformado == item.Id)
                {
                    filmeLocalizado = true;
                }
            }

            if (filmeLocalizado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
