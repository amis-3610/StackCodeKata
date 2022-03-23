using Xunit;

namespace StackCodeKata.Core.Tests
{
    public class StackTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var stack = new CoreStack(100);

            // Act
            stack.Push("foo");
            
            //Assert
            //TODO
        }
    }
}