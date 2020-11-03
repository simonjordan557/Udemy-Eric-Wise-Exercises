using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fix23Library
{
    public class Evaluator
    {
        public int[] Fix23(int[] arr)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 3)
                {
                    resultList.Add(arr[i]);
                }

                else
                {
                    if (arr[i - 1] == 2 && i > 0)
                    {
                        resultList.Add(0);
                    }

                    else
                    {
                        resultList.Add(arr[i]);
                    }
                }
            }

            return resultList.ToArray();  
        }
    }
}
