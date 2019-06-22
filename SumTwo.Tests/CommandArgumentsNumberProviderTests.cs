using Xunit;

namespace SumTwo.Tests
{
    public class CommandArgumentsNumberProviderTests
    {
        [Fact]
        public void TestStringToIntBackConverting()
        {
            var args = new string[2] {"2", "3"};
            var provider = new CommandArgumentsNumberProvider().Create(args);
            Assert.True(provider.A.ToString() == args[0] && provider.B.ToString() == args[1]);
        }

        [Fact]
        public void TestStringToIntConverting()
        {
            var args = new string[2] {"2", "3"};
            var provider = new CommandArgumentsNumberProvider().Create(args);
            Assert.True(provider.A == 2 && provider.B == 3);
        }
    }
}