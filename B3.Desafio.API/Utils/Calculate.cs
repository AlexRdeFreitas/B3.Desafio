namespace B3.Desafio.API.Utils
{
    public static class Calculate
    {
        public static double CalculateGrossInvestment(double amount, int months)
        {
            const double rate = 0.01; // Exemplo de taxa de 1% ao mês
            return amount * Math.Pow(1 + rate, months);
        }

        public static double CalculateNetInvestment(double grossAmount)
        {
            const double taxRate = 0.15; // Exemplo de taxa de imposto de 15%
            return grossAmount * (1 - taxRate);
        }

    }
}
