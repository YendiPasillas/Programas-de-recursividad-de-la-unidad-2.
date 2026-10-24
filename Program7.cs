//Determinar si un numero entero no negativo es par o impar.
using System;
class program
{
    // Determina si n es Par llamando a EsImpar
    static bool EsPar(int n)
    {
        //0 siempre es Par
        if (n == 0)
            return true;

        return EsImpar(n - 1);
    }
    // Determina si n es Impar llamando a EsPar
    static bool EsImpar(int n)
    {
        // 0 NO es Impar
        if (n == 0)
            return false;

        return EsPar(n - 1);
    }
    static void Main()
    {
        // Entrada del número a evaluar
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine());

        // Validación de rango
        if (n < 0  || n > 10000)
        {
            Console.WriteLine("Ingresa un numero entre 0 y 10000:");
            return;
        }
        // Evalúa la par llamando al método inicial EsPar
        if (EsPar(n))
            Console.WriteLine("El numero es par. ");
        else
            Console.WriteLine("El numero es impar. ");
    }
}