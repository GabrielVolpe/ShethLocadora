using ShethLocadora.Repositories;

namespace ShethLocadora.Controllers
{
    static class ControllerLogin
    {
        internal static string NomeUsuarioLogado;
        internal static int PermissaoUsuarioLogado;

        internal static bool ValidaDadosAutenticacao(string usuarioInformado, string senhaInformada)
        {
            foreach (var item in BancoDados.Usuarios)
            {
                if (usuarioInformado == item.UsuarioAutenticacao && senhaInformada == item.SenhaAutenticacao && item.Status == true)
                {
                    NomeUsuarioLogado = item.Nome;
                    PermissaoUsuarioLogado = item.Permissao;

                    return true;
                }
            }

            return false;
        }
    }
}
