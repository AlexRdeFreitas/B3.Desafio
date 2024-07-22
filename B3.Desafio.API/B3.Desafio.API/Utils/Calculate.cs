namespace B3.Desafio.API.Utils
{
    public static class Calculate
    {
        private static double percentCdi = 0.009;
        private static double percentTb = 1.08;

        public static double CalculateCDB(double amount, int months)
        {
            double result = amount;

            for (int i = 0; i < months; i++)
            {
                result *= 1 + percentCdi * percentTb;
            }

            return result;
        }

    }
}
