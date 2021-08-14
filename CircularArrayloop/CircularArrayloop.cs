using System;
using System.Collections.Generic;

namespace CircularArrayloop
{
    class CircularArrayloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CircularArrayloop circularArrayloop = new CircularArrayloop();
            int [] numstest1 = { 2, -1, 1, 2, 2 };
            int [] numstest2 = { -1, 2 };
            int [] numstest3 = { -2, 1, -1, -2, -2 };
            Console.WriteLine(circularArrayloop.CircularArrayLoop(numstest1));
            Console.WriteLine(circularArrayloop.CircularArrayLoop(numstest2));
            Console.WriteLine(circularArrayloop.CircularArrayLoop(numstest3));
        }

        public CircularArrayloop()
        {

        }

        public bool CircularArrayLoop(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            bool negative = nums[0] < 0;
            int i = 0;
            while (i < nums.Length)
            {
                if (set.Contains(i))
                {
                    break;
                }
                int temp = nums[i];
                set.Add(i);
                if (temp < 0)
                {
                    i = i - temp;
                    if (i < 0)
                    {
                        i = nums.Length - 1 + i;
                    }
                }
                else
                {
                    i = i + temp;
                    if(i > nums.Length - 1)
                    {
                        i = i - nums.Length;
                    }
                }
            }

            if (set.Count == 1)
            {
                return false;
            }
            int count = 0;
            bool isFirstValue = true;
            foreach (var val in set)
            {
                if (isFirstValue && val < 0)
                {
                    negative = true;
                }
                else if(negative && val > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
