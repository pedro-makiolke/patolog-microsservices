using System.Collections.Generic;
using Produto.Models;

namespace Produto.Services.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<Item> GetAll();

        Item GetByUuid(string uuid);
    }
}