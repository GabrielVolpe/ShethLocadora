using ShethLocadora.Repositories;

namespace ShethLocadora.Controllers
{
    static class ControllerLogin
    {
        internal static string NomeUsuarioLogado;
        internal static int PermissaoUsuarioLogado;
        private static bool _autenticacaoValida;

        internal static bool ValidaDadosAutenticacao(string usuarioInformado, string senhaInformada)
        {
            _autenticacaoValida = false;

            foreach (var item in BancoDados.Usuarios)
            {
                if (usuarioInformado == item.UsuarioAutenticacao && senhaInformada == item.SenhaAutenticacao && item.Status == true)
                {
                    NomeUsuarioLogado = item.Nome;
                    PermissaoUsuarioLogado = item.Permissao;

                    _autenticacaoValida = true;
                }
            }

            if (_autenticacaoValida == true)
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
