using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_project
{
    class objectex
    {
        static void main(string[] args)
        {
            //int a = 2;
            //object ob;
            //ob = a;
            //Console.WriteLine(ob);
            //int b = (int)ob;
            //Console.WriteLine(b);
            //string s = "hey";
            //ob = s;
            //Console.WriteLine(ob);
            //string v = (string)ob;
            //Console.WriteLine(v);


            //Console.Write("array size: ");
            //int n= int.Parse(Console.ReadLine());
            //Console.Write("array 1: ");
            //int[] arr = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    arr[i]=int.Parse(Console.ReadLine());
            //}
            //Console.Write("array 2: ");
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    arr2[i] = arr[i] + arr1[i];
            //}
            //foreach (int i in arr2)
            //    Console.WriteLine(i);

            Console.Write("array sets: ");
            int n = int.Parse(Console.ReadLine());
            int num;
            var arr = new int[n][];
            for (int outer = 0; outer < n; outer++)
            {
                Console.Write("set values : ");
                num = int.Parse(Console.ReadLine());
                arr[outer] = new int[num];
                Console.Write("enter values : ");
                for (int i = 0; i < num; i++)
                {
                    arr[outer][i] = int.Parse(Console.ReadLine());
                }
            }
            for (int outer = 0; outer < arr.Length; outer++)
            {
                for (int i = 0; i < arr[outer].Length; i++)
                {
                    Console.Write(arr[outer][i]+" ");
                }
            }
            Console.ReadLine();
        }
    }
}