//Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo
using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        int x = 0;
        int prom;
        int suma;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            x = int.Parse(Console.ReadLine());
            arreglo[i] = x;
        }
        suma = arreglo.Sum();
        prom = suma / arreglo.Length;
        Console.Write("El promedio de los datos del arreglo es " + prom);
    }
}