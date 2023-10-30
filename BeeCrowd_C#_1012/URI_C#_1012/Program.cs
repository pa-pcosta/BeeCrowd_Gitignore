using System;
using System.Linq;
using System.Globalization;

namespace URI_C__1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler A, B e C de uma string

            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //Calcular AREA triangulo BASE=A e ALTURA=C
            Console.WriteLine($"TRIANGULO: {CalculaAreaTriangulo(A, C):F3}");

            //Calcular AREA circulo RAIO=C
            Console.WriteLine($"CIRCULO: {CalculaAreaCirculo(C):F3}");

            //Calcular AREA trapezio BASE1=A, BASE2=B, ALTURA=C
            Console.WriteLine($"TRAPEZIO: {CalculaAreaTrapezio(A,B,C):F3}");

            //Calcular AREA quadrado LADO=B
            Console.WriteLine($"QUADRADO: {CalculaAreaRetangulo(B, B):F3}");

            //Calcular AREA retangulo LADO1=A, LADO2=B
            Console.WriteLine($"RETANGULO: {CalculaAreaRetangulo(A, B):F3}");

            //Imprimir cada calculo em uma linha. Formatação números F3
           
            Console.ReadLine();

        }

        static double CalculaAreaTriangulo(double baseh, double altura)
        {
            return (baseh * altura) / 2;
        }

        static double CalculaAreaCirculo(double raio)
        {
            return 3.14159 * Math.Pow(raio, 2.0);
        }

        static double CalculaAreaTrapezio(double base1, double base2, double altura)
        {
            return (base1 + base2) / 2 * altura;
        }

        static double CalculaAreaRetangulo(double lado1, double lado2)
        {
            return lado1 * lado2;
        }
    }
}
