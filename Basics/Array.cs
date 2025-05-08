using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Array
    {
        static void Main(string[] args)
        {

            //// single dimentional array
            //int[] arr = { 1, 11, 111, 1111, 11111 };

            //// for accessing the element
            //Console.WriteLine(arr[2]);

            ////looping of array

            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            // multidimentional array

            //int[,] arr = { { 11, 22, 33 }, { 44, 55, 66 } };

            //// for accessimg the array

            //Console.WriteLine($"elemrnt at [1,2] : {arr[0, 2]} ");

            //// for in loop for printing all elememnt 

            //for(int i = 0;i < 2; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(arr[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            // jaggedarray examples

            int[][] a = new int[3][];
            a[0] = new int[] {1,2,3};
            a[1] = new int[] { 8, 5 };
            a[2] = new int[] { 6 };

            // accessing  jacked array element
            Console.WriteLine($"element is {a[1][0]}");

            // printing all element using for and for each loop

            for (int i = 0; i < a.Length; i++)
            {
                foreach(int j in a[i])
                {
                    Console.WriteLine(j + " ");
                }
                Console.WriteLine();
            }
        }
        

    }
}
