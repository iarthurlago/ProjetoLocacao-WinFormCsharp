using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;

using System;
using SystemyLocacao.Classes;

namespace SystemyLocacao.Services
{
    public class ItemService
    {
        // Preparando o terreno para o banco de dados (igual ao professor)
        // private readonly ItemRepository _repository; 

        public ItemService()
        {
            // _repository = new ItemRepository();
        }

        // O método principal fica extremamente limpo e fácil de ler
        public void CadastrarItem(Item item)
        {
            GarantirPermissaoDeEscrita();
            ValidarDados(item.NameI, item.ValueI);

            // _repository.Inserir(item);
        }

        // --- MÉTODOS PRIVADOS (Escondem a complexidade) ---

        private void GarantirPermissaoDeEscrita()
        {
            // Usando a nova inteligência da SessaoSistema
            if (!SessaoSistema.PodeEscrever)
                throw new UnauthorizedAccessException("Seu papel (Visualizador) não permite cadastrar ou alterar Itens.");
        }

        private void ValidarDados(string nome, decimal valor)
        {
            // Suas regras de negócio originais intactas
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do item é obrigatório.");

            if (valor < 0)
                throw new ArgumentException("O valor da diária não pode ser negativo.");
        }
    }
}
