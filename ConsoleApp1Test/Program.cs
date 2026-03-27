using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

            string filePath = @"C:\Users\Asus\Downloads\Project_1.wav";
            using (var player = new SoundPlayer(filePath))
            {
                player.Play();
                Console.ReadKey();
                player.Stop();
            }
        }
    }
}
