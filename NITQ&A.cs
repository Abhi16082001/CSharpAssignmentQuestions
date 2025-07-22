using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

// Go to Line 402 [class name : NITQ_A ] for the program solutinos from 1st to end ; before that class definitions are there for solving the respective questions !

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

    // For P33
    public class DelegateDemo
    {
        public void show1()
        {
            Console.Write("Abhishek");
        }
        public void show2()
        {
            Console.Write("Rajput");
        }
    }

    public delegate void delgt();


    //For P34
    public class mltthrdDemo
    {
        public void fun1()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Fun1 : " + i + " executed by Thread "+Thread.CurrentThread.ManagedThreadId);
            }
        }

        public void fun2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Fun2 : " + i + " executed by Thread " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }

    //For P35
    public class student
    {
        int _id, _age;
        string _name;
        float _per;
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public int age
        {
            set { _age = value; }
            get { return _age; }
        }
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        public float per
        {
            set { _per = value; }
            get { return _per; }
        }
    }
    //For P36
    public class Pokemon
    {
       public  string name,type1,type2;
        public int gen;
    }
    public class Starter: Pokemon
    {
        public virtual void getStrType()
        {
            Console.Write("Choose one of the following :\n1.Fire\n2.Grass\n3.Water\n");
            type1 = Console.ReadLine();
        }
    }
    public sealed class Generation : Starter
    {
        public override void getStrType()
        {
            base.getStrType();
            Console.Write("Give Second Type: ");
            type2 = Console.ReadLine();
        }
        public void getgen()
        {
            Console.Write("Choose Gen from 1-9: ");
            gen =int.Parse( Console.ReadLine());
            Console.Write("Enter Name: ");
            name= Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Name: {name}\nType1: {type1}\nType2: {type2}\nGen: {gen}";
        }
  
    }


    //For P37
    public class EmpPrivate
     {
        int empid, age;
        string name;
        double sal;
         public void setter()
        {
            Console.Write("Enter Employee ID: ");
            empid = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name= Console.ReadLine();
            Console.Write("Enter Employee Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Salary: ");
            sal = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Employee ID: {empid}\nName: {name}\nAge: {age}\nSalary: {sal}";
        }
     }


    //For P39
    public class AccsModDemoStu
    {
        private string name;
        protected int age;
        
        public float marks;
        internal int id;
        public AccsModDemoStu(string nm)
        {
            name = nm;
        }
        public void showName()
        {
            Console.WriteLine("Student Name : "+name);
        }
    }

    public class studtls : AccsModDemoStu
    {
       public studtls(int age, int id, float mrks,string nm):base(nm)
        {
            this.age=age;
            this.id=id;
            marks = mrks;
        }

        public void showDtls()
        {
            Console.WriteLine("Student ID: "+id);
            showName();
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("Student Marks: " + marks);
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

        public void DivideException() //P28. Write a program to perform division operation using exception handling?
        {
            double res = 0;
            Console.Write("Enter Dividend: ");
            try
            {
            double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter Divisor: ");
            double n2 = double.Parse(Console.ReadLine());
                if (n2 == 0) throw new DivideByZeroException(); // Because instead of exception it was giving infinity as answer while dividing with zero !
                res = n1 / n2;
            }
            catch(FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter number only !!");
            }
            catch (DivideByZeroException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Divisor Cant be Zero !!");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error : "+e.Message);
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Division Result is : " + res);
        }

        public void TrvsStack() //P29. Write a program to print 10 values of different data types using stack?
        {
            Stack st = new Stack();
            st.Push(16); st.Push("Abhi");
            st.Push(08); st.Push("Raj");
            st.Push(2001); st.Push('A');
            st.Push('R'); st.Push(34.567);
            st.Push(true); st.Push(56.78);
            foreach(var i in st)
            {
                Console.WriteLine(i);
            }

        }

        public void TrvsQueue() //P30. Write a program to print 10 values of different data types using Queue?
        {
            Queue st = new Queue();
            st.Enqueue(16); st.Enqueue("Abhi");
            st.Enqueue(08); st.Enqueue("Raj");
            st.Enqueue(2001); st.Enqueue('A');
            st.Enqueue('R'); st.Enqueue(34.567);
            st.Enqueue(true); st.Enqueue(56.78);
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }

        }

        public void TrvsHashTable() //P31. Write a program to print 10 values of different data types using hash table?
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,16); ht.Add(2,"Abhi");
            ht.Add(3,08); ht.Add(4,"Raj");
            ht.Add(5,2001); ht.Add(6,'A');
            ht.Add(7,'R'); ht.Add(8,34.567);
            ht.Add(9,true); ht.Add(10,56.78);
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine($"Key : {i.Key} ; Value : {i.Value}");
            }

        }


        public void TrvsSortedList() //P32. Write a program to print 10 values of different data types using Sorted List?
        {
            SortedList sl = new SortedList();
            sl.Add(4, 16); sl.Add(2, "Abhi");
            sl.Add(3, 08); sl.Add(1, "Raj");
            sl.Add(10, 2001); sl.Add(6, 'A');
            sl.Add(7, 'R'); sl.Add(9, 34.567);
            sl.Add(8, true); sl.Add(5, 56.78);
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine($"Key : {i.Key} ; Value : {i.Value}");
            }

        }

        public void DelegateTest()  //P33. Write a program to implement multi cast delegate for performing different operations?
        {
            delgt dg1, dg2, dg3,dg4,dg5;
            DelegateDemo dlgdm = new DelegateDemo();
            dg1 = new delgt(dlgdm.show1);
            dg2 = new delgt(dlgdm.show2);
            dg3 = dg1 + dg2;
            dg4 = dg3 - dg1;
            dg5 = dg3 - dg2;
            dg1();  Console.WriteLine();
            dg2(); Console.WriteLine();
            dg3(); Console.WriteLine(); 
            dg4(); Console.WriteLine(); 
            dg5(); Console.WriteLine();
        }


        public void multithrding()  //P34 - Write a program to implement multi-threading?
        {
            Console.Write("Main Thread Starting !!");
            mltthrdDemo mt = new mltthrdDemo();
            Thread t1 = new Thread(mt.fun1);
            Thread t2 = new Thread(mt.fun2);
            t1.Start(); t2.Start();
            t1.Join(); t2.Join();
            Console.Write("Main Thread Exited !!");
        }


        public void ShowStu() // P35. Write a program to display student basic details using Read-Write property?
        {
            student stu = new student();
            stu.name = "Abhi";
            stu.id = 1008;
            stu.age = 23;
            stu.per = 92.8f;
            Console.WriteLine($"Student Id: {stu.id}\nName: {stu.name}\nAge: {stu.age}\nPercentage: {stu.per}");
        }

        public void sealedDemo() //P36. Write a program which should contain multiple inherited classes and the last defined should not allow inheritance?
        {
            Generation gen = new Generation();
            gen.getStrType();
            gen.getgen();
            Console.WriteLine(gen);
        }

        public void empPrvt() //P37. Write a program to accept employee details using private variables?
        {
            EmpPrivate emp=new EmpPrivate();
            emp.setter();
            Console.WriteLine(emp);
        }

        public void StuReport() //P38. Write a program to calculate percentage of marks?
        {
            string name;
            float math, phy, chem, cs, eng;
            float per, tot;
            Console.Write("Enter Name of student: ");
            name = Console.ReadLine();
            Console.Write("Enter Physics Marks: ");
            phy = float.Parse(Console.ReadLine());
            Console.Write("Enter Chemisty Marks: ");
            chem = float.Parse(Console.ReadLine());
            Console.Write("Enter Computer Science Marks: ");
            cs = float.Parse(Console.ReadLine());
            Console.Write("Enter English Marks: ");
            eng = float.Parse(Console.ReadLine());
            Console.Write("Enter Maths Marks: ");
            math = float.Parse(Console.ReadLine());

            tot = (math + phy + chem + cs + eng);
            per = tot / 5;

            Console.WriteLine("Report Card of Student: " + name);
            Console.WriteLine($"Maths Marks: {math}");
            Console.WriteLine($"Physics Marks: {phy}");
            Console.WriteLine($"Chemistry Marks: {chem}");
            Console.WriteLine($"Computer Science Marks: {cs}");
            Console.WriteLine($"English Marks: {eng}");
            Console.WriteLine($"Total Marks: {tot}");
            Console.WriteLine($"Percentage Obtained: {per} %");
        }


        public void accsModDemo() //P39. Write a program to display Student details and use protected, internal access modifiers for variables?
        {
            studtls stu = new studtls(23,1008,95.5f,"Rajput");
            stu.showDtls();
        }

    }
}
