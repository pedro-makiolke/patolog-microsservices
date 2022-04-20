using System;

namespace Precificacao.Models
{
    public class PromocaoProduto
    {
        public DateTime InicioPromocao { get; set; }
        public DateTime FimPromocao { get; set; }
        public decimal ValorPromocional { get; set; }
    }
}