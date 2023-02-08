using System;

namespace ConsoleApplication2.Seminars
{
    public class SeminarThree
    {
        public static void GetQubeTable()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("input your number: ");
            int g = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= g; i++)
            {

                Console.WriteLine($"qube is {i * i * i}");
            }
        }
        //Task 19
        public static void IsPalindrome()
        {
            int num, res, temp, rem = 0;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("input number: ");
            num = Int32.Parse(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                res = num % 10;
                rem = (rem * 10) + res;
                num = num / 10;
            }
            if (temp == rem && temp >= 10000 && temp <= 99999) Console.WriteLine($"Number {temp} is Palindrome");
            else Console.WriteLine($"{temp} not a Palindrome");
        }


        public static void Get3DPoint(int xa,int xb,int ya,int yb,int za,int zb )
        {
           
            double res = Math.Sqrt((((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za))));
            Console.WriteLine($"distantion between points a,b, c, d, e and f equals {res}");
        }
    }
}