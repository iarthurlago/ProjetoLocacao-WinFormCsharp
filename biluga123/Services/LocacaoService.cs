using System;
using SystemyLocacao.Repositorios;

// Alias resolve CS0118: evita conflito entre o namespace "SystemyLocacao.Classes.Locacao"
// e a classe "Locacao" dentro dele.
using EntidadeLocacao = SystemyLocacao.Classes.Locacao;

// Using explícito resolve CS0229: garante que SessaoSistema vem de um único lugar.
using SystemyLocacao.Services;

namespace SystemyLocacao.Services
{
    public class LocacaoService
    {
        private readonly LocacaoRepository _repository;

        public LocacaoService()
        {
            _repository = new LocacaoRepository();
        }

        public void CadastrarLocacao(EntidadeLocacao locacao)
        {
            GarantirPermissaoDeEscrita();
            ValidarDados(locacao);

            _repository.Inserir(locacao);
        }

        // --- MÉTODOS PRIVADOS DE APOIO ---

        private void GarantirPermissaoDeEscrita()
        {
            if (!SessaoSistema.PodeEscrever)
                throw new UnauthorizedAccessException("Acesso Negado: Seu papel (Visualizador) não permite gerar novas locações.");
        }

        private void ValidarDados(EntidadeLocacao locacao)
        {
            if (locacao.ClienteLocacao == null)
                throw new ArgumentException("É obrigatório selecionar um cliente para a locação.");

            if (locacao.ItemLocacao == null)
                throw new ArgumentException("É obrigatório selecionar um item para a locação.");

            if (locacao.DataRetirada.Date > locacao.DataPrevistaDevolucao.Date)
                throw new ArgumentException("A data de retirada não pode ser posterior à data prevista de devolução.");
        }
    }
}
