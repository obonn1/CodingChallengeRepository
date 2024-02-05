using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingChallengeRepository.Codewars.kyu_5
{
    internal class Solution
    {
        public static int MaxSequence(int[] arr)
        {
            var max = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var sum = arr[i];
                max = Math.Max(max, sum);
                for (var j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                    max = Math.Max(max, sum);
                }
            }
            return max;
        }
    }
}

