using B3.Desafio.API.Commands;
using B3.Desafio.API.Utils;

namespace B3.Desafio.API.Service
{
    public class InvestmentService : IInvestmentService
    {

        public InvestmentResult CalculateInvestment(InvestmentRequest request)
        {

            double finalValue = Calculate.CalculateFinalValue(request.InitialValue, request.Months);
            double tax = Calculate.CalculateTax(request.InitialValue, finalValue, request.Months);
            double finalValueAfterTax = finalValue - tax;


            return new InvestmentResult
            {
                GrossValue = finalValue,
                NetValue = finalValueAfterTax
            };
        }


    }

}
