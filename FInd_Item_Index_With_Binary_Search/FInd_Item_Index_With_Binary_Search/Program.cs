using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_Item_Index_With_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 10,20, 30, 45, 57, 64, 72, 75 };
            int[] array = { -10, -5, 20, 35, 42, 51, 55, 73, 90, 99 };
            Operation a = new Operation();
            //a.BInary_Search(array, 36);
            RecursiveOperation x = new RecursiveOperation();
            x.RecursiveBinarySearch(array,0,array.Length, 0);





            Console.ReadKey();
        }
    }
}
