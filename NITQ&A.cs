using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace AssignmentQuestion
{
    // For P19
    public class Employee
    {
        int empid,age;
        string name;
        double sal;
        public void setter()
        {
            Console.Write("Enter Employee ID: ");
            empid = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            sal = double.Parse(Console.ReadLine());
            
        }
        public override string ToString()
        {
            return $"EmpID : {empid}\nName : {name}\nAge : {age}\nSalary : {sal}";
        }

    }
     
    // For P20
    public class Person
    {
        String name;
        int age;
        public virtual void setter()
        {
           
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

        }
        public virtual void  display()
        {
            Console.WriteLine($"Name: {name}\nAge : {age}");
        }
    }

    public class Salary : Person
    {
        double bsal, da, hra;
            public double totsal;
        public override void setter()
        {
            base.setter();
            Console.WriteLine("Enter Base Salary: ");
            bsal = double.Parse(Console.ReadLine());
        }
        public void calSal()
        {
            da = 0.4 * bsal;
            hra = 0.3 * bsal;
            totsal = bsal + da + hra;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Basic Salary: {bsal}\nDA: {da}\nHRA: {hra}");
        }
    }

    public class Emp20 : Salary
    {
        int empid;
        public sealed override void setter()
        {
            Console.WriteLine("Enter Employee ID: ");
            empid = int.Parse(Console.ReadLine());
            base.setter();
            this.calSal();
        }
        public sealed override void display()
        {
            Console.WriteLine($"Employee ID: {empid}") ;
            base.display();
            Console.WriteLine($"Total Salary: {totsal}");
        }


    }
    // For P21
    public abstract class EmpTemplate {
        public int empid,age;
       public string name;
       public  double sal;
        public abstract void setter();
        public abstract void display();
    }
    public class Empabs : EmpTemplate
    {
        public override void setter()
        {
            Console.WriteLine("Enter Employee ID: ");
            empid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
             sal= double.Parse(Console.ReadLine());
        }
        public override void display()
        {
            Console.WriteLine($"Employee ID: {empid}\nName: {name}\nAge: {age}\nSalary: {sal}"); 
        }
    }

    // For P22
    public class overloadQ
    { 
        public int plus(int n1, int n2)
        {
            return n1 + n2;
        }
        public string plus(string s1, string s2)
        {
            return s1 + s2;
        }
        
    }
    // For P23
    public class overRidePrnt
    {
        public virtual void Display()
        {
            Console.WriteLine("This is the Parent Display method !!");
        }
    }
    public class overRideChld : overRidePrnt
    {
        public override void Display()
        {
            Console.WriteLine("This is the Overriden Display Method of child class !!");
        }
    }


    // For P24
    interface intrfc1
    {
        public abstract int Add(int n1, int n2);
        
    }
    interface intrfc2
    {
        public abstract int Sub(int n1, int n2);
        
    }
    public class MultipleInheritance: intrfc1, intrfc2
    {
        public int Add(int n1, int n2) { return n1 + n2; }
        public int Sub(int n1, int n2) { return n1 - n2; }
    }

    //For P25
    public class datetimeQsn
    {
        static int date;
        static int month;
        static int year;
        public static void getdate()
        {
            date = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            Console.WriteLine($"Today's Date: {date}/{month}/{year}");
        }
        
    }

    //For P26
    public class CtorOvrldDemo
    {
        public int intgr;
        public string? strg;
        public CtorOvrldDemo()
        {
            intgr = 0;
            strg = null;
        }
        public CtorOvrldDemo(int intgr, string strg)
        {
            this.intgr = intgr;
            this.strg = strg;
        }
        public CtorOvrldDemo(CtorOvrldDemo cod)
        {
            this.intgr = cod.intgr;
            this.strg = cod.strg;
        }

        public override string ToString()
        {
            return $"Integer : {intgr} String: {strg}";
        }
    }

    //For P27
    public class EmpPrmC
    {
        int empid, age;
        string name;
        double sal;
        public EmpPrmC(int id, int ag, double salry, string nm)
        {
            empid = id;
            name = nm;
            age = ag;
            sal = salry;
        }
        public override string ToString()
        {
            return $"EmpID : {empid}\nName : {name}\nAge : {age}\nSalary : {sal}";
        }

    }

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

        public void TriangleStars(int r) // P5- Print stars in triangle format
        {

            for (int i = 1; i <= r; i++) { 
            for(int j = 1; j <= r-i+(2 * i - 1); j++)
                {
                    if (j <= r - i) Console.Write(' ');
                    else Console.Write('*');
                }
                Console.WriteLine();
            }


          /*
            
            *
           ***
          *****
         *******
         
           */
        }

        public void RvrsStr(String str) //P6 - Reverse of given string
        {
            String rvs = "";
            foreach (char ch in str)
            {
                rvs = ch + rvs;

            }
            Console.WriteLine($"Reverse String :  {rvs}");

        }


        public void Swap()  // P7 - Swapping without third variable and without addition & subtraction
        {
            Console.Write("Enter Value for A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Value for B: ");
            int b = int.Parse(Console.ReadLine());

            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Values after Swapping: ");
            Console.WriteLine("Value for A: " + a);
            Console.WriteLine("Value for B: " + b);

        }

        public void unboxing() // P8 -	Write a program to accept input (All data types) from command prompt and convert them into string? 
        {
            String IntStr, CharStr, DblStr, FltStr, DcmlStr, BoolStr;
            Console.Write("Enter Integer: ");
            int IntVal = int.Parse(Console.ReadLine());
            IntStr = IntVal.ToString();
            Console.Write("Enter Character: ");
            char CharVal = char.Parse(Console.ReadLine());
            CharStr= CharVal.ToString();
            Console.Write("Enter Double: ");
            double DblVal = double.Parse(Console.ReadLine());
            DblStr = DblVal.ToString();
            Console.Write("Enter Float: ");
            float FltVal = float.Parse(Console.ReadLine());
            FltStr= FltVal.ToString();
            Console.Write("Enter Decimal: ");
            decimal DcmlVal = decimal.Parse(Console.ReadLine());
            DcmlStr = DcmlVal.ToString();
            Console.Write("Enter Boolean: ");
            bool BoolVal = bool.Parse(Console.ReadLine());
            BoolStr = BoolVal.ToString();

            Console.WriteLine($"Integer to String : {IntStr}");
            Console.WriteLine($"Double to String : {DblStr}");
            Console.WriteLine($"Float to String : {FltStr}");
            Console.WriteLine($"Decimal to String : {DcmlStr}");
            Console.WriteLine($"Character to String : {CharStr}");
            Console.WriteLine($"Boolean to String : {BoolStr}");

        }


        public void boxing()  //P9 & P10 - Write a program to accept input (string) from command prompt and convert that into int, double, float data types?
        {
            String str;
            Console.Write("Enter Integer: ");
            str = Console.ReadLine();
            int IntVal = int.Parse(str);
            
            Console.Write("Enter Character: ");
            str = Console.ReadLine();
            char CharVal = char.Parse(str);
            
            Console.Write("Enter Double: ");
            str = Console.ReadLine();
            double DblVal = double.Parse(str);
            
            Console.Write("Enter Float: ");
            str = Console.ReadLine();
            float FltVal = float.Parse(str);
            
            Console.Write("Enter Decimal: ");
            str = Console.ReadLine();
            decimal DcmlVal = decimal.Parse(str);
            
            Console.Write("Enter Boolean: ");
            str = Console.ReadLine();
            bool BoolVal = bool.Parse(str);

            Console.WriteLine($"String to Integer : {IntVal}");
            Console.WriteLine($"String to Double: {DblVal}");
            Console.WriteLine($"String to Float: {FltVal}");
            Console.WriteLine($"String to Decimal: {DcmlVal}");
            Console.WriteLine($"String to Character: {CharVal}");
            Console.WriteLine($"String to Boolean: {BoolVal}");

        }

        public void Emp() //P11 - Write a program to enter employee details using command prompt and display employee details
        {
            int empid, age;
            string name;
            double sal;
            Console.Write("Enter Employee ID: ");
            empid = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name=Console.ReadLine();
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine($"EmpID : {empid}\nName : {name}\nAge : {age}\nSalary : {sal}");

        }

        public void BigInThree() // P12 - Write a program to check biggest number among three numbers? (Use if, else if)
        {
            int n1, n2, n3, max=0;
            Console.Write("Enter Number 1: ");
            n1= int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 3: ");
            n3 = int.Parse(Console.ReadLine());
        
            if (n1 < n2) max = n2;
            else if (n1>n2) max = n1 ;
            if (n3 > max) max = n3;
            Console.WriteLine("Bigger in given three numbers : " + max);
        }

        public void arithmetic() // P13 - Write a program to perform arithmetic operations using switch case?
        {
            int n1, n2;
            char op;
            Console.Write("Enter Number 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Operator[+,-,*,/,%]");
            op = char.Parse(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            n2 = int.Parse(Console.ReadLine());
            switch (op) {
                case '+': Console.WriteLine(n1 + n2); break;
                case '-': Console.WriteLine(n1 - n2); break;
                case '*': Console.WriteLine(n1 * n2); break;
                case '/': Console.WriteLine(n1 / n2); break;
                case '%': Console.WriteLine(n1 % n2); break;
                default: Console.WriteLine("Enter Correct Operator !!"); break;
            }
        }
        

        public void print10()   // P14 - Write a program to print 1 to 10 numbers using while and do-while loop?
        {
            int i = 1;
            Console.WriteLine("Using While loop : ");
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            i = 1;
            Console.WriteLine("Using Do-While loop : ");
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }

        public void printeven() // P15 - Write a program to print 0 to 50 even numbers using for loop?
        {

            for (int i=0;i<=50;i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }


        public void sum30() // P16 - Write a program to calculate sum of 0 to 30 numbers using for loop?
        {
            int sum = 0;
            for (int i=0;i<=30;i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum : "+sum);
        }


        public void printarray(int[] arr) // P17 - Write a program to print 1-d array?
        { 
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void print2darray() // P18 - Write a program to print 2-d array and need to enter row size and column size from command prompt?
        {


            Console.WriteLine("Enter no of rows :");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of columns :");
            int c = int.Parse(Console.ReadLine());
            int[,] arr = new int[r, c];
            Console.WriteLine("Enter Elements :");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for(int j=0;j< c;j++)
                Console.Write(arr[i,j]+" ");
                Console.WriteLine();
            }
        }

        public void empdetails() // P19 - Write program to accept employee details (with multiple methods) by applying opps concepts?
        {
            Employee emp = new Employee();  // Definition of class available to the top 
            emp.setter();
            Console.WriteLine("Entered Values are : \n"+ emp);
        }


        public void empinheritance() // P20 - Write a program to calculate employee total salary (by adding DA, HRA, Basic sal) using multi-level inheritance
        {
            Emp20 emp= new Emp20();
            emp.setter();
            emp.display();
        }

        public void empabsdtls()  //P21.	Write a program to accept employee details using abstract class and abstract methods?
        {
            Empabs emp = new Empabs();
            emp.setter();
            emp.display();
        }

        public void OvrldeQsn()// P22.	Write a program to perform method overloading by changing the datatypes?
        {
            overloadQ ol = new overloadQ();
            Console.WriteLine("Result of Plus method with integer values : "+ol.plus(20,35));
            Console.WriteLine("Result of Plus method with string values : " + ol.plus("Poke", "Mon"));
        }
        
        public void OvrRdQsn() //P23.	Write a program to perform method overriding?
        {
            overRidePrnt ovrP= new overRidePrnt();
            overRidePrnt ovrP2 = new overRideChld();
            overRideChld ovrC = new overRideChld();
            Console.WriteLine("Method Call through Parent Instance: ");
            ovrP.Display();
            Console.WriteLine("Method Call through Parent Reference: This is Overriding : ");
            ovrP2.Display();
            Console.WriteLine("Method Call through Child Instance: ");
            ovrC.Display();
        }

        public void multipleinrhtnc() // P24. Write a program to achieve multiple inheritance using interface?
        {
            MultipleInheritance mi= new MultipleInheritance();
            Console.WriteLine("Add: "+mi.Add(23,34));
            Console.WriteLine("Sub: " + mi.Sub(23, 34));

        }
         
        public void staticdatetime() //P25 - Write program to display date time using static method?
        {
            datetimeQsn.getdate();
            
        }

        public void CtorOvrld()  // P26. Write a program for constructor overloading?
        {
            CtorOvrldDemo cod = new CtorOvrldDemo();
            Console.WriteLine(cod);
            CtorOvrldDemo cod2 = new CtorOvrldDemo(10, "Hello");
            Console.WriteLine(cod2);
            CtorOvrldDemo cod3 = new CtorOvrldDemo(cod2);
            Console.WriteLine(cod3);

        }

        public void PCtor() //P27. Write a program to implement parameterized constructor?
        {
            EmpPrmC emp1 = new EmpPrmC(101,23,50000,"Abhishek");
            EmpPrmC emp2 = new EmpPrmC(102, 25, 60000, "Rajput");
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }

    }
}
