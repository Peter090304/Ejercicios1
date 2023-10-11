using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();

            // Ejecutar los ejercicios
            Console.WriteLine("Ejercicio 1:");
            ejercicios.Ejercicio1();
            Console.WriteLine("-------------");

            Console.WriteLine("Ejercicio 2:");
            ejercicios.Ejercicio2();
            Console.WriteLine("-------------");

            Console.WriteLine("Ejercicio 3:");
            ejercicios.Ejercicio3();
            Console.WriteLine("-------------");

            Console.WriteLine("Ejercicio 4:");
            ejercicios.Ejercicio4();
            Console.WriteLine("-------------");

            Console.WriteLine("Ejercicio 5:");
            ejercicios.Ejercicio5();
            Console.WriteLine("-------------");
        }
    }
}

