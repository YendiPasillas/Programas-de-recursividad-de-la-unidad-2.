//Recursividad indirecta obj. convertir un numero entero no negativo a su representacion binaria usando dos metodos que se llaman mutuamente.
using System;
class program
{
    // Método A para conversión binaria
    static void BinarioA(int n)
    {
        // si n es 0 o 1, se imprime directamente
        if (n<2)
        {
            Console.Write(n);
            return;
        }
        BinarioB(n / 2);
        Console.Write(n % 2);
    }
    // Método B equivalente a BinarioA
    static void BinarioB(int n)
    {
        if(n < 2)
        {
            Console.Write(n);
            return;

        }
        BinarioA(n / 2);
        // Imprime el residuo
        Console.Write(n % 2);

    }
    static void Main()
    {
        // Lectura de un entero positivo o cero
        Console.Write("Ingresa un numero entero: ");
        int n = int.Parse(Console.ReadLine());

        // Validación de enteros no negativos
        if (n < 0)
        {
            Console.WriteLine("Ingresa un numero no negativo:");
            return;
        }
        Console.Write("Binario: ");

        // Caso especial para 0
        if (n == 0)
            Console.Write("0");
        else
            BinarioA(n);

        Console.WriteLine();
    }
}
