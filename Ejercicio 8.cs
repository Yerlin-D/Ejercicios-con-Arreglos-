//Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.
using System;
class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        int x = 0;
        int y = 0;
        int z = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            x = int.Parse(Console.ReadLine());
            arreglo[i] = x;
            if (x < 0)
            {
                y = y + z;
            }
        }
        Console.WriteLine("Hay " + y + " números negativos en el arreglo");
    }
}