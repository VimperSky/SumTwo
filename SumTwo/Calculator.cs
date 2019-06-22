namespace SumTwo
{
    public class Calculator
    {
        private readonly INumberProvider numberProvider;
        public Calculator(INumberProvider numberProvider)
        {
            this.numberProvider = numberProvider;
        }

        public int Sum()
        {
            return numberProvider.A + numberProvider.B;
        }
    }
}