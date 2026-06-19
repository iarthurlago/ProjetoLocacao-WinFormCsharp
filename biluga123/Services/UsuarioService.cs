using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;
using SystemyLocacao.Services;

namespace Locacao.Classes.Services
{
    public class UsuarioService
    {
        public void SalvarUsuario(Usuario novoUsuario, string senhaTextoPuro)
        {
            // 1. VERIFICAÇÃO DE SEGURANÇA EXTREMA (RBAC)
            // Apenas o Admin cadastra novos usuários e define seus papéis.
            if (SessaoSistema.UsuarioLogado.Papel != Papel.Admin)
            {
                throw new UnauthorizedAccessException("Acesso Negado: Apenas Administradores podem gerenciar usuários.");
            }

            // 2. VALIDAÇÕES
            if (string.IsNullOrWhiteSpace(novoUsuario.Login) || string.IsNullOrWhiteSpace(senhaTextoPuro))
                throw new ArgumentException("Login e Senha são obrigatórios.");

            // 3. HASHING DE SENHA 
            // Em nenhum momento o sistema guarda a senha do usuário como texto. 
            // Aqui entrará a biblioteca BCrypt no futuro.
            // novoUsuario.SenhaHash = BCrypt.Net.BCrypt.HashPassword(senhaTextoPuro);

            // 4. PERSISTÊNCIA
            // _usuarioRepository.Inserir(novoUsuario);
        }
    }
}