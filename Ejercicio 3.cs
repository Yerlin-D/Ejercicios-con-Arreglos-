//Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.
using System;
using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        int[] primos = new int[10];
        int x = 0;
        int y = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            x = int.Parse(Console.ReadLine());
            arreglo[i] = x;
            if ((x % 2 != 0 && x % 3 != 0 && x % 5 != 0 && x % 7 != 0) || (x == 2 || x == 3 || x == 5 || x == 7))
            {
                y = x;
                primos[i] = y;
            }
        }
        int mayor;
        mayor = primos.Max();
        int indice = Array.IndexOf(arreglo, mayor);
        Console.WriteLine("El mayor número primo del arreglo esta en la posicion " + indice);
    }
}