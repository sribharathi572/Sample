using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_project
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("My First Example");
            Console.Write("give the character: ");
            char ch;
            // ch = char.Parse(Console.ReadLine());
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch.ToString()+ " is a vowel");
            }
            else {
                Console.WriteLine(ch.ToString()+ " is not a vowel");
            }
            Console.ReadLine();
        }
    }
}
