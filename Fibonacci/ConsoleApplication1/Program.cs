using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Any Number: ");
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.Write("Number {0} is Even", num);
            }
            else
            {
                Console.Write("Number {0} is Odd", num);
            }
            Console.ReadLine();
        }
    }
}
