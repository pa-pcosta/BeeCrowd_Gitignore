using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI_C__1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler 3 variaveis de uma string
            string[] arestas = Console.ReadLine().Split(' ');

            double a = double.Parse(arestas[0], CultureInfo.InvariantCulture);
            double b = double.Parse(arestas[1], CultureInfo.InvariantCulture);
            double c = double.Parse(arestas[2], CultureInfo.InvariantCulture);

            //Se formar triangulo calcular perimetro
            if(VerificaSeFormaTriangulo(a, b, c))
            {
                Console.WriteLine($"Perimetro = {(a + b + c).ToString("F1", CultureInfo.InvariantCulture)}");
            }
            //Se nao formar triangulo calcular area do trapezio BASE1=A, BASE2=B, ALTURA=C;
            else
            {
                Console.WriteLine($"Area = {((a + b) * c /2).ToString("F1", CultureInfo.InvariantCulture)}");
            }
            //Imprimir com 1 casa decimal

            Console.ReadLine();
        }

        public static bool VerificaSeFormaTriangulo(double a, double b, double c)
        {
            return ((a < b+c) && (a > Math.Abs(b-c))) || ((b < a + c) && (b > Math.Abs(a - c))) || ((c < b + c) && (c > Math.Abs(b - a)));
        }
    }
}
