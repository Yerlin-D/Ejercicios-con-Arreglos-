/// Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo
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

            string str = Convert.ToString(x);
            str = str.Substring(0, 1);
            int numstr = Int32.Parse(str);
            if (numstr == 2 || numstr == 3 || numstr == 5 || numstr == 7)
            {
                y = y + z;
            }
        }
        Console.WriteLine(y + " números de los almacenados en el arreglo comienzan con un dígito primo");
    }
}