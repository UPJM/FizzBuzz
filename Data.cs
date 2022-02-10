using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Data
    {
        public static List<int> DataList(int a, int b)
        {
            var list = new List<int>();

            if (a < b)
            {
                
                for (var i = a; i <= b; i++)
                {
                    list.Add(i);
                }
                return list;
            }
            else
            {
                return list;
            }

        }
    }
}
