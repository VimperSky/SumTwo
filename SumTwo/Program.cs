using System;

namespace SumTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var provider = new CommandArgumentsNumberProvider().Create(args);
                var calc = new Calculator(provider);
                var sum = calc.Sum();
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("An unhandled error happened!");
            }
        }
    }
}
