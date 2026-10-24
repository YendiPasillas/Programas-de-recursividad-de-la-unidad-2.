//el termino f se llama dos veces a si mismo para calcular los dos terminos anteriores
using System;
class program
{
    // Función recursiva para obtener el n-ésimo término de Fibonacci
    static int fibonacci(int n)
    {
        if (n <= 1)
            return n;

        // Llamada recursiva doble para sumar los dos términos previos
        return fibonacci(n - 1) + fibonacci(n - 2);

    }
    static void Main()
    {
        // Solicita la posición deseada en la serie
        Console.WriteLine("Ingresa la posicion: ");
        int n = int.Parse(Console.ReadLine());

        // Validación del rango permitido
        if (n< 0 && n > 40)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 40");
            return;

        }
        // Muestra el valor de Fibonacci en la posición indicados
        Console.WriteLine("fibonacci: " + fibonacci(n));
 }
}