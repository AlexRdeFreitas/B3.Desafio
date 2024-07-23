using B3.Desafio.API.Commands;
using B3.Desafio.API.Service;
using B3.Desafio.API.Validator;
using Microsoft.AspNetCore.Mvc;

namespace B3.Desafio.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class B3CdbController : ControllerBase
    {
        private readonly IInvestmentService _investmentService;
        public B3CdbController(IInvestmentService investmentService)
        {
            _investmentService = investmentService;
        }

        [HttpPost("calculate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(InvestmentResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<InvestmentResult> CalculateInvestment([FromBody] InvestmentRequest request)
        {

            var validator = new InvestmentRequestValidator();
            var resultValidate = validator.Validate(request);
            if (!resultValidate.IsValid)
                return BadRequest(resultValidate.Errors);

            var result = _investmentService.CalculateInvestment(request);

            return Ok(result);
        }

    }



}