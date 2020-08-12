using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NewGround.Test
{
    public class UniqueLogicTest
    {
        private readonly UniqueLogic _logic;

        public UniqueLogicTest()
        {
            _logic = new UniqueLogic();
        }

        [Theory]
        [InlineData(1, 3)]
        [InlineData(3, 2, 3)]
        [InlineData(3, 2, -1, 3)]
        [InlineData(3, 2, 3, 1, 2, 5, 2)]
        public void PositiveTest(params int[] inputData)
        {
            var testData = inputData.ToList();
            _logic.RemoveDuplicates(testData);
            Enumerable.SequenceEqual(inputData.Distinct(), testData);
        }
    }
}
