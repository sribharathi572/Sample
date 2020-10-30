using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_project
{
    class sample
    {
        static void main(string[] args) {
            Console.WriteLine("select one option 1.celsius to fahrenheit or 2.fahrenhiet to celsius");
            int num;
            float c;
            float f;
            num = int.Parse(Console.ReadLine());
            if (num == 1) {
                Console.Write("give the temperature in celsius: ");
                c = float.Parse(Console.ReadLine());
                f = ((c * 9) / 5) + 32;
                Console.WriteLine("The temperature in fahrenheit is: "+f.ToString());
            }
             else if (num == 2)
            {
                Console.Write("give the temperature in fahrenheit: ");
                f = float.Parse(Console.ReadLine());
                c = ((f - 32) * 5) / 9;
                Console.WriteLine("The temperature in celsius is: " + c.ToString());
            }
            Console.ReadLine();
        }
    }
}
