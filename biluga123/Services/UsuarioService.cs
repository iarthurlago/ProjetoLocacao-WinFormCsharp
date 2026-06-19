using System;
using Locacao.Classes;
using SystemyLocacao.Repositorios;
using SystemyLocacao.Services;

namespace SystemyLocacao.Services
{
    public class UsuarioService
    {
        // Repositório responsável por persistir o usuário no banco
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public void SalvarUsuario(Usuario novoUsuario, string senhaTextoPuro)
        {
            // 1. VERIFICAÇÃO DE SEGURANÇA (RBAC)
            // Apenas o Admin cadastra novos usuários e define seus papéis.
            if (SessaoSistema.UsuarioLogado == null || SessaoSistema.UsuarioLogado.Papel != Papel.Admin)
            {
                throw new UnauthorizedAccessException("Acesso Negado: Apenas Administradores podem gerenciar usuários.");
            }

            // 2. VALIDAÇÕES
            if (string.IsNullOrWhiteSpace(novoUsuario.Login) || string.IsNullOrWhiteSpace(senhaTextoPuro))
                throw new ArgumentException("Login e Senha são obrigatórios.");

            // 3. HASHING DE SENHA com BCrypt
            // A senha nunca é armazenada em texto puro — apenas o hash vai para o banco.
            novoUsuario.SenhaHash = BCrypt.Net.BCrypt.HashPassword(senhaTextoPuro);

            // 4. PERSISTÊNCIA no banco de dados
            _usuarioRepository.Inserir(novoUsuario);
        }
    }
}
