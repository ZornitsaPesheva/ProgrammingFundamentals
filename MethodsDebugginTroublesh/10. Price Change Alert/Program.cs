using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double secondPrice = double.Parse(Console.ReadLine());
            double diff = Proc(firstPrice, secondPrice);
            bool minorDiff = MinorDiff(diff, treshold);
            string message = Get(secondPrice, firstPrice, diff, minorDiff);
            Console.WriteLine(message);

            firstPrice = secondPrice;
        }
    }

    private static string Get(double firstNumber, double secondNumber, double difference, bool minorDiff)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", firstNumber);
        }
        else if (!minorDiff)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", secondNumber, firstNumber, difference*100);
        }
        else if (minorDiff && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", secondNumber, firstNumber, difference*100);
        }
        else if (minorDiff && (difference < 0))
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", secondNumber, firstNumber, difference*100);
        return result;
    }

    private static bool MinorDiff(double treshold, double diff)
    {
        if (Math.Abs(treshold) >= diff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double firstNumber, double secondNumber)
    {
        double r = (secondNumber - firstNumber) / firstNumber;
        return r;
    }
}
