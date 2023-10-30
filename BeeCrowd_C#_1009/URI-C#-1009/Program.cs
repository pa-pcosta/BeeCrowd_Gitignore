using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_C__1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
              string nome;
              double salario, vendas;

              nome = Console.ReadLine();
              salario = Convert.ToDouble(Console.ReadLine());
              vendas = double.Parse(Console.ReadLine());
              double comissao = vendas * 0.15;

            /* DEBUG
              Console.WriteLine($"SALARIO = {salario:F2}");
              Console.WriteLine($"VENDAS = {(vendas).ToString("F3")}");
              Console.WriteLine($"COMISSAO = {comissao:F3}");
            */
              
              Console.WriteLine($"TOTAL = {(salario + comissao).ToString("F2")}");

            Console.ReadLine();
        }
    }
}
