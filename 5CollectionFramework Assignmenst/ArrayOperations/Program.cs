using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)Operations on int array
            int[] arr_int = new int[] {90,20,70,30,10};
            //Copying of array
            int[] newint_array = new int[arr_int.Length];
            arr_int.CopyTo(newint_array, 0);
            foreach (int item in newint_array)
            Console.WriteLine(item);
            //Array sorting
            Array.Sort(arr_int);
            Console.WriteLine("Sorted array: ");
            foreach (int item in arr_int)
            {
                Console.WriteLine(item+ " ");
            }
            //Reverse an array
            Array.Reverse(arr_int);
            foreach (int item in newint_array)
                Console.WriteLine(item);
            //Clear an array
            Array.Clear(arr_int,0,arr_int.Length);
            Console.WriteLine(arr_int.Length);
            Console.ReadLine();

            //b)Operations on string array
            string[] arr_string = new string[] {"Sandeep","Lakshmi","Priya","Abdul","Eswar"};
            //Copying of array
            string[] newstring_array = new string[arr_string.Length];
            arr_string.CopyTo(newstring_array, 0);
            foreach (string item in newstring_array)
                Console.WriteLine(item);
            //Array sorting
            Array.Sort(arr_string);
            Console.WriteLine("Sorted array: ");
            foreach (string item in arr_string)
            {
                Console.WriteLine(item + " ");
            }
            //Reverse an array
            Array.Reverse(arr_string);
            foreach (string item in arr_string)
                Console.WriteLine(item);
            //Clear an array
            Array.Clear(arr_string, 0, arr_string.Length);
            Console.WriteLine(arr_string.Length);
            Console.ReadLine();
        }
    }
}
