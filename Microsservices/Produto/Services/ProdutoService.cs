using System.Collections.Generic;
using System.Linq;
using Produto.Models;
using Produto.Services.Interfaces;

namespace Produto.Services
{
    public class ProdutoService : IProdutoService
    {
        public IEnumerable<Item> GetAll()
        {
            var produtos = new Item().GetMock();
            return produtos;
        }

        public Item GetByUuid(string uuid)
        {
            var produtos = new Item().GetMock();
            return produtos.FirstOrDefault(x => x.Uuid.Equals(uuid));
        }
    }
}