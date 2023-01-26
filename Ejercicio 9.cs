//Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo
using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] factoriales = new int[10];
        factoriales[0] = 1;
        factoriales[1] = 1;
        for (int i = 2; i < 10; ++i)
        {
            factoriales[i] = i * factoriales[i - 1];
        }

        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine(factoriales[i]);
        }
    }
}
