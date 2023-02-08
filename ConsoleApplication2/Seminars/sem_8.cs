using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Seminar_1.Utils;

namespace Seminar_1
{
    public class sem_8
    {
        private static Menu _menu = new Menu();
        public  int[,] SpiralArrayFill(int input)
        {
            int[,] arr = new int[input, input];
            for (int curPos = 1, padding = 0; padding < input / 2; padding++)
            {
                for (int j = padding; j < input - padding; j++)
                    arr[padding, j] = curPos;
                for (int j = padding; j < input - padding; j++)
                    arr[input - padding - 1, j] = curPos;
                for (int j = padding + 2; j < input - padding - 1; j++)
                    arr[j, padding] = curPos;
                for (int j = padding + 1; j < input - padding - 1; j++)
                    arr[j, input - padding - 1] = curPos;
                curPos = 1 - curPos;
                arr[padding + 1, padding] = curPos;
            }
            if (input % 2 != 0 && arr[0, 0] == 1) arr[input / 2, input / 2] = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int g = 0; g < arr.GetLength(1); g++)
                { 
                    Console.Write(arr[i,g] + " ");
                }
                Console.WriteLine();
            }
            return arr;
            
        }

        public int[,] CreateAAndPrintMatrix(int cols, int rows)
        {
            Console.WriteLine();
            int sum = int.MaxValue;
            int[,] matrix = new int[rows, cols];
            for(int i = 0;  i <  rows;i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = new Random().Next(0, 9);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    Console.Write(matrix[i,n] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i, j];
                }
                if (temp < sum)
                {
                    sum = temp;
                    index = i;
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i,j] + " ");
                Console.WriteLine();
            }
            

            string prompt = "That is copy of previous matrix? (scroll up to see his)";
            string[] menuOpts = new[]
            {
                "yes", "no"
            };
            _menu.MainMenu(prompt, menuOpts);
            _menu.Run();
            int selectOpt = _menu.SelectedOpt;
            switch (selectOpt)
            {
                case 0:
                    Console.WriteLine("ok, rerun");
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine($"xc7b@root:~$ sudo cowsay sum");
                    Console.WriteLine();
                    Console.WriteLine($"< your minimal sum is {sum} an min sum row index is {index}!  >");
                    Console.WriteLine(@"  ----------------------------------------------- -");
                    Console.WriteLine(@"                                                 \   ^__^");
                    Console.WriteLine(@"                                                  \  (oo)\_______");
                    Console.WriteLine(@"                                                     (__)\       )\/\");
                    Console.WriteLine(@"                                                         (||----w |");
                    Console.WriteLine(@"                                                          ||     ||");
                    break;
            }
            
            Console.WriteLine(); 

            
            return matrix;
        }

        public int[,] BubbleSortingToDown(int cols, int rows)
        {
            int[,] arr = new int[cols, rows];
            for(int i = 0;  i <  rows;i++)
            for (int j = 0; j < cols; j++)
                arr[i, j] = new Random().Next(0, 9);
           
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(1); n++)
                {
                    Console.Write(arr[i, n] + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            var b = arr.Cast<int>().OrderByDescending(a => a).ToArray();
            int temp = 0;
            for (int s = 0; s < arr.GetLength(0); s++)
            {
                for (int e = 0; e < arr.GetLength(1); e++)
                {
                    arr[s, e] = b[temp];
                    Console.Write(arr[s,e] + " ");
                    temp++;
                }
                Console.WriteLine();
            }
            return arr;
        }

       //Accessibility Work
       public void MultipleMatrix(int row, int col)
       {
           int[,] matrix = new int[row, col];
           int[,] bitrix = new int[row, col];
           for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = new Random().Next(0, 10);
                    bitrix[i, j] = new Random().Next(0, 10);
                }
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               for (int q = 0; q < matrix.GetLength(1); q++)
               {
                   Console.Write(matrix[i, q] + " ");
               }
               Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               for (int q = 0; q < matrix.GetLength(1); q++)
               {
                   Console.Write(bitrix[i,q] + " ");
               }
               Console.WriteLine();
            }
            Console.WriteLine();
            for (int v = 0; v < bitrix.GetLength(0); v++)
            {
                for (int i = 0; i < bitrix.GetLength(1); i++)
                {
                   Console.Write("{0 , 7}",matrix[v, i] * bitrix[v,i] + " ");
                }
                Console.WriteLine();
            }
          

       }
    }
}
