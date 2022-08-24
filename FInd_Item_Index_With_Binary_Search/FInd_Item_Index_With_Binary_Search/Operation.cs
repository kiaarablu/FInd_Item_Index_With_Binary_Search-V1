using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_Item_Index_With_Binary_Search
{
    public class Operation
    {
        int first = 0;
        int last;
        int midddle;
        public void BInary_Search(int[] arr, int key)
        {

            last = arr.Length - 1;
            midddle = (first + last) / 2;
            while (first - 1 == midddle || last - 1 != midddle)
            {
                if (key == arr[midddle])
                {
                    Console.WriteLine(midddle + 1);
                    return;
                }
                else if ((last == first && last == midddle && first == midddle))
                {
                    if (key < arr[last])
                    {
                        Console.WriteLine(last);
                    }
                    else
                    {
                        Console.WriteLine(last + 1);

                    }
                    return;
                }
                else if (key > arr[midddle])
                {
                    first = midddle + 1;
                    midddle = (first + last) / 2;
                }
                else if (key < arr[midddle])
                {
                    last = midddle - 1;
                    midddle = (first + last) / 2;
                }
            }


            if (key > arr[first] && key < arr[last])
            {
                Console.WriteLine(last);
            }
            else if (key > arr[last])
            {
                Console.WriteLine(last + 1);
            }
            else
            {
                Console.WriteLine(midddle);
            }

        }

    }
}
