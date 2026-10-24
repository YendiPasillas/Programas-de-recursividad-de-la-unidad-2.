//sumar todos los digitos de un numero entero positivo
using System;

class program
{
    // Función recursiva que descompone y suma los dígitos
    static int SumarDigito(int n)
    {
        // si el número es 0, la suma es 0
        if (n == 0)
            return 0;

        return n % 10 + SumarDigito(n / 10);
    }
    static void Main()
    {
        // Lectura del número entero
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validación para evitar enteros negativos
        if (n<0)
        {
            Console.WriteLine("Ingresa un numero positivo: ");
            return;
        }
        // Muestra la suma total de sus dígitos
        Console.WriteLine("Suma de datos: " + SumarDigito(n));
    }
}
