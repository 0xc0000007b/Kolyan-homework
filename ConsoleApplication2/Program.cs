using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using ConsoleApplication2.Seminars;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static SeminarOne _semOne = new SeminarOne();
        public static void Main(string[] args)
        {
           
            
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
          
            int number = int.Parse(Console.ReadLine());

            var count = GetValue(number);

            Console.WriteLine($"Количество необходимых действий над числом - {count}");       
        }

        private static int GetValue(int number)
        {
            var count = 0;

            if (number == 1) return 0;
            else
            {
                count = 1;
                count += number % 2 == 0 ? GetValue(number >> 1) : GetValue(number * 3 + 1);
            }

            return count;
        }
        // double sum = 0;
            // for(int i = 0; i > startValue && i < endValue; i++)
            // {
            //
            //     sum += (double)i;
            // }
            // Enumerable
            //
            // var answer = Math.Ceiling(sum / 4.66981132075472);
            //
            //
            // Console.WriteLine($"Сумма простых чисел = {answer}");
        }

        // private static string FindDuplicates( string num, string numOne)
        // {
        //     var res = string.Empty;
        //     var num_arr = num.ToArray();
        //     num_arr.Intersect(numOne.ToArray()).ToList().ForEach(number =>
        //     {
        //         Enumerable.Range(0, num_arr.Count(n => n == number)).Select(n => number).ToList().ForEach(n => res += n + " ");
        //         res += "\r\n";
        //     });
        //     return res;
        // }

        // Console.Write("input your number ");
            // var num = int.Parse(Console.ReadLine());
            // Console.Write("input your second number ");
            // var numOne = int.Parse(Console.ReadLine());
            // for (int i = 1; i < num; i++)
            // {
            //     Console.Write($" {i}");
            // }
            // _semOne.FindMax(num, numOne); // first task
            // _semOne.FindMaxFromThree(num, numOne); // second Task
        }

        
    
