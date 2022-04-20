using System.Collections;
using System.Collections.Generic;

namespace Estoque.Models
{
    public class EstoqueProduto
    {
        public string Uuid { get; set; }
        private string Cd { get; set; }
        private decimal Quantidade { get; set; }
        public decimal Reservado { get; set; }

        public IEnumerable<EstoqueProduto> GetMock()
        {
            return new List<EstoqueProduto>()
            {
                new EstoqueProduto()
                {
                    Uuid = "d7212068-456a-46b6-8f07-65d046141d16",
                    Cd = "ES",
                    Quantidade = 25,
                    Reservado = 0
                },
                new EstoqueProduto()
                {
                    Uuid = "9aaf80d4-701d-4788-b57a-03d25f3e0577",
                    Cd = "PR",
                    Quantidade = 12,
                    Reservado = 10
                }
            };
        }
    }
}