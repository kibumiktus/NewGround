using System.Linq;
using Xunit;

namespace NewGround.Test
{
    public class IntegerSearchLogicTest
    {
        private readonly IntegerSearchLogic _logic;

        public IntegerSearchLogicTest()
        {
            _logic = new IntegerSearchLogic();
        }

        [Theory]
        [InlineData(new[] { 1, 2, 2, 3, 4, 6 }, 5)]
        [InlineData(new[] { -1, 8, -3, 2, 2, 3, 4, 6 }, 1)]
        [InlineData(new[] { -1, 5, 2, 3,  1 ,-2}, 4)]

        public void PositiveTest(int[] inputData, int expectedResult)
        {
            var testData = inputData.ToList();
            var actualResult = _logic.GetSmallestAbsentPositiveInteger(testData);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}