using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestion
{
    internal class ViswaSirAssignment
    {
        public void vowelConsntCount(string str) // Q1- To count the number of vowels and consonant in a string -Pg44
        { int v = 0, cn = 0;
            foreach(char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') v++;
                else cn++;
            }
            Console.WriteLine($"Vowels count : {v} \n Consonant Count : {cn}");
        }    


        public void DiagonalSum(int[,] arr, int r, int c) // Q2- Calculate Sum of Diagonal elements - Pg49
        { int sum = 0;
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if (i == j) sum += arr[i,j];
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum is : {sum}");
        }


        public void ReverseArr(int[] arr)// Q3- Reverse the Array elements - Pg49
        { int max =arr.Length / 2;
            int i = 0, j = arr.Length-1,temp=0;
            while(i<=max && j >= max)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++; j--;
            }
            Console.Write("Reverse of the Input Array :");
            foreach(int it in arr)
            Console.Write(it + " ");
        }
    }
}
