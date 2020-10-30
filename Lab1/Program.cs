using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a= int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("you typed 1");
                    break;
                case 2:
                    Console.WriteLine("you typed 2");
                    break;
                case 3:
                    Console.WriteLine("you typed 3");
                    break;
                case 4:
                    Console.WriteLine("you typed 4");
                    break;
                case 5:
                    Console.WriteLine("you typed 5");
                    break;
                default:
                    Console.WriteLine("you typed wrong");
                    break;
            }
            Console.ReadLine();
        }
    }
}
