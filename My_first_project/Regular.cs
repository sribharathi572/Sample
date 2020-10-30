using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace My_first_project
{
    class Regular
    {
        static void main(string[] args)
        {
            string input = Console.ReadLine();
            string template = @"[6-8]\d{9}";
            bool res = Regex.IsMatch(input, template);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
