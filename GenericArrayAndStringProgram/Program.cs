using System;

namespace GenericArrayAndStringProgram
{
    class Employee
    {
        public static void showDeatail<T>(T[]arr)
        {
            foreach(T getvalue in arr)
            {
                Console.WriteLine(getvalue);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[4];
            data[0] = 43;
            data[1] = 4638;
            data[2] = 354;
            data[3] = 436;
          string[] data1=new string[4];
            data1[0] = "Amit Kumar";
            data1[1] = "Saurabh Kumar";
            data1[2] = "Kaushal Kumar";
            data1[3] = "Snil Kumar";
            Employee emp=new Employee();
            Employee.showDeatail(data);
            Employee.showDeatail(data1);

        }
    }
}
