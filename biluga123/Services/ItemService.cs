using System;
using Locacao.Classes;
using SystemyLocacao.Repositorios;

// Using explícito resolve CS0229: garante que SessaoSistema vem de um único lugar.
using SystemyLocacao.Services;

namespace SystemyLocacao.Services
{
    public class ItemService
    {
        private readonly ItemRepository _repository;

        public ItemService()
        {
            _repository = new ItemRepository();
        }

        public void CadastrarItem(Item item)
        {
            GarantirPermissaoDeEscrita();
            ValidarDados(item.NameI, item.ValueI);

            _repository.Inserir(item);
        }

        // --- MÉTODOS PRIVADOS ---

        private void GarantirPermissaoDeEscrita()
        {
            if (!SessaoSistema.PodeEscrever)
                throw new UnauthorizedAccessException("Seu papel (Visualizador) não permite cadastrar ou alterar Itens.");
        }

        private void ValidarDados(string nome, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do item é obrigatório.");

            if (valor < 0)
                throw new ArgumentException("O valor da diária não pode ser negativo.");
        }
    }
}
