using System;
using Locacao.Classes;
using SystemyLocacao.Repositorios;

namespace SystemyLocacao.Services
{
    public class AutenticacaoService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public AutenticacaoService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Valida login e senha. Retorna o Usuario se correto, null se inválido.
        /// </summary>
        // ADICIONADO O '?' LOGO APÓS USUARIO
        public Usuario? Autenticar(string login, string senhaDigitada)
        {
            // Busca o usuário real no banco pelo login informado
            var usuario = _usuarioRepository.BuscarPorLogin(login);

            // Usuário não encontrado
            if (usuario == null)
                return null;

            // BCrypt compara a senha digitada com o hash armazenado no banco
            bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, usuario.SenhaHash);

            return senhaCorreta ? usuario : null;
        }
    }
}