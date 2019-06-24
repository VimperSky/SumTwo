using System;

namespace SumTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var provider = CommandArgumentsNumberProvider.Create(args);
                var calc = new Calculator(provider);
                var sum = calc.Sum();
                Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
