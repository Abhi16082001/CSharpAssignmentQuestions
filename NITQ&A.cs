using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQuestion
{
    internal class NITQ_A
    {
        public void fibo(int ub) //P1 - Print Fibonacci series upto upper bound
        {
            int[] a = new int[ub];
            a[0] = 0; a[1] = 1;
            for (int i = 2; i < ub; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            foreach (int i in a)
                Console.Write(i + " ");
        }

        public void ChckPldrm(String str) //P2 - Check for Palindrome in a string
        {
            String rvs = "";
            foreach (char ch in str)
            {
                rvs = ch + rvs;

            }
            Console.WriteLine($"Palindrome Result :  {str==rvs}");

        }

        public void IsPrime(int n) //P3 - Check for Prime number
        {
            bool res;
            if (n == 0 || n == 1) res=false;
            for (int i = 2; i <= n / 2; i++) /* We will check the factors till half of the number because once it 
                                     * crossed half then the quotient will be in between 1 and 1.9 only till
                                     * the number itself, so no need to check after half of the number.*/
            {
                if (n % i == 0) res=false;
            }
            res= true;
            Console.WriteLine($"Prime Check : {res}");
        }

        public void TriangleNumPttrn(int r) // P4- Print numbers in Triangle format
        {
            for(int i = 1; i <=r; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }

    }
}
