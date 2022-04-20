using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Precificacao.Models;
using Precificacao.Services.Interfaces;

namespace Precificacao.Services
{
    public class PrecoService : IPrecoService
    {
        public IEnumerable<PrecoProduto> GetAll()
        {
            var precos = new PrecoProduto();
            return precos.GetMock();
        }

        public PrecoProduto GetByUuid(string uuid)
        {
            var precos = new PrecoProduto().GetMock();
            return precos.FirstOrDefault(x => x.Uuid.Equals(uuid));
        }

        public IEnumerable<PrecoProduto> GetPromos()
        {
            var precos = new PrecoProduto().GetMock();
            return precos.Where(x => x.Promocao).ToList();
        }
    }
}