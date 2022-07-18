//Write a class ‘Demo’ having some methods in it. Use the concept of extended
//method and add some additional methods to the class ‘Demo’.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_cs
{
    public class Demo
    {

        public void sawping()
        {
            int temp;
            Console.WriteLine("Enter Two Number To swap");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Before sawping");
            Console.WriteLine($"{num1} and {num2}");


            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("after sawping");
            Console.WriteLine($"{num1} and {num2}");
            Console.WriteLine("press any Key to continue");
            Console.ReadKey();
            Console.Clear();
        }


        public void temp_fact()
        {
            int a = 0;
            demo_2.fact(a);
        }
        public void Temp_palin()
        {
            int b = 0;
            demo_2.palin(b);
        }
    }

    public static class demo_2
    {
        public static void palin(this int a)
        {
            int rem;
            int rev = 0;
            int original;

            Console.WriteLine("Enter A number to check if it is a palindrome");
            int num=int.Parse(Console.ReadLine());
            original = num;

            while(num != 0)
            {
                rem = num % 10;
                rev = rev *10 + rem;
                num = num / 10;
            }

            if(original == rev)
            {
                Console.WriteLine($"is a Palindrome Number");
                Console.WriteLine("press any Key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"{original} is not a Palindrome Number");
                Console.WriteLine("press any Key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void fact(this int b)
        {
            Console.WriteLine("Provide a Integer Number to Get all factors");
            int factnum = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"All Factors of {factnum} are : ");
            
            for(int i = 1; i < factnum; i++)
            {
                if (factnum % i == 0)
                {
                    int k = i;
                    Console.Write($" "+k);
                }
            }
            
            
        }
    }
}
