//Write a program which will implement the concept of multithreading.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_cs
{
    internal class Multi_Thread
    {
        private int Color_Count = 100;
        public void Red()
        {
            for(int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Whats up !! I am RED");
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }
        public void green()
        {
            for (int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Alright I am Green");
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }
        public void white()
        {
            for (int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("I am White :)");
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }
        public void yellow()
        {
            for (int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Here Come The Yellow");
                Console.WriteLine();
                Thread.Sleep(50);
            }
        }
        public void ocean()
        {
            for (int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ok i can feel the ocean");
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }
        public void gray()
        {
            for (int i = 0; i < Color_Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Hey There its Gray !!");
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }


    }
}
