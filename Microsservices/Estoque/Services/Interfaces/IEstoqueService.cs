using System.Collections.Generic;
using Estoque.Models;

namespace Estoque.Services.Interfaces
{
    public interface IEstoqueService
    {
        IEnumerable<EstoqueProduto> BuscarEstoqueProdutos();
        EstoqueProduto BuscarEstoquePorUuid(string uuid);
    }
}