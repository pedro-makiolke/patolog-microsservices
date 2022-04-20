using System;
using System.Collections;
using System.Collections.Generic;

namespace Precificacao.Models
{
    public class PrecoProduto
    {
        public string Uuid { get; set; }
        public decimal Valor { get; set; }
        public bool Promocao { get; set; }
        public PromocaoProduto DetalhePromocao { get; set; }


        public IEnumerable<PrecoProduto> GetMock()
        {
            return new List<PrecoProduto>()
            {
                new PrecoProduto()
                {
                    Uuid = "d7212068-456a-46b6-8f07-65d046141d16",
                    Valor = 75,
                    Promocao = false,
                    DetalhePromocao = null
                },
                new PrecoProduto()
                {
                    Uuid = "9aaf80d4-701d-4788-b57a-03d25f3e0577",
                    Valor = (decimal) 128.23,
                    Promocao = true,
                    DetalhePromocao = new PromocaoProduto()
                    {
                        InicioPromocao = DateTime.Now.AddDays(-5),
                        FimPromocao = DateTime.Now,
                        ValorPromocional = 100
                    }
                }
            };
        }
    }
}