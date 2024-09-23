using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        string color = "red";
        //string model;
        //public Program() { model = "Mistang"; }

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Shivam");
            Console.Write("Datta");
            int age = 25;
            Console.WriteLine(age);
            string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            int a = 12;
            float b = 12.5F;
            Console.WriteLine(a + b);
            bool isGood = true;
            Console.WriteLine(isGood);
            char v = 'a';
            Console.WriteLine(v);
            string str = "shivam";
            Console.WriteLine(str);
            int x = (int)3.5;
            Console.WriteLine(x);
            Console.WriteLine("Enter your name");
            string name=Console.ReadLine();
            Console.WriteLine(name);
            string p = "shivam";
            Console.WriteLine(p+4);
            Console.WriteLine(Convert.ToInt32(p)+4);
            int sum1 = 100 + 50;        
            int sum2 = sum1 + 250;      
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum1);
            Console.WriteLine(sum3);
            Console.WriteLine(sum2);
            int z = 10;
            z += 5;
            Console.WriteLine(z);
            int f = 5;
            int g = 3;
            Console.WriteLine(f > g);
            int h = 3;
            Console.WriteLine(h < 5 && h < 10);
            int f1= Math.Max(5, 10);
            Console.WriteLine(f1);
            double sq = Math.Sqrt(64);
            Console.WriteLine(sq);
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            string str2 = "Hello Shivam";
            Console.WriteLine(str2.ToUpper());   
            Console.WriteLine(str2.ToLower());
            string firstName = "Shivam ";
            string lastName = "Datta";
            string name1 = firstName + lastName;
            Console.WriteLine(name1);
            string myString = "Hello";
            Console.WriteLine(myString[1]);
            int x1 = 20;
            int y1 = 18;
            if (x1 > y1)
            {
                Console.WriteLine("x1 is greater than y1");
            }
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            for (int k = 0; k < cars.Length; k++)
            {
                Console.WriteLine(cars[k]);
            }
            Array.Sort(cars);
            foreach (string l in cars)
            {
                Console.WriteLine(l);

            }
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5; 
            Console.WriteLine(numbers[0, 0]);
            int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i1 in numbers)
            {
                Console.WriteLine(i1);
            }
            MyMethod();
            Program myObj = new Program();
            Console.WriteLine(myObj.color);
            Class1 obj1= new Class1();
            Console.WriteLine(obj1.name);
            Console.WriteLine(obj1.age);
            obj1.setName("shivam datta");
            Console.WriteLine(obj1.name);


            Console.ReadLine();

        }
    }
}
