using System;
using System.Collections.Generic;

namespace NewGround
{
    public class IntegerSearchLogic
    {
        public int GetSmallestAbsentPositiveInteger(List<int> list)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (!list.Contains(i))
                    return i;
            }
            throw new Exception("Integer hasn`t not found");
        }
    }
}