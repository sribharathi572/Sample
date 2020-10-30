using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;

namespace Lab1
{
    class Lab1_1
    {
        static void main(string[] args)
        {
            Employee.Class1 c = new Class1();
            string[,] arr= new string [10,6];
            Console.WriteLine("enter the following columns: EmployeeId, Employee Name, Address, City, Department, Salary");
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    arr[i, j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < 10; i++)
            {
                c.setName(arr[i, 1]);
                c.setSal(arr[i, 5]);
                Console.WriteLine("employee " + c.getName());
                Console.WriteLine("salary " + c.getSal());
            }
            Console.ReadLine();

        }
    }
}
