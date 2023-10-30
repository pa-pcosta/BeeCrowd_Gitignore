using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Schema;

namespace URI_C__1036
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ler 3 variaveis double de uma string
            string[] coeficientes = Console.ReadLine().Split(' ');

            double a = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            double b = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            double c = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);
            double delta = calculaDelta(a, b, c);

            //Validar se é possível calcular as raizes
                //a != 0 && delta >=0
            if (!validaSeEhPossivelCalcularRaizes(a, delta))
            {
                Console.WriteLine("Impossivel calcular");

                Console.ReadLine();

                return;
            }

            //Calcular raízes

            //Imprimir com 5 casas decimais

            Console.WriteLine($"R1 = {calculaR1(a, b, delta):F5}");
            Console.WriteLine($"R2 = {calculaR2(a, b,delta):F5}");

            Console.ReadLine();
        }

        static bool validaSeEhPossivelCalcularRaizes(double a, double delta)
        {
            if ((a == 0) || (delta < 0)) 
                { return false; }
            else 
                { return true; }
        }

        static double calculaDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static double calculaR1(double a, double b, double delta)
        {
            return (-b + Math.Sqrt(delta)) / (2 * a);
        }

        static double calculaR2(double a, double b, double delta)
        {
            return (-b - Math.Sqrt(delta)) / (2 * a);
        }
    }
}
