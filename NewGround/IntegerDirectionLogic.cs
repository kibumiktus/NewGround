using System;
using System.Collections.Generic;

namespace NewGround
{
    public class IntegerDirectionLogic
    {
        public int GerReverse(int source)
        {
            var resultDigit = source % 10;
            for (int i = 10; i <= source ; i *= 10)
            {
                int order = Math.DivRem(source, i, out int _);
                resultDigit = resultDigit * 10 + order % 10;
            }
            return resultDigit;
        }
    }
}