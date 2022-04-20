using System.Net;
using Estoque.Controllers;
using Estoque.Services;
using Estoque.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Testes.Estoque.Testes.Controllers
{
    public class EstoqueControllerTeste
    {
        [Fact]
        public void GetAllNaoNuloComRetornoOk()
        {
            //Given
            var mockInjecao = new Mock<IEstoqueService>();
            var esperado = new EstoqueService().BuscarEstoqueProdutos();
            mockInjecao.Setup(x => x.BuscarEstoqueProdutos()).Returns(esperado);
            var controller = new EstoqueController(mockInjecao.Object);

            //When
            var retornoEndpoint = controller.GetAll();
            
            //Then
            var isOk = Assert.IsType<OkObjectResult>(retornoEndpoint);
            Assert.Equal(esperado, isOk.Value);
        }

        [Fact]
        public void BuscarPorUuidVazioRetornoNotFound()
        {
            //Given
            var mockInjecao = new Mock<IEstoqueService>();
            var esperado = (int)HttpStatusCode.NotFound;
            var uuidTeste = "";
            mockInjecao.Setup(x => x.BuscarEstoquePorUuid(uuidTeste));
            var controller = new EstoqueController(mockInjecao.Object);
            
            //When
            var retornoEndpoint = controller.GetById(uuidTeste);
            
            //Then
            var isNotFound = Assert.IsType<NotFoundResult>(retornoEndpoint);
            Assert.Equal(esperado, isNotFound.StatusCode);
        }
        
        [Fact]
        public void BuscarPorUuidNuloRetornoBadRequest()
        {
            //Given
            var mockInjecao = new Mock<IEstoqueService>();
            var esperado = (int)HttpStatusCode.BadRequest;
            string uuidTeste = null;
            mockInjecao.Setup(x => x.BuscarEstoquePorUuid(uuidTeste));
            var controller = new EstoqueController(mockInjecao.Object);
            
            //When
            var retornoEndpoint = controller.GetById(uuidTeste);
            
            //Then
            var isBadRequest = Assert.IsType<BadRequestResult>(retornoEndpoint);
            Assert.Equal(esperado, isBadRequest.StatusCode);
        }

        [Fact]
        public void BuscarPorUuidValidoRetornoOkComObjeto()
        {
                //Given
                var mockInjecao = new Mock<IEstoqueService>();
                int statusEsperado = 200;
                string uuidTeste = "d7212068-456a-46b6-8f07-65d046141d16";
                var objetoEsperado = new EstoqueService().BuscarEstoquePorUuid(uuidTeste);
                mockInjecao.Setup(x => x.BuscarEstoquePorUuid(uuidTeste)).Returns(objetoEsperado);
                var controller = new EstoqueController(mockInjecao.Object);
                
                //When
                var retornoEndpoint = controller.GetById(uuidTeste);
            
                //Then
                var ok = Assert.IsType<OkObjectResult>(retornoEndpoint);
                Assert.Equal(statusEsperado, ok.StatusCode);
                
                Assert.Equal(objetoEsperado, ok.Value);
        }
    }
}