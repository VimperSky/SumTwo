using System;

namespace SumTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sum = Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]);
                Console.WriteLine(sum.ToString());
            }
            catch
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
