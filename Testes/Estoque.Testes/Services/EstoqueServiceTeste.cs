using Estoque.Services;
using Xunit;

namespace Testes.Estoque.Testes.Services
{
    public class EstoqueServiceTeste
    {
        [Fact]
        public void BuscarEstoqueProdutos()
        {
            //When
            var estoque = new EstoqueService().BuscarEstoqueProdutos();
            
            //Then
            Assert.NotNull(estoque);
        }

        [Fact]
        public void BuscarEstoquePorUuidComRetornoNaoNulo()
        {
            //When
            var uuidTeste = "d7212068-456a-46b6-8f07-65d046141d16";
            var estoqueNaoNulo = new EstoqueService().BuscarEstoquePorUuid(uuidTeste);

            //Then
            Assert.NotNull(estoqueNaoNulo);
        }
        
        [Fact]
        public void BuscarEstoquePorUuidComRetornoNulo()
        {
            //When
            var uuidTeste = "";
            var estoqueNulo = new EstoqueService().BuscarEstoquePorUuid(uuidTeste);
            
            //Then
            Assert.Null(estoqueNulo);
        }
    }
}