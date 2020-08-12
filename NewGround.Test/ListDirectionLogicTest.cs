using System.Linq;
using Xunit;

namespace NewGround.Test
{
    public class ListDirectionLogicTest
    {
        private readonly ListDirectionLogic _logic;

        public ListDirectionLogicTest()
        {
            _logic = new ListDirectionLogic();
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 2, -1, 3)]
        [InlineData(3, 2, -1, 99, 8)]
        [InlineData(3, 2, 3, 1, 2, 5, 2)]
        public void PositiveTest(params int[] inputData)
        {
            var testData = inputData.ToList();
            _logic.Reverse(testData);
            Assert.Equal(inputData.Length, testData.Count);
            var expectedData = inputData.Reverse().ToArray();
            for (int i = 0; i < expectedData.Length; i++)
            {
                Assert.Equal(expectedData[i], testData[i]);
            }
        }
    }
}