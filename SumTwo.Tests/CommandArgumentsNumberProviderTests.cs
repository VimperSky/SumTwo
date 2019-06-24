using Xunit;

namespace SumTwo.Tests
{
    public class CommandArgumentsNumberProviderTests
    {
        [Fact]
        public void TestStringToIntConverting()
        {
            // arrange
            var args = new string[2] {"2", "3"};
            // act
            var provider = CommandArgumentsNumberProvider.Create(args);
            // assert
            Assert.True(provider.A == 2 && provider.B == 3);
        }

        [Fact]
        public void TestWrongSendData()
        {
            // arrange
            var args = new string[2] {"test", "kek"};
            // act & assert
            Assert.Throws<NumberException>( () => CommandArgumentsNumberProvider.Create(args));
        }
    }
}