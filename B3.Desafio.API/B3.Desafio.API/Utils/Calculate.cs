namespace B3.Desafio.API.Utils
{
    public static class Calculate
    {

        private const double CDI = 0.009;
        private const double TB = 1.08;

        public static double CalculateFinalValue(double initialValue, int months)
        {
            double finalValue = initialValue;

            for (int i = 0; i < months; i++)
            {
                finalValue *= (1 + (CDI * TB));
            }

            return finalValue;
        }

        // Method to calculate the tax
        public static double CalculateTax(double initialValue, double finalValue, int months)
        {
            double earnings = finalValue - initialValue;
            double taxRate = 0.0;

            if (months <= 6)
            {
                taxRate = 0.225;  // 22.5%
            }
            else if (months <= 12)
            {
                taxRate = 0.20;  // 20%
            }
            else if (months <= 24)
            {
                taxRate = 0.175;  // 17.5%
            }
            else
            {
                taxRate = 0.15;  // 15%
            }

            return earnings * taxRate;
        }
    }
}
