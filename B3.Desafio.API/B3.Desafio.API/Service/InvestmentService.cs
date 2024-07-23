using B3.Desafio.API.Commands;
using B3.Desafio.API.Utils;

namespace B3.Desafio.API.Service
{
    public class InvestmentService : IInvestmentService
    {
        private const double CDI = 0.009;
        private const double TB = 1.08;

        public InvestmentResult CalculateInvestment(InvestmentRequest request)
        {
            double grossValue = request.InitialValue;
            for (int i = 0; i < request.Months; i++)
            {
                grossValue *= (1 + (CDI * TB));
            }

            double taxRate = Calculate.GetTaxRate(request.Months);
            double netValue = grossValue * (1 - taxRate);

            return new InvestmentResult
            {
                GrossValue = grossValue,
                NetValue = netValue
            };
        }


    }

}
