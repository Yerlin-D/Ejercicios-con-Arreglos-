//Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.
using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        int x = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            x = int.Parse(Console.ReadLine());
            arreglo[i] = x;
        }
        int mayor;
        mayor = arreglo.Max();
        int indice = Array.IndexOf(arreglo, mayor);
        Console.WriteLine("El mayor número del arreglo se encuentra en la posicion " + indice);
    }
}