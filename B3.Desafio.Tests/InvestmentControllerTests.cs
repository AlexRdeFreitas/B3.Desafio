using B3.Desafio.API.Commands;
using B3.Desafio.API.Controllers;
using B3.Desafio.API.Utils;
using Microsoft.AspNetCore.Mvc;

namespace B3.Desafio.Tests
{
    public class InvestmentControllerTests
    {
        private readonly B3CdbController _controller;

        public InvestmentControllerTests()
        {
            _controller = new B3CdbController();
        }

        [Fact]
        public void CalculateInvestment_InvalidAmount_ReturnsBadRequest()
        {
            // Arrange
            var request = new InvestmentRequest { Amount = -1, Months = 12 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void CalculateInvestment_InvalidMonths_ReturnsBadRequest()
        {
            // Arrange
            var request = new InvestmentRequest { Amount = 1000, Months = 1 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void CalculateInvestment_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var request = new InvestmentRequest { Amount = 1000, Months = 12 };

            // Act
            var result = _controller.CalculateInvestment(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var response = Assert.IsType<InvestmentResponse>(okResult.Value);

            Assert.Equal(1123.0820949653053, response.Value, 2);
        }

        [Fact]
        public void CalculateGrossInvestment_CorrectCalculation()
        {
            // Arrange
            var amount = 1000.0;
            var months = 12;
            var expected = 1123.0820949653053;

            // Act
            var result = Calculate.CalculateCDB(amount, months);

            // Assert
            Assert.Equal(expected, result, 2);
        }

    }

}