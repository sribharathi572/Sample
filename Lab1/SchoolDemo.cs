using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SchoolDemo
    {
        private int roll;
        private string stud;
        private byte age;
        private char gender;
        private DateTime dob;
        private string add;
        private float percent;
        public SchoolDemo(int roll,string stud, byte age,char gender,DateTime dob, string add, float percent)
        {
            this.roll = roll;
            this.stud = stud;
            this.age = age;
            this.gender = gender;
            this.dob=dob;
            this.add = add;
            this.percent = percent;
        }
        public int getroll()
        {
            return roll;
        }
        public string getstud()
        {
            return stud;
        }
        public byte getage()
        {
            return age;
        }
        public char getgender()
        {
            return gender;
        }
        public DateTime getdob()
        {
            return dob;
        }
        public string getadd()
        {
            return add;
        }
        public float getper()
        {
            return percent;
        }
        static void main(string[] args)
        {
            DateTime dt = new DateTime(2000, 08, 20);
            SchoolDemo s = new SchoolDemo(123,"maya",20,'f',dt,"hyd",90);
            Console.WriteLine("roll number "+s.getroll());
            Console.WriteLine("Student name " + s.getstud());
            Console.WriteLine("Age " + s.getage());
            Console.WriteLine("gender " + s.getgender());
            Console.WriteLine("date of birth " + s.getdob());
            Console.WriteLine("address " + s.getadd());
            Console.WriteLine("percentage " + s.getper());
            Console.ReadLine();
        }
    }
    
}
