using System;

namespace ConsoleApplication2.Seminars
{
    public class Sem_9
    {
        public uint Ackerman(uint n, uint m)
        {
            if (n == 0) return m + 1;
             if ((n != 0) && (m == 0)) return Ackerman(n - 1, 1);
             return Ackerman(n - 1, Ackerman(n, m - 1));
        }

        public void PrintNum(int num )
        {
            Console.Write(num + " ");
            if (num < 0) num *= -1;
            if (num > 1) PrintNum(num - 1);
        }
        public void PrintAndSumNum(int b,  int x)
        {
            Console.Write(b + x + " ");
            if (b < 0) b *= -1;
            if (x < 0) x *= -1;
            if (b != x) PrintAndSumNum(b + 1, x);
        }
        
     }
}
