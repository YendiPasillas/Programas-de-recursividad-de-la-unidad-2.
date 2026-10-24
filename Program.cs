using System;
class program
{
    // Función recursiva para calcular el factorial de un número n
    static long factorial(int n)
    {
        // El factorial de 0 es 1
        if (n == 0)
            return 1;

        // Llamada recursiva: n * factorial(n - 1)
        return n * factorial(n - 1);
    }
    static void Main()
    {
        // Solicita al usuario ingresar un número
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());
        // Validación del rango permitido 
        if (n<0 && n>20)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 20");
            return;
        }
        // Muestra el resultado calculando el factorial
        Console.WriteLine("Factorial: " + factorial(n));
    }
}