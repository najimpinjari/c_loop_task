using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region condition new practice  

            /*   Console.WriteLine("please enter the first number ");
               int first  =  int.Parse(Console.ReadLine());

               Console.WriteLine("please enter the second number ");
               int second = int.Parse(Console.ReadLine()); 

               Console.WriteLine("please enter third number");
               int third = int.Parse(Console.ReadLine());

               Console.WriteLine($"you entered  : {first} , {second} ,{third} ");

   */

            #endregion condition 

            #region nested if else 

            //  if (first > second )
            //              {
            //                 Console.WriteLine($" {first} is greter number ");
            //               }
            //              else if (first > third ) 
            //                {
            //                     Console.WriteLine($" {first} is greter number ");
            //                 }
            //  else {
            //    if (second > third)
            //    {
            //        Console.WriteLine($" {second} is greter number  ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{third} is greter number ");
            //    }
            //}
            #endregion nested if else 

            #region DIVITOIN 


            /*  Console.WriteLine($"please enter a number ");
              int num = int.Parse(Console.ReadLine());

  if (num % 3 == 0)
  {
      Console.WriteLine($"TRHREE ");
  }
  else if (num % 5 == 0) {
      Console.WriteLine("FIVE ");
  }
  else if (num % 3 == 0 && num % 5 == 0) ;
    {
         Console.WriteLine("THREEFIVE");
    }
 */
            #endregion DIVITOIN

            #region grade meaning 

            /*   Console.WriteLine($"PLEASE ENTER A GREAT ");
                Char grade = char.Parse(Console.ReadLine());

                switch (grade)
                { 
                case 'A':
                        Console.WriteLine($" {grade} : disingction ");
                        break;
                case 'b';
                        Console.WriteLine($"{grade} : disingctin ");
                        break;
                      default
              */
            #endregion grade meaning 

            #region switch 
            /*
                        Console.WriteLine($"please enter the ");
                        char grade = char .Parse(Console.ReadLine());

                        switch (grade)
                        {
                            case 'A':
                                Console.WriteLine($" {grade} : DISTINCTION ");
                                break;
                            case 'B':
                                Console.WriteLine($"{grade} : first class ");
                                break:
                            case 'C':
                                Console.WriteLine($"{grade} : second class");
                                break:
                            case 'F':
                                Console.WriteLine($"{grade} : faild ");
                                break:
                            default:
                                Console.WriteLine($"{grade} : invalid Grade ");

                        }*/
            #endregion switch 


            #region while loops

            /*
                        int start = 1; // initialization 
                        while ( start  <= 10  ) // condition 
                        {
                            Console.WriteLine(start);
                            start++;    //updation 
                        }*/

            #endregion while loops

            #region do while loops 

            /* int start = 1;
             do {
                 Console.WriteLine(start);
                 start++;
             } 
             while (start <= 5);*/




            #endregion do while loops 

            #region for loops 
/*
            for (int start = 1; start <= 5; start++)
            {
                Console.WriteLine(start);
            }
*/


            #endregion for loops 

            #region for lops one 

            for (int i = 1  ; i ==> 0; i--) { 
                for (int j = 1; j => 5; j--)
                {
                    Console.Write($"*\t");
                }
                Console.WriteLine();

            }




            #endregion for lops one 



            Console.ReadLine();
        }
    }
}


