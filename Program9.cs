//suma de numero mediante recusividad indirecta
//obj. Calcular la suma de los numeros desde 1 hasta n utilizando metodos que se llaman mutuamente.
using System;

class program
{
    // Método A suma n con el resultado de SumaB(n - 1)
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;

        return n + SumaB(n - 1);
    }
    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;

        return SumaA(n - 1);
    }
    static void Main()
    {
        // Entrada del número
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n< 0 || n> 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000: ");
            return;
        }
        // Imprime el resultado total de la suma
        Console.WriteLine("La suma es: " + SumaA(n));
    }
}