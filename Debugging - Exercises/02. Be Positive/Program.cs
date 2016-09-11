﻿using System;
using System.Collections.Generic;

public class BePositive_broken
{
	public static void Main()
	{
		int countSequences = int.Parse(Console.ReadLine());
        //четене се всчики редове
		for (int i = 0; i < countSequences; i++)
		{
            //четене на един ред
            string[] input = Console.ReadLine().Trim().Split(' ');
			var numbers = new List<int>();
            //махане на интервалите
			for (int j = 0; j < input.Length; j++)
			{
				if (!input[j].Equals(string.Empty))
				{
					int num = int.Parse(input[j]);
					numbers.Add(num);
				}
			}
            // намерено е число
            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
			{
                
                int currentNum = numbers[j];

				if (currentNum >= 0)
				{
					if (found)
						{
							Console.Write(" ");
						}

						Console.Write(currentNum);

						found = true;
				}
				else
				{
                    if (j < numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];
                    }
                    j++;
					if (currentNum >= 0)
					{
						if (found)
						{
							Console.Write(" ");
						}

						Console.Write(currentNum);

						found = true;
					}
				}
			}

			if (!found)
			{
				Console.WriteLine("(empty)");
			}
            else
            {
                Console.WriteLine();
            }
		}
	}
}