using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Employee
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            data.Add(67);
            data.Add(2);
            data.Add(60);
            data.Add(4);
            foreach(int i in data)
            {
             Console.WriteLine(i);
            }/*
            data.Add(7);
            foreach(int i in data)
            {
                Console.WriteLine(i);

            }
            data.RemoveAt(2);
            foreach(int i in data)
            {
                Console.WriteLine(i);
            */
            if (data.Contains(70))
            {
                Console.WriteLine("Exit data");
            }
            else
            {
                Console.WriteLine("Not Exit data");
            }
        }
    }
}
