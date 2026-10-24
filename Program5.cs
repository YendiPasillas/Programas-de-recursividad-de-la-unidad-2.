//invertir el orden de los digitos de un numero entero positivo mediante llamadas recursivas.
using System;

class program
{
    // Función recursiva de cola para invertir dígitos
    static long invertir(long n,long resultado = 0)
    {
        if (n == 0)
            return resultado;

        return invertir(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        // Solicita el número entero positivo
        Console.Write("Ingresa un numero positivo: ");
        long n = long.Parse(Console.ReadLine());

        // Validación de número positivo
        if (n<0)
        {
            Console.WriteLine("El numero debe ser positivo ");
            return;
        }
        // Imprime el número invertido
        Console.WriteLine("Numero invertido: " +
            invertir(n));

    }
}