using System;
using System.Linq;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        //  string command = Console.ReadLine();
        string command = "";
        while (!command.Equals("stop"))
        {
            string[] line = Console.ReadLine().Trim().Split(' ').ToArray();
            command = line[0];
            if (command.Equals("stop"))
            {
                break;
            }
            //      string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                //  string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);

                //   PerformAction(array, command, args);
            }

            PerformAction(array, command, args);

            PrintArray(array);
            Console.WriteLine();

            // command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        //   long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {

        var x = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = x;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        var x = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = x;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}