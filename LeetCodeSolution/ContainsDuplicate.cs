using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution
{
    public static class ContainsDuplicate
    {
        public static bool Solve()
        {
            var nums = new int[] { 1, 2, 3, 1 };

            #region Solutions 1
            var hash = new HashSet<int>();
            foreach (var x in nums)
            {
                if (hash.Contains(x))
                {
                    return true;
                }
                hash.Add(x);
            }
            #endregion

            #region Solutions 2

            for (int i = 0; i < nums.Length; i++)
            {
                for(int j=0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        return true;
                    }
                }
            }
            return false;
            #endregion
        }
    }
}
