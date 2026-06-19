using System;
using System.Collections.Generic;
using System.Text;
using SystemyLocacao.Classes;

namespace SystemyLocacao.Services
{
    public class AutenticacaoService
    {
        //--------Aqui Vai ser Conectado a coisas futuras, como repositorie e bcript
        //private readonly UsuarioRepository _usuarioRepository;

        //public AutenticacaoService()
        //{
        //    // _usuarioRepository = new UsuarioRepository();
        //}

        //public Usuario Autenticar(string login, string senhaDigitada)
        //{
        //    // 1. Busca o usuário no banco pelo Login
        //    // var usuario = _usuarioRepository.BuscarPorLogin(login);
        //    Usuario usuario = null; // MOCK TEMPORÁRIO ENQUANTO NÃO HÁ REPOSITORY

        //    if (usuario == null)
        //        return null; // Usuário não existe

        //    // 2. O MOMENTO DA MÁGICA: O BCrypt verifica se a senha bate com o Hash
        //    bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, usuario.SenhaHash);

        //    return senhaCorreta ? usuario : null;
        }
}

