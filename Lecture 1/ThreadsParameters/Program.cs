﻿using System;
using System.Threading;

namespace ThreadsParameters
{
    class Program
    {
        static void Worker(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(data.ToString() + ": " + i);
                Thread.Sleep(5);
            }
            Console.WriteLine(data.ToString() + " is ready.");
        }
        static void Main(string[] args)
        {
            var t1 = new Thread(Worker);
            t1.Start("A");
            var t2 = new Thread(Worker);
            t2.Start("B");

            Console.ReadLine();
        }
    }
}
