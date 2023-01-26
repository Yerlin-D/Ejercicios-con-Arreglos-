//  Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos

using System;
using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        int[] arreglo = new int[10];
        int[] mayor = new int[10];
        int x = 0;
        int y = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Ingrese el número " + (i + 1) + ": ");
            x = int.Parse(Console.ReadLine());
            arreglo[i] = x;
            if (x>= 100 || x<= 999)
            {
                y = x;
                mayor[i] = y;
                string str = Convert.ToString(y);
                str = str.Substring(0, 1);
                int numstr = Int32.Parse(str);
               Console.WriteLine();
            }



        }
    }
}