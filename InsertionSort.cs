using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class InsertionSort
    {
        //this method is to Insert the elements and sort them in order.
        public void InsertionSortOrder()
        {
            Console.WriteLine("enter the size of an array:");
            //Convert string into Integer value and store it in size.
            int size = Convert.ToInt32(Console.ReadLine());
            //Created an array to insert the elements
            string[] array = new string[size];
            Console.WriteLine("enter the string elements of array:");
            for (int i = 0; i < size; i++)
            {
                //elements will store in index(position) 0 and 1
                array[i] = Console.ReadLine();
            }
            for (int i = 1; i < array.Length; i++)
            {
                //array[i] element will store in key.
                string key = array[i];

                int j = i - 1;


                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                //key stores in array
                array[j + 1] = key;
            }

            //giving elements after sorted.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
