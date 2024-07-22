using B3.Desafio.API.Commands;
using B3.Desafio.API.Utils;
using Microsoft.AspNetCore.Mvc;

namespace B3.Desafio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class B3CdbController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult CalculateInvestment([FromBody] InvestmentRequest request)
        {
            if (request.Amount <= 0 || request.Months <= 1)
            {
                return BadRequest("Invalid input values");
            }

            var grossInvestment = Calculate.CalculateGrossInvestment(request.Amount, request.Months);
            var netInvestment = Calculate.CalculateNetInvestment(grossInvestment);

            var result = new InvestmentResponse
            {
                GrossInvestment = grossInvestment,
                NetInvestment = netInvestment
            };

            return Ok(result);
        }

    }



}