using System;
using System.Linq;
using Locacao.Classes;
using SystemyLocacao.Repositorios;

// Using explícito resolve CS0229: garante que SessaoSistema vem de um único lugar.
using SystemyLocacao.Services;

namespace SystemyLocacao.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            GarantirPermissaoDeEscrita();
            ValidarDados(cliente.Nome, cliente.Contato);

            _repository.Inserir(cliente);
        }

        // --- MÉTODOS PRIVADOS DE APOIO ---

        private void GarantirPermissaoDeEscrita()
        {
            if (!SessaoSistema.PodeEscrever)
                throw new UnauthorizedAccessException("Acesso Negado: Seu papel (Visualizador) não permite cadastrar ou editar clientes.");
        }

        private void ValidarDados(string nome, string contato)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do cliente é obrigatório.");

            if (nome.Any(char.IsDigit))
                throw new ArgumentException("O nome do cliente deve conter apenas texto, sem números.");

            if (string.IsNullOrWhiteSpace(contato) || contato.Length != 11 || !contato.All(char.IsDigit))
                throw new ArgumentException("O contato deve ter exatamente 11 dígitos numéricos (Ex: 79999999999).");
        }
    }
}
