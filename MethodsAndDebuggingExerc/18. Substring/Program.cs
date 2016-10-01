using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        //  const char Search = 'р';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {

                hasMatch = true;

                int letters = jump + 1;

                if (letters >= text.Length - i)
                {
                    letters = text.Length - i;
                }

                string matchedString = text.Substring(i, letters);
                Console.WriteLine(matchedString);
                i += jump;
            }

        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}