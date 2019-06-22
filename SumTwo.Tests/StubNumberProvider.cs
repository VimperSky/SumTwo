namespace SumTwo.Tests
{
    public class StubNumberProvider : INumberProvider
    {
        public StubNumberProvider(int a, int b)
        {
            A = a;
            B = b;
        }
        public int A { get; }
        public int B { get; }
    }
}