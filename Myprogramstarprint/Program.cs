using System;
namespace Myprogramstarpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            for (int i =1 ; i <=7; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();    
            }
            Console.ReadLine();

        }
    }
}
