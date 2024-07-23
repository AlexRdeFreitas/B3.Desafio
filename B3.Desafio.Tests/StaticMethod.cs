using B3.Desafio.API.Service;
using Microsoft.Extensions.DependencyInjection;

namespace B3.Desafio.Tests
{
    public static class StaticMethod
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            // Adicione os serviços necessários aqui
            services.AddTransient<IInvestmentService, InvestmentService>();
            // Adicione outros serviços e configurações conforme necessário
        }

    }
}
