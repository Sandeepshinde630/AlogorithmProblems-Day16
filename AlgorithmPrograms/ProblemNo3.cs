﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class ProblemNo3
    {
        public void run3()
        {
            string[] names = { "Sandeep", "Virat", "Dhoni", "Rohit" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
    }
}