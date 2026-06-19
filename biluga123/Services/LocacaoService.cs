using System;
using System.Collections.Generic;
using System.Text;
using Locacao.Classes;
using SystemyLocacao.Classes;

using System;

namespace SystemyLocacao.Services
{
    public class LocacaoService
    {
        // private readonly LocacaoRepository _repository;

        public LocacaoService()
        {
            // _repository = new LocacaoRepository();
        }

        public void CadastrarLocacao(SystemyLocacao.Classes.Locacao locacao)
        {
            // O fluxo fica limpo e legível
            GarantirPermissaoDeEscrita();
            ValidarDados(locacao);

            // _repository.Inserir(locacao);
        }

        // --- MÉTODOS PRIVADOS DE APOIO ---

        private void GarantirPermissaoDeEscrita()
        {
            if (!SessaoSistema.PodeEscrever)
            {
                throw new UnauthorizedAccessException("Acesso Negado: Seu papel (Visualizador) não permite gerar novas locações.");
            }
        }

        private void ValidarDados(SystemyLocacao.Classes.Locacao locacao)
        {
            if (locacao.ClienteLocacao == null)
                throw new ArgumentException("É obrigatório selecionar um cliente para a locação.");

            if (locacao.ItemLocacao == null)
                throw new ArgumentException("É obrigatório selecionar um item para a locação.");

            // Regra: A data inicial não pode ser maior que a final.
            // O .Date garante que estamos comparando apenas os dias, ignorando as horas.
            if (locacao.DataRetirada.Date > locacao.DataPrevistaDevolucao.Date)
                throw new ArgumentException("A data de retirada não pode ser posterior à data prevista de devolução.");
        }
    }
}