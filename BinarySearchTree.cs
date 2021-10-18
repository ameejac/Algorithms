using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{

    //created a class BinarySearchWord with Access Modifier public.
    public class BinarySearchWord
    {
        //Method for taking user input as word to find in the list
        public void UserInput()
        {
            string input;
            //Asking the user to enter the colour for searching.
            Console.WriteLine("Enter the colour for searching in the arraylist:");
            input = Console.ReadLine();
            BinarySearch(input);
        }

        //input is my parameter i am  passing the input.
        public void BinarySearch(string input)
        {
            //colours in the array list.
            string[]  colour_list = {"brinjal", "blue", "brown", "black,","white","pink"};

            //Sorts the elements inn the entire array.
            Array.Sort(colour_list);
            //now I am taking boolean
            bool colour_found = false;
            int start = 0;
            int end = colour_list.Length - 1;
            if (colour_list.Length >= 1)
            {

                //finds the middle value of an array after sort.
                int middle = start + end / 2;

                //if result(-1) is less than 0 ,then else block executes.
                //if result(1) is greater than 0 ,then if block executes.
                int result = input.ToLower().CompareTo(colour_list[middle]);
                if (result > 0)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
                if (result == 0)
                {
                    
                    colour_found  = true;
                }
            }
            if (colour_found != true)
            {
                 Console.WriteLine("{0} colour is not present in colour_list", input);
               
            }
            else
            {

                Console.WriteLine("{0} colour is present in the colour_list", input);
            }
           
        }
    }

}
