using System;

namespace ConsoleApplication2.Seminars
{
    public class SeminarTwo
    {
        public static void FindSecond()
        {
            int n = int.Parse(Console.ReadLine());
            n /= 10;
            n %= 10;
            Console.WriteLine(n);
        } 
        public static void FindThird()
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 999) n /= 10;
            int g = n > 100 ?  n %= 10 : 0; // 0 equivalent is no enough numbers 
                
Console.WriteLine(g);
            
        }

        public static void CheckWeekDay()
        {
            int day;
            switch (day = int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("No day");
                    break;
            }
        }
    }
}
