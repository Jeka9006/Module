using System;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива:\t");




            int elementArrey = int.Parse(Console.ReadLine());

           int[] A = new int[elementArrey];
            int[] B = new int[elementArrey];

            int[] numericArray = new int[elementArrey];

            Random N = new Random();
            for (int i = 0; i < numericArray.Length; i++)
                numericArray[i] = N.Next(0, 27);

            for (int i = 0; i < numericArray.Length; i++)
            {
                if (numericArray[i] % 2 == 0)
                {
                    A[i] += numericArray[i];
                }

                else
                {
                    B[i] += numericArray[i];      
                }
                
                Console.WriteLine(A[i]);
            }

            
        }
        
    }
    }