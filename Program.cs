using System;

namespace TP1_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Transformar de grados sexagesimales a radianes";

            double constante, sexagesimales, radianes;

            Console.Write("Ingrese el valor sexagesimal: ");
            sexagesimales = Convert.ToSingle(Console.ReadLine());

            constante = 0.0174532925;
            radianes= sexagesimales*constante;

            Console.Write($"el valor en radianes es {radianes}");
        }
    }
}
