using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            int[] result = ExtractMissleElemens(nums);

            Console.WriteLine("{ " + string.Join(", ", result) + " }");
        }

        private static int[] ExtractMissleElemens(int[] nums)
        {
            int len = nums.Length;
            if (nums.Length == 1)
            {
                return nums;
            }
            if (nums.Length % 2 == 0)
            {
                return new int[] { nums[len / 2 - 1], nums[len / 2] };
            }
            return new int[] { nums[len / 2 - 1], nums[len / 2], nums[len / 2 + 1]};
        }
    }
}
