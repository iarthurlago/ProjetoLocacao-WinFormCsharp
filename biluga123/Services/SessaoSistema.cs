using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;

namespace SystemyLocacao.Services
{
    public static class SessaoSistema
    {
        // Propriedade blindada: só pode ser lida por fora, alterada por dentro.
        public static Usuario? UsuarioLogado { get; private set; }

        public static void IniciarSessao(Usuario usuario)
        {
            UsuarioLogado = usuario;
        }

        public static void EncerrarSessao()
        {
            UsuarioLogado = null;
        }

        public static bool TemUsuarioLogado => UsuarioLogado != null;

        // Atalho Mágico 1: Útil para travar a tela de Gerenciar Usuários
        public static bool EhAdmin =>
            UsuarioLogado != null && UsuarioLogado.Papel == Papel.Admin;

        // Atalho Mágico 2: Útil para liberar botões de Salvar/Excluir nas telas de Cliente/Item/Locacao
        public static bool PodeEscrever =>
            UsuarioLogado != null &&
            (UsuarioLogado.Papel == Papel.Operador || UsuarioLogado.Papel == Papel.Admin);
    }
}