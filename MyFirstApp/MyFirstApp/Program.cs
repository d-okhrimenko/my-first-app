using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Add(10, 20);

            Console.WriteLine("Hello world - Feature 1 - 000");
            Console.WriteLine("Hello world - Feature 3");
            Console.ReadLine();
        }
    }
}
