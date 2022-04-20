using System.Collections.Generic;
using Precificacao.Models;

namespace Precificacao.Services.Interfaces
{
    public interface IPrecoService
    {
        IEnumerable<PrecoProduto> GetAll();
        PrecoProduto GetByUuid(string uuid);
        public IEnumerable<PrecoProduto> GetPromos();
    }
}