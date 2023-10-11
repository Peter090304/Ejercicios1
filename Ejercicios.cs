


using System;

namespace Ejercicios1
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            int[] arreglo1 = { 1, 5, 8, 3, 9 };
            Console.WriteLine("Arreglo 1:");
            foreach (var num in arreglo1)
            {
                Console.WriteLine(num);
            }
        }

        public void Ejercicio2()
        {
            int[] arreglo2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un valor numérico: ");
                arreglo2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Arreglo 2:");
            foreach (var num in arreglo2)
            {
                Console.WriteLine(num);
            }
        }

        public void Ejercicio3()
        {
            int[] arreglo3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arreglo3[i] = i * 2; // Inserta los valores numéricos que desees aquí
            }
            double suma = 0;
            foreach (var num in arreglo3)
            {
                suma += num;
            }
            double media = suma / arreglo3.Length;
            Console.WriteLine("Media de los valores en el arreglo 3: " + media);
        }

        public void Ejercicio4()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número para generar los múltiplos: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] arreglo4 = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arreglo4[i] = (i + 1) * numero;
            }
            Console.WriteLine("Arreglo 4:");
            foreach (var num in arreglo4)
            {
                Console.WriteLine(num);
            }
        }

        public void Ejercicio5()
        {
            Console.Write("Ingrese el tamaño de los arreglos: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            string[] nombres = new string[tamaño];
            int[] longitudes = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingrese un nombre: ");
                nombres[i] = Console.ReadLine();
                longitudes[i] = nombres[i].Length;
            }
            Console.WriteLine("Nombres y sus longitudes:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Nombre: " + nombres[i] + ", Longitud: " + longitudes[i]);
            }
        }
    }
}

