//programa que  calcula la suma de todos los numeros enteros desde 1 hasta el numero ingresado
using System;
class program
{
    // Función recursiva que suma enteros desde n hasta 1
    static int suma(int n)
    {
       // cuando se alcanza 0 o un valor menor
        if (n <= 0)
            return 0;

        return n + suma(n - 1);

    }
    static void Main()
    {
        // Entrada de datos del usuario
        Console.WriteLine("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validación de rango (0 a 10000)
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000. ");
            return;
        }
        // Imprime la suma calculada
        Console.WriteLine("La suma es: " + suma(n));
    }

}