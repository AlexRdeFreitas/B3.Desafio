using B3.Desafio.API.Commands;

namespace B3.Desafio.API.Service
{
    public interface IInvestmentService
    {
        public InvestmentResult CalculateInvestment(InvestmentRequest request);
    }
}
