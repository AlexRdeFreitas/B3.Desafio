using B3.Desafio.API.Commands;
using FluentValidation;

namespace B3.Desafio.API.Validator
{
    public class InvestmentRequestValidator : AbstractValidator<InvestmentRequest>
    {

        public InvestmentRequestValidator()
        {

            RuleFor(request => request.InitialValue)
                       .GreaterThan(0).WithMessage("O valor inicial deve ser maior que zero!");


            RuleFor(request => request.Months)
                .GreaterThan(1).WithMessage("Os meses devem ser maiores que 1!");
        }

    }
}
