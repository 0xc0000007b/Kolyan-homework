using System;

namespace ConsoleApplication2.Seminars
{
    public class SeminarOne
    {
        public void FindMaxFromThree(int num, int numOne)
        {
            Console.Write("input your second number ");
            var numTwo = int.Parse(Console.ReadLine());
            var max = Math.Max(num, Math.Max(numOne, numTwo));
            Console.WriteLine("max -> " + max);
        }

        public void FindMax(int num,  int numOne)
        {
            var max = Math.Max(num, numOne);
            Console.WriteLine($"max -> {max * -1}");
            
        }
    }
}