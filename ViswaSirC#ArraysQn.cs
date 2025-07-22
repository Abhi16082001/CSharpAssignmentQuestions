using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestion
{
    internal class ViswaSirCSharpArraysQn
    {
        public void vowelConsntCount(string str) // Q1- To count the number of vowels and consonant in a string -Pg44
        {
            int v = 0, cn = 0;
            foreach (char c in str)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') v++;
                else cn++;
            }
            Console.WriteLine($"Vowels count : {v} \n Consonant Count : {cn}");
        }


        public void DiagonalSum(int[,] arr, int r, int c) // Q2- Calculate Sum of Diagonal elements - Pg49
        {
            int sum = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == j) sum += arr[i, j];
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
        {
            int max = arr.Length / 2;
            int i = 0, j = arr.Length - 1, temp = 0;
            while (i <= max && j >= max)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++; j--;
            }
            Console.Write("Reverse of the Input Array :");
            foreach (int it in arr)
                Console.Write(it + " ");
        }

        public void copyArr() // Q4 - Copy the array elements - Pg50
        {
            Console.WriteLine("Enter size for source array :");
            int r = int.Parse(Console.ReadLine());
            int[] sarr = new int[r];
            Console.WriteLine("Enter Elements :");
            for (int i = 0; i < r; i++)
            {
                sarr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter size for destination array :");
            int c = int.Parse(Console.ReadLine());
            int[] darr = new int[c];


            Console.WriteLine("Enter section size of source array which you want to copy to destination array:");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                darr[i] = sarr[i];
            }
            foreach (int i in darr) Console.WriteLine(i);
        }


        public void addele(int[] arr) //Q5 - Write a C# program to add new element to array? - Pg51
        {
            Console.Write("Enter the new element to add :");
            int ele = int.Parse(Console.ReadLine());
            Console.Write("Enter the position where to add in the array :");
            int posn = int.Parse(Console.ReadLine());

            int[] newarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length + 1; i++)
            {
                if (i < posn - 1) newarr[i] = arr[i];
                else if (i == posn - 1) newarr[i] = ele;
                else newarr[i] = arr[i - 1];
            }
            Console.WriteLine("New Array :");
            foreach (int i in newarr) Console.WriteLine(i);

        }

        public void MaxMin(int[] arr) //Q6 - Write a C# program to find array largest and smallest values? - Pg52
        {
            int max = int.MinValue, min = int.MaxValue;
            foreach (int i in arr)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }
            Console.WriteLine($"Max : {max}\nMin : {min}");
        }


        public void delDup(int[] arr) //Q7 - Write a C# program to remove duplicate values? - Pg53
        {
            int n = arr.Length;
            int dupcnt = 0;
            bool[] tmparr = new bool[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j] && !tmparr[i])
                    {
                        dupcnt++;
                        tmparr[i] = true;
                    }
                }
            }
            int[] newarr = new int[n - dupcnt];

            int indx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!tmparr[i])
                {
                    newarr[indx++] = arr[i];
                }

            }
            Console.WriteLine($"After Removing {dupcnt} Duplicates : ");
            foreach (int i in newarr)
                Console.WriteLine(i);
        }

        public void TwoDtoOneD(int[,] arr, int r, int c)  //Q8 - Write a C# program convert 2d array to 1 d array? - Pg54
        {
            Console.WriteLine("Original 2D Array : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int k = 0;
            int[] newarr = new int[r * c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    newarr[k++] = arr[i, j];
                }
            }
            Console.WriteLine("Converted 1D Array :");
            foreach (int i in newarr)
                Console.Write(i + " ");

        }


        public void Dupcnt(int[] arr) //Q9 - Write a C# program for Duplicate elements - Count in array? - Pg55
        {

            int n = arr.Length;
            int dupcnt = 0;
            bool[] tmparr = new bool[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j] && !tmparr[i])
                    {
                        dupcnt++;
                        tmparr[i] = true;
                    }
                }
            }
            Console.WriteLine("Duplicate Elements Count from Our Logic: " + dupcnt);

            int[] distnctarr = arr.Distinct().ToArray();
            int dupcnt2 = arr.Length - distnctarr.Length;
            Console.WriteLine("Duplicate Elements Count from Built-in Method : " + dupcnt2);
        }

        public void merge(int[] arr, int[] arr2) //Q10 - Write a C# Sharp program to merge two arrays of the same size? - Pg56
        {
            int k = 0;
            int[] mrgarr = new int[arr.Length + arr2.Length];
            Console.WriteLine("Array 1 : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                mrgarr[k++] = arr[i];
            }
            Console.WriteLine("\nArray 2 : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
                mrgarr[k++] = arr2[i];
            }
            Console.WriteLine("\nMerged Array : ");
            foreach (int i in mrgarr)
                Console.Write(i + " ");
        }


        public void secondmax(int[] arr) //Q11 - Write a C# Sharp program to find second largest from given array? - Pg56
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }

            for (int i = arr.Length - 1; i > 1; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;
                }
            }
            Console.WriteLine($"Largest is {arr[0]} and 2nd Largest is {arr[1]}");
        }

        public void secondmin(int[] arr) //Q12 - Write a C# Sharp program to find smallest or second smallest from given array? - Pg57
        {
            Array.Sort(arr);
            Console.WriteLine($"Smallest is {arr[0]} and 2nd Smallest is {arr[1]}");
        }

        public void sort(int[] arr) //Q13 - Write a C# Sharp program for performing sort (ascending or descending) and largest, smallest, second largest/smallest? - Pg57
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Array : ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine($"\nLargest : " + arr[arr.Length - 1]);
            Console.WriteLine($"2nd Largest : " + arr[arr.Length - 2]);
            Console.WriteLine($"Smallest : " + arr[0]);
            Console.WriteLine($"2nd Smallest : " + arr[1]);
        }

        public void Addmat(int[,] m1, int[,] m2) //Q14 - Write a C# Sharp program for adding two matrices of the same size? - Pg58
        {
            int r = m1.GetLength(0);
            int c = m1.GetLength(1);
            int[,] m3 = new int[r, c];
            Console.WriteLine("Matrix 1 : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix 2 : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }

            }
            Console.WriteLine("Matrix 1 + Matrix 2 : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m3[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


        public void TwoDsort(int[,] m) // Q15 - Write a C# Sharp program for performing sorting on 2D array (sort each row)? - Pg59
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            Console.WriteLine("Original Matrix : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c - 1; j++)
                {
                    for (int k = j + 1; k < c; k++)
                    {
                        if (m[i, j] > m[i, k])
                        {
                            int temp = m[i, j];
                            m[i, j] = m[i, k];
                            m[i, k] = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Sorted Matrix : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void JaggedSort(int[][] jg) // Q16 - Write a C# Sharp program for performing sorting on jagged array? - Pg60
        {
            int r = jg.Length;
            Console.WriteLine("\nOriginal Jagged Array : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < jg[i].Length - 1; j++)
                {
                    for (int k = j + 1; k < jg[i].Length; k++)
                    {
                        if (jg[i][j] > jg[i][k])
                        {
                            int tp = jg[i][j];
                            jg[i][j] = jg[i][k];
                            jg[i][k] = tp;
                        }
                    }
                }
            }
            Console.WriteLine("\nSorted Jagged Array : ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < jg[i].Length; j++)
                {
                    Console.Write(jg[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
