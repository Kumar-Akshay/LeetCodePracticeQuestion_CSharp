using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution
{
    public static class TwoSum
    {
        public static int[] Solve()
        {
            var arr = new List<int>() { 3, 3 };
            var target = 6;

            //Create the HashMap using Dictionary in C#
            var seen = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                var left = target - arr[i];
                if (seen.ContainsValue(left))
                {
                    var index = seen.FirstOrDefault(p => p.Value == left).Key;
                    return new int[] { index, i };
                }
                else
                    seen.Add(i, arr[i]);
            }
            return Array.Empty<int>();
        }
    }
}
