using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Array_opration
    {
        static void Main()
        {
            // sorting of array

            //int[] arr = { 85, 65, 99, 45, 10, 87, 50, 43 };
            //System.Array.Sort(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i + " ");
            //}


            //reverse a array

            //int[] arr = { 85, 65, 99, 45, 10, 87, 50, 43 };
            //System.Array.Reverse(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i + " ");
            //}


            ////copy the array  

            //int[] og = { 15, 85, 65, 45, 81 };
            //int[] cp = new int[og.Length ];

            //System.Array.Copy(og, cp, og.Length);

            //foreach(int i in cp)
            //{
            //    Console.WriteLine(i + " ");
            //}



            //// finding index of array

            //int[] a = { 10, 85, 65, 90, 100, 45 };
            //int b = System.Array.IndexOf(a, 100);

            //Console.WriteLine($"index of element : {b}");



            // using list instead of array

            List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            a.Add(11);
            a.Remove(10);
            foreach (int i in a)
            {
                Console.WriteLine(i + " ");
            }



        }
    }
}
