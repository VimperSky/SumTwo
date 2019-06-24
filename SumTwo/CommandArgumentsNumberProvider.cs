using System;

namespace SumTwo
{
    public class CommandArgumentsNumberProvider : INumberProvider
    {
        public int A { get; }
        public int B { get; }

        public CommandArgumentsNumberProvider(int a, int b)
        {
            A = a;
            B = b;
        }

        public static INumberProvider Create(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                var provider = new CommandArgumentsNumberProvider(a, b);
                return provider;
            }
            catch
            {
                throw new NumberException("Can't convert to int32");
            }
        }
    }
}