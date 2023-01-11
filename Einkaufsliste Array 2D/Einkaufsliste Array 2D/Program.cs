using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einkaufsliste_Array_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] einkaufsliste = new string[3, 2];

            einkaufsliste[0, 0] = "Brot";
            einkaufsliste[0, 1] = " 5";
            einkaufsliste[1, 0] = "Wasser";
            einkaufsliste[1, 1] = " 2";
            einkaufsliste[2, 0] = "Fisch";
            einkaufsliste[2, 1] = " 1";

            while(true) { 
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(einkaufsliste[i,j]);
                    }
                    Console.WriteLine("x");
                }
                Console.ReadLine();
            }  
        }
    }
}
