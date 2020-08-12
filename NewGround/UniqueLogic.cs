using System.Collections.Generic;
using System.Linq;

namespace NewGround
{
    public class UniqueLogic
    {
        public void RemoveDuplicates(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;//need check current position in next iteration because list has shifted 
                    }
                }
            }
        }
    }
}
