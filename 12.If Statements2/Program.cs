using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.If_Statements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 10));
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
            Console.ReadLine();
        }
    }
}
