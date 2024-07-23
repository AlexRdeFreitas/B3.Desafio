using B3.Desafio.API.Commands;
using B3.Desafio.API.Controllers;
using B3.Desafio.API.Service;
using B3.Desafio.API.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Desafio.Tests
{
    public class InvestmentControllerTests
    {
        private readonly B3CdbController _controller;
        private readonly IInvestmentService _investmentService;
        public InvestmentControllerTests()
        {

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolução da dependência
            _investmentService = serviceProvider.GetRequiredService<IInvestmentService>();

            _controller = new B3CdbController(_investmentService);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Adicione os serviços necessários aqui
            services.AddTransient<IInvestmentService, InvestmentService>();
            // Adicione outros serviços e configurações conforme necessário
        }

        [Fact]
        public void CalculateInvestment_InvalidAmount_ReturnsBadRequest()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = -1, Months = 12 };

            // Act
            var result = _controller.CalculateInvestment(request);
            var badResult = Assert.IsType<BadRequestObjectResult>(result.Result);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResult);
        }

        [Fact]
        public void CalculateInvestment_InvalidMonths_ReturnsBadRequest()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 1 };

            // Act
            var result = _controller.CalculateInvestment(request);
            var badResult = Assert.IsType<BadRequestObjectResult>(result.Result);


            // Assert
            Assert.IsType<BadRequestObjectResult>(badResult);
        }


        [Fact]
        public void CalculateInvestment_InvalidMonths_ReturnsOkRequest()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = 1000, Months = 2 };

            // Act
            var result = _controller.CalculateInvestment(request);
            var badResult = Assert.IsType<OkObjectResult>(result.Result);


            // Assert
            Assert.IsType<OkObjectResult>(badResult);
        }

    }

}