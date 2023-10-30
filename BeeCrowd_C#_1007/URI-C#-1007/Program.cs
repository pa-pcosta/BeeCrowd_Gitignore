using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_C__1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"DIFERENCA = {a * b - c * d}");
        }
    }
}
