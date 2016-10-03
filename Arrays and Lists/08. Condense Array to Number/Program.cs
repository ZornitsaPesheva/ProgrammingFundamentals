using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            while (nums.Length >= 2)
            {
                int[] result = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
