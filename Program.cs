using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, productoCuadrado;
            string perimetro;
            Console.Write("Ingrese el valor del lado");
            perimetro = Console.ReadLine();
            lado = int.Parse(perimetro);
            productoCuadrado = lado * 4;
            Console.Write("El producto del cuadrado es:");
            Console.WriteLine(productoCuadrado);
            Console.ReadKey();

        }
    }
}
