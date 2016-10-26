using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your max integer:");
                int max = int.Parse(Console.ReadLine());
                Table(max);
                Console.WriteLine("Do you wish to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                    break;
            }
        }
        static void Table(int max)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,-10}", "Number", "Squared", "Cubed"));
            Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,-10}", "======", "======", "======"));
            for (int i = 1; i <= max; i++)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);
                Console.WriteLine(String.Format("{0,-10}  {1,-10}  {2,-10}", i, square, cube));
            }
        }
    }
}