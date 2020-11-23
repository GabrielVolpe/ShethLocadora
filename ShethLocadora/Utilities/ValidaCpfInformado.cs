using ShethLocadora.Repositories;

namespace ShethLocadora.Utilities
{
    static class ValidaCpfInformado
    {
        internal static bool ValidaCpfUsuario(string cpfInformado)
        {
            bool usuarioLocalizado = false;

            foreach (var item in BancoDados.Usuarios)
            {
                if (cpfInformado == item.Cpf)
                {
                    usuarioLocalizado = true;
                }
            }

            if (usuarioLocalizado == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static bool ValidaCpfCliente(string cpfInformado)
        {
            bool clienteLocalizado = false;

            foreach (var item in BancoDados.Clientes)
            {
                if (cpfInformado == item.Cpf)
                {
                    clienteLocalizado = true;
                }
            }

            if (clienteLocalizado == true)
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
