using B3.Desafio.API.Commands;
using B3.Desafio.API.Controllers;
using B3.Desafio.API.Service;
using B3.Desafio.API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Desafio.Tests
{
    public class InvestmentCalculateControllerTests
    {
        private readonly B3CdbController _controller;
        private readonly IInvestmentService _investmentService;
        public InvestmentCalculateControllerTests()
        {

            var serviceCollection = new ServiceCollection();
            StaticMethod.ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolução da dependência
            _investmentService = serviceProvider.GetRequiredService<IInvestmentService>();

            _controller = new B3CdbController(_investmentService);
        }


        [Fact]
        public void CalculateInvestmentUntil06_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 6 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var response = Assert.IsType<InvestmentResult>(okResult.Value);

            Assert.Equal(1059.7556770148981, response.GrossValue, 2);
            Assert.Equal(821.31064968654607, response.NetValue, 2);
        }


        [Fact]
        public void CalculateInvestmentUntil12_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 12 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var response = Assert.IsType<InvestmentResult>(okResult.Value);

            Assert.Equal(1123.0820949653053, response.GrossValue, 2);
            Assert.Equal(898.4656759722443, response.NetValue, 2);
        }
        [Fact]
        public void CalculateInvestmentUntil24_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 24 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var response = Assert.IsType<InvestmentResult>(okResult.Value);

            Assert.Equal(1261.3133920316586, response.GrossValue, 2);
            Assert.Equal(1040.5835484261183, response.NetValue, 2);
        }
        [Fact]
        public void CalculateInvestmentUntil36_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 36 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var response = Assert.IsType<InvestmentResult>(okResult.Value);

            Assert.Equal(1416.5584867307102, response.GrossValue, 2);
            Assert.Equal(1204.0747137211038, response.NetValue, 2);
        }




    }

}