using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                            int i = 5, j = 5;

                             for (i = 1; i <= 5; i++)
                             {
                                 for (j = 1; j <= 5; j++)
                                 {
                                     Console.Write("*");
                                 }
                                 Console.WriteLine();


                        int rows = 5;

                        for (int i = 1; i <= rows; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();

                            }

                        int n = 5;
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }

                        int v = 5;
                        for (int i = 1; i <= v; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();  }

             int x, y, z;

            for (x = 6; x >= 1; x--)
            {
                for (y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (z = 6; z >= x; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();         

            for (int i = 1; i <= 5; i++) 
            {
                for (int j = 1; j<=5; j++)
                {
                    Console.Write("@ ");
                }
                Console.WriteLine();

            for (int row = 5; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }



            Console.ReadLine();

             
        }   
    }
}
