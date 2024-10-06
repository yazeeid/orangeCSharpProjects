using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num One");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num Two");
            int x2 = int.Parse(Console.ReadLine());

            int max = -9999;
            if (x1 > x2)
            {
                max = x1;
            }else max = x2;

            Console.WriteLine(max);


            Console.WriteLine("Enter num to Find sign");
            int f1 = int.Parse(Console.ReadLine());

            if (f1 > 0)
            {
                Console.WriteLine("the sign is + ");
            }
            else
            {
                Console.WriteLine("the sign is - ");
            }


       

            Console.WriteLine("Enter three numbers to sort (comma separated): ");
            string[] nums = Console.ReadLine().Split(',');
            int n1 = int.Parse(nums[0]);
            int n2 = int.Parse(nums[1]);
            int n3 = int.Parse(nums[2]);
            int[] arr = { n1, n2, n3 };
            Array.Sort(arr);
            Console.WriteLine("Sorted order: " + string.Join(", ", arr));

            Console.WriteLine("Enter five numbers to find the maximum (comma separated): ");
            string[] numsMax = Console.ReadLine().Split(',');
            int[] maxnum = Array.ConvertAll(numsMax, int.Parse);
            Console.WriteLine("Maximum number is: " + maxnum.Max());


            Console.WriteLine("Enter kilometers per hour: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            double m1 = k1 * 0.621371;
            Console.WriteLine($"{k1} km/h = {m1} miles per hour");

            Console.WriteLine("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            int totalMinutes = (hours * 60) + minutes;
            Console.WriteLine($"Total minutes: {totalMinutes}");


            Console.WriteLine("Enter total minutes: ");
            int totalMins = Convert.ToInt32(Console.ReadLine());
            int hrs = totalMins / 60;
            int mins = totalMins % 60;
            Console.WriteLine($"{hrs} Hours, {mins} Minutes");

            string[] sentences = { "yazeed", "My name is yazeed", "laravel", "hello world", "C# is c programmigng language" };
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence.PadRight(20));
            }

            Console.WriteLine("Enter a sentence to reverse odd-length words: ");
            string sentenceInput = Console.ReadLine();
            Console.WriteLine("Reversed odd-length words: " + ReverseOdd(sentenceInput));


        }
        static string ReverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }
            return string.Join(" ", words);
        }
    }
}
