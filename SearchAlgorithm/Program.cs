﻿using System;

namespace SearchAlgorithm
{
    class Program
    {
        //Array to be searched
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();  
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 element. \n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter array element");
            Console.WriteLine("-------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write(">"+(i+1)+">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be searched
                Console.Write("\nEnter element want you to search : ");
                int item = Convert.ToInt32(Console.ReadLine());
                //Accept binary search
                int lowerbound = 0;
                int upperbound = n-1;
            }
        }
    }
}
