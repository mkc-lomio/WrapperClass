using System;

namespace WrapperClass
{
    class Salary //Wrapper Class
    {
        class Tax //Inner Class
        {
            public int CalculateTax(int Val)
            {
                return Val - 10;
            }
        }

        public int GetSalary()
        {
            Salary.Tax wpr = new Salary.Tax(); // Internally call to Wrapper class.
            return wpr.CalculateTax(100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Salary w = new Salary();
            Console.WriteLine("Your salary is " + w.GetSalary());
            Console.ReadLine();
        }
    }
}
