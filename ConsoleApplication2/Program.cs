using System;
using System.Text;
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
            Console.Write("input your number ");
            var num = int.Parse(Console.ReadLine());
            Console.Write("input your second number ");
            var numOne = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                Console.Write($" {i}");
            }
            _semOne.FindMax(num, numOne); // first task
            _semOne.FindMaxFromThree(num, numOne); // second Task
        }

        
    }
}