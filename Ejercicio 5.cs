//Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares.
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
                string str = Convert.ToString(y);
                str = str.Substring(0, 1);
                int numstr = Int32.Parse(str);
                if (numstr == 2 || numstr == 3 || numstr == 5 || numstr == 7)
                {
                    y = y + x;
                }
            }

        }

    }

}
        