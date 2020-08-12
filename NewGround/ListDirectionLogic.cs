using System;
using System.Collections.Generic;

namespace NewGround
{
    public class ListDirectionLogic
    {
        public void Reverse(List<int> list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                var temp = list[i];
                var symetricIndex = list.Count - 1 - i;
                list[i] = list[symetricIndex];
                list[symetricIndex] = temp;
            }
        }
    }
}