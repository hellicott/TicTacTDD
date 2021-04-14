using Xunit;
using TicTacToe;

namespace TicTacToeTest
{
    public class HelloWorldTest
    {

        [Fact]
        public void TestHelloWorld()
        {
            //arrange
            HelloWorldClass helloWorld = new HelloWorldClass();

            //act
            var returnedString = helloWorld.HelloWorld();

            //assert
            Assert.Equal("Hello, World!", returnedString);
        }
    }
}
