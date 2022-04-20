using System.Collections.Generic;

namespace Produto.Models
{
    public class Item
    {
        public string Uuid { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public string Ean { get; set; }

        public IEnumerable<Item> GetMock()
        {
            return new List<Item>()
            {
                new Item()
                {
                    Uuid = "d7212068-456a-46b6-8f07-65d046141d16",
                    Descricao = "Secador de Cabelo MC'Donalds",
                    Codigo = "SCM001",
                    Ean = "978020137962"
                },
                new Item()
                {
                    Uuid = "9aaf80d4-701d-4788-b57a-03d25f3e0577",
                    Descricao = "Molhador de Cabelo BurguerKing",
                    Codigo = "MCB001",
                    Ean = "789020137269"
                }
            };
        }
    }
}