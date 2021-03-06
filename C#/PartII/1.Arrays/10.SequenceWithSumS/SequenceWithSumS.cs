﻿/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
Example:{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;

class SequenceWithSumS
{
    static void Main()
    {
        int i = 0, j = 0, k = 0, NumOfSums = 0, sum = 0, start = 0, end = 0;
        Console.WriteLine("Enter the length of the array N:");
        string Nstr = Console.ReadLine();
        int N = int.Parse(Nstr);
        Console.WriteLine("Enter the sum S:");
        string Sstr = Console.ReadLine();
        int S = int.Parse(Sstr);
        int[] Arr = new int[N];
        while (i < N)
        {
            Console.WriteLine("Please enter the {0} number of the array", i + 1);
            string Numstr = Console.ReadLine();
            Arr[i] = int.Parse(Numstr);
            i++;
        }
        for (i = 0; i < N; i++)
        {
            for (j = 0; j < N; j++)
            {
                if (i + j < N)                 //предотвратява излизане на индекса извън размера на масива
                {
                    sum = sum + Arr[i + j];   //събира последователно елементите (1, 1+2, 1+2+3...; 2, 2+3, 2+3+4...; 3, 3+4, 3+4+5...)
                    if (sum == S)                //ако сумата им е равна на S
                    {
                        start = i;              //запазване на началото на интервала от елементи със сума S
                        end = i + j;            //запазване на края на интервала от елементи със сума S
                        NumOfSums++;            // броим колко суми S има
                        Console.Write("\nS sum elements are: ");
                        for (k = start; k <= end; k++)
                        {
                            Console.Write("{0}; ", Arr[k]);
                        }
                    }
                }
            }
            sum = 0;  //нулиране на сумата
        }
        Console.Write("\nS sum number is: {0}\n", NumOfSums);
    }
}
