using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello");
            Console.WriteLine("привет мир");

            int[] a = { 1, 2, 3 };

            foreach (int i in a)
            {
                Console.WriteLine(i); 
            }

            Console.WriteLine("Connect...");
            Console.Write("\a");
            Console.WriteLine("Done!");

            //123 привет 
            Console.WriteLine("я уже сделал вывод бита в консоль в ветке feature");

            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");
            Console.WriteLine("hello");

        }
    }
}
