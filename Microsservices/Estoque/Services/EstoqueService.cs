using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Estoque.Models;
using Estoque.Services.Interfaces;

namespace Estoque.Services
{
    public class EstoqueService : IEstoqueService
    {
        public IEnumerable<EstoqueProduto> BuscarEstoqueProdutos()
        {
            var estoque = new EstoqueProduto();
            return estoque.GetMock();
        }

        public EstoqueProduto BuscarEstoquePorUuid(string uuid)
        {
            var estoque = new EstoqueProduto();
            var estoqueDisponiveis = estoque.GetMock();

            return estoqueDisponiveis.FirstOrDefault(x => x.Uuid.Equals(uuid));
        }
    }
}