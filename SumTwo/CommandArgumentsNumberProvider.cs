using System;

namespace SumTwo
{
    public class CommandArgumentsNumberProvider : INumberProvider
    {
        public int A { get; set;}
        public int B { get; set; }

        public INumberProvider Create(string[] args)
        {
            var provider = new CommandArgumentsNumberProvider();
            provider.A = Convert.ToInt32(args[0]);
            provider.B = Convert.ToInt32(args[1]);
            return provider;
        }
    }
}