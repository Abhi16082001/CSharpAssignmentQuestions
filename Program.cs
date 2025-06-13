
//using DailyPractice;
//matrix m = new matrix(10,20,30,40);
//Console.WriteLine(m);
//Mystruct str=new Mystruct();
////str.a = 10;str.b = 'S';
//str.display();
using System.Text;

SuppAssgn s = new SuppAssgn();

PRO: Console.Write("Enter the length and breadth  : ");
//StringBuilder str = new StringBuilder(Console.ReadLine());
//String str = Console.ReadLine();
int l = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
s.PrntStrRect(l,b);

//using LibDemo;

//Class1 obj = new Class1();
//Console.WriteLine(obj.SayHi());

//PRO: Console.Write("Enter the size of array  : ");
//int sz = int.Parse(Console.ReadLine());
//int[] arr = new int[sz];
//Console.Write("Enter the array  : ");
//for (int j = 0; j < sz; j++)
//{
//    arr[j] = int.Parse(Console.ReadLine());
//}

//s.ShellSort2(arr);

//foreach(int k in arr)
//{
//    Console.Write(k + " ");
//}


//Console.WriteLine();

Console.WriteLine("Do you want to run more? 1. Yes    2. No --> ");
int i = int.Parse(Console.ReadLine());
if (i == 1) goto PRO;
else return;
Console.ReadLine();

