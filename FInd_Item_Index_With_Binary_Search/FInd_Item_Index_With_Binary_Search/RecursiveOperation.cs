using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_Item_Index_With_Binary_Search
{
    public class RecursiveOperation
    {
        public void RecursiveBinarySearch(int[] array, int first, int last, int key)
        {
            int middle = (first + last) / 2;
            if (first == last)
            {
                Console.WriteLine(last);
            }
            else if (key > array[middle])
            {
                RecursiveBinarySearch(array,middle + 1, last, key);
            }
            else
            {
                RecursiveBinarySearch(array,first,last - 1 , key);
            }
        }
    }
}
