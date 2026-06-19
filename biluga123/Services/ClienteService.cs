using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;

namespace SystemyLocacao.Services
{
    public class ClienteService
    {
        // private readonly ClienteRepository _repository;

        public ClienteService()
        {
            // _repository = new ClienteRepository();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            // O fluxo fica limpo e legível
            GarantirPermissaoDeEscrita();
            ValidarDados(cliente.Name, cliente.Contact);

            // _repository.Inserir(cliente);
        }

        // --- MÉTODOS PRIVADOS DE APOIO ---

        private void GarantirPermissaoDeEscrita()
        {
            if (!SessaoSistema.PodeEscrever)
            {
                throw new UnauthorizedAccessException("Acesso Negado: Seu papel (Visualizador) não permite cadastrar ou editar clientes.");
            }
        }

        private void ValidarDados(string nome, string contato)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do cliente é obrigatório.");

            // Regra: Nome deve conter apenas letras e espaços (sem números)
            if (nome.Any(char.IsDigit))
                throw new ArgumentException("O nome do cliente deve conter apenas texto, sem números.");

            // Regra: Contato precisa ter exatamente 11 dígitos e ser apenas números
            if (string.IsNullOrWhiteSpace(contato) || contato.Length != 11 || !contato.All(char.IsDigit))
                throw new ArgumentException("O contato deve ter exatamente 11 dígitos numéricos (Ex: 79999999999).");
        }
    }
}
