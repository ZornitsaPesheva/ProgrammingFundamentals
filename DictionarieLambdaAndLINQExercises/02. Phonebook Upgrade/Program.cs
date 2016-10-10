using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            string entry = " ";
            var phone = new string[3];
            while (!entry.Equals("END"))
            {
                entry = Console.ReadLine();
                if (entry.Equals("ListAll"))
                {
                    foreach (var record in phonebook)
                    {
                        Console.WriteLine($"{record.Key} -> {record.Value}");
                    }
                }
                else
                {
                    phone = entry.Split(' ').ToArray();
                    if (phone[0] == "A")
                    {
                        phonebook[phone[1]] = phone[2];
                    }
                    else if (phone[0] == "S")
                    {
                        if (phonebook.ContainsKey(phone[1]))
                        {
                            Console.WriteLine($"{phone[1]} -> {phonebook[phone[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {phone[1]} does not exist.");
                        }
                    }
                }

            }
        }
    }
}
