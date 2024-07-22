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
                return BadRequest("Valores inválidos");
            }

            var resultValue = Calculate.CalculateCDB(request.Amount, request.Months);

            var result = new InvestmentResponse
            {
                Value = resultValue
            };

            return Ok(result);
        }

    }



}