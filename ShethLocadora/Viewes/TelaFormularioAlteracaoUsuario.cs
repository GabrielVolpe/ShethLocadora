//using ShethLocadora.Controllers;
//using ShethLocadora.Utilities;
//using ShethLocadora.ViewsNew;
//using System;

//namespace ShethLocadora.Viewes
//{
//    static class TelaFormularioAlteracaoUsuario
//    {
//        internal static void RecebeNome()
//        {
//            Tuple<bool, string> retornoNome = TelaFormularioDadosPessoa.RecebeNome();

//            if (retornoNome.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraNome(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoNome.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Nome inválido!");

//                RecebeNome();
//            }
//        }

//        internal static void RecebeDataNascimento()
//        {
//            Tuple<bool, string> retornoDataNascimento = TelaFormularioDadosPessoa.RecebeDataNascimento();

//            if (retornoDataNascimento.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraDataNascimento(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoDataNascimento.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Data inválida!");

//                RecebeDataNascimento();
//            }
//        }

//        internal static void RecebeSexo()
//        {
//            Tuple<bool, int> retornoSexo = TelaFormularioDadosPessoa.RecebeSexo();

//            if (retornoSexo.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraSexo(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoSexo.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro("Opção inválida!");

//                RecebeSexo();
//            }
//        }

//        internal static void RecebeCpf()
//        {
//            Tuple<bool, string> retornoCpf = TelaFormularioDadosPessoa.RecebeCpf();

//            if (retornoCpf.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraCpf(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoCpf.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Cpf inválido!");

//                RecebeCpf();
//            }
//        }

//        internal static void RecebeEmail()
//        {
//            Tuple<bool, string> retornoEmail = TelaFormularioDadosPessoa.RecebeEmail();

//            if (retornoEmail.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraEmail(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoEmail.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" E-mail inválido!");

//                RecebeEmail();
//            }
//        }

//        internal static void RecebeNumeroCelular()
//        {
//            Tuple<bool, string> retornoNumeroCelular = TelaFormularioDadosPessoa.RecebeEmail();

//            if (retornoNumeroCelular.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraNumeroCelular(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoNumeroCelular.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Número de celular inválido!");

//                RecebeNumeroCelular();
//            }
//        }

//        internal static void RecebeUnidadeFederativa()
//        {
//            Tuple<bool, int> retornoUnidadeFederativa = TelaFormularioDadosEndereco.RecebeUnidadeFederativa();

//            if (retornoUnidadeFederativa.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraUnidadeFederativa(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoUnidadeFederativa.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

//                RecebeUnidadeFederativa();
//            }
//        }

//        internal static void RecebeCidade()
//        {
//            Tuple<bool, string> retornoCidade = TelaFormularioDadosEndereco.RecebeCidade();

//            if (retornoCidade.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraCidade(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoCidade.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Cidade inválida!");

//                RecebeCidade();
//            }
//        }

//        internal static void RecebeBairro()
//        {
//            Tuple<bool, string> retornoBairro = TelaFormularioDadosEndereco.RecebeBairro();

//            if (retornoBairro.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraBairro(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoBairro.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Bairro inválido!");

//                RecebeBairro();
//            }
//        }

//        internal static void RecebeLogradouro()
//        {
//            Tuple<bool, string> retornoLogradouro = TelaFormularioDadosEndereco.RecebeLogradouro();

//            if (retornoLogradouro.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraLogradouro(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoLogradouro.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Logradouro inválido!");

//                RecebeLogradouro();
//            }
//        }

//        internal static void RecebeComplemento()
//        {
//            Tuple<bool, string> retornoComplemento = TelaFormularioDadosEndereco.RecebeComplemento();

//            if (retornoComplemento.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraComplemento(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoComplemento.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Complemento inválido!");

//                RecebeComplemento();
//            }
//        }

//        internal static void RecebeCep()
//        {
//            Tuple<bool, string> retornoCep = TelaFormularioDadosEndereco.RecebeCep();

//            if (retornoCep.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraCep(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoCep.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Cep inválido!");

//                RecebeCep();
//            }
//        }

//        internal static void RecebeStatus()
//        {
//            Tuple<bool, int> retornoStatus = TelaFormularioCadastroUsuarioNew.RecebeStatus();

//            if (retornoStatus.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraStatus(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoStatus.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

//                RecebeStatus();
//            }
//        }

//        internal static void RecebePermissao()
//        {
//            Tuple<bool, int> retornoPermissao = TelaFormularioCadastroUsuarioNew.RecebePermissao();

//            if (retornoPermissao.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraPermissao(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoPermissao.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Opção inválida!");

//                RecebePermissao();
//            }
//        }

//        internal static void RecebeUsuarioAutenticacao()
//        {
//            Tuple<bool, string> retornoUsuarioAutenticacao = TelaFormularioCadastroUsuarioNew.RecebeUsuarioAutenticacao();

//            if (retornoUsuarioAutenticacao.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraUsuarioAutenticacao(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoUsuarioAutenticacao.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Usuário inválido!");

//                RecebeUsuarioAutenticacao();
//            }
//        }

//        internal static void RecebeSenhaAutenticacao()
//        {
//            Tuple<bool, string> retornoSenhaAutenticacao = TelaFormularioCadastroUsuarioNew.RecebeSenhaAutenticacao();

//            if (retornoSenhaAutenticacao.Item1 == true)
//            {
//                Console.Clear();

//                ControllerUsuario.AlteraSenhaAutenticacao(TelaOpcoesAlteracaoUsuarioNew.CpfInformado, retornoSenhaAutenticacao.Item2);

//                FinalizaAlteracao();
//            }
//            else
//            {
//                UtilitariosGlobais.ApresentaMensagemErro(" Senha inválido!");

//                RecebeSenhaAutenticacao();
//            }
//        }

//        private static void FinalizaAlteracao()
//        {
//            UtilitariosGlobais.ApresentaMensagemSucesso("Alteração realizada com sucesso!");

//            TelaMenuUsuarioNew.ApresentaTela();
//        }
//    }
//}