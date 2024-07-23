namespace B3.Desafio.API.Utils
{
    public static class Calculate
    {
        public static double GetTaxRate(int months)
        {
            if (months <= 6)
            {
                return 0.225;
            }
            if (months <= 12)
            {
                return 0.20;
            }
            if (months <= 24)
            {
                return 0.175;
            }
            return 0.15;
        }
    }
}
