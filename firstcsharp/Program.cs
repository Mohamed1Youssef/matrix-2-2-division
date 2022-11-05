using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace firstcsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] arr1 = new double[2, 2];
            double[,] arr2 = new double[2, 2];
            double[,] arr2t = new double[2, 2];
            double [,] arr3 = new double[2, 2];
            Console.WriteLine("array 1");
            for (int i= 0; i < 2; i++)
            {
                for(int j= 0; j < 2; j++)
                {
                    Console.Write("element[{0},{1}]=",i,j);
                    arr1[i,j] = double.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("array 2");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("element[{0},{1}]", i, j);
                    arr2[i, j] = double.Parse(Console.ReadLine());
                }
               
            }
            //calculating the inverse of array 2
            arr2t[0, 0] = arr2[1, 1];
            arr2t[1, 1] = arr2[0, 0];
            arr2t[0, 1] = arr2[0, 1]* -1;
            arr2t[1, 0] = arr2[1, 0]*-1;
            double b =(arr2t[0, 0] * arr2t[1, 1]) - (arr2t[0, 1] * arr2t[1, 0]);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2t[i, j] *= (1/b);
                }
               
            }
            //multiply array 1 and the inverse of array 2
            
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        arr3[i,j]+= arr1[i,k] * arr2t[k,j];
                    }
                   
                }
                
            }
            Console.WriteLine("the result of division = ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i,j]+" ");
                   
                }
                Console.WriteLine();
            }


        }
        
    }
   
}










