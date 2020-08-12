using System.Linq;
using Xunit;

namespace NewGround.Test
{
    public class IntegerDirectionLogicTest
    {
        private readonly IntegerDirectionLogic _logic;

        public IntegerDirectionLogicTest()
        {
            _logic = new IntegerDirectionLogic();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(12, 21)]
        [InlineData(123, 321)]
        [InlineData(1234, 4321)]
        public void PositiveTest(int test, int expected)
        {
            var result = _logic.GerReverse(test);
            Assert.Equal(expected, result);
        }
    }
}