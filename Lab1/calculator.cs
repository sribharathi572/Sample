using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CreateMathLibrary;

namespace Lab1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            
            CreateMathLibrary.ArithmeticOperations o = new ArithmeticOperations();
            Console.WriteLine("Calculator operations: 1.Add, 2.Subtract, 3.Multiply, 4.Division, 5.Modulus");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("are your number 1.int or 2.double");
            int j = int.Parse(Console.ReadLine());
            if (j == 1)
            {
                Console.WriteLine("enter numbers");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        int add = o.Add(a, b);
                        Console.WriteLine(add);
                        break;
                    case 2:
                        int sub = o.Sub(a, b);
                        Console.WriteLine(sub);
                        break;
                    case 3:
                        int mul = o.Mul(a, b);
                        Console.WriteLine(mul);
                        break;
                    case 4:
                        int div = o.Div(a, b);
                        Console.WriteLine(div);
                        break;
                    case 5:
                        int mod = o.Mod(a, b);
                        Console.WriteLine(mod);
                        break;
                    default:
                        Console.WriteLine("enter correct value");
                        break;
                }
            }
            else if (j == 2)
            {
                Console.WriteLine("enter numbers");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        double add = o.Add(a, b);
                        Console.WriteLine(add);
                        break;
                    case 2:
                        double sub = o.Sub(a, b);
                        Console.WriteLine(sub);
                        break;
                    case 3:
                        double mul = o.Mul(a, b);
                        Console.WriteLine(mul);
                        break;
                    case 4:
                        double div = o.Div(a, b);
                        Console.WriteLine(div);
                        break;
                    case 5:
                        double mod = o.Mod(a, b);
                        Console.WriteLine(mod);
                        break;
                    default:
                        Console.WriteLine("enter correct value");
                        break;
                }
            }
            else
                Console.WriteLine("only int or double types");
            Console.ReadLine();
        }
    }
}
