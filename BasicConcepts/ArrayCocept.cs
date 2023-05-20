using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan.BasicConcepts
{
    public class ArrayCocept
        // 1. array is a collection of elememts stored in a single variable by contiguous memory location with same datatype
        // 2. array starts with 0
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5];
             a[0] = 10;
             a[1] = 0;
             a[2] = 50;
             a[3] = 40;
             a[4] = 30;
             for(int i=0; i<a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }
             Console.WriteLine("-----------------------------------");

            // other way of declaring values in array

            string[] name = new string[] { "ram, sam, viky, kamal, ajay"};
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("-----------------------------------");
            // other way of declaring values in array

            string[] arr = { "5, 6.25, 5.6, 8, 12" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
