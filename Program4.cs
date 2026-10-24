//calcular una potencia entera no negativa utilizando recursividad
using System;

class program
{
 // Función recursiva para elevar 'baseNum' al 'exponente'
    static long potencia(int baseNum, int exponente)
    {
        // Cualquier número elevado a la potencia 0 da 1
        if (exponente == 0)
            return 1;

        // Llamada recursiva multiplicando la base por la potencia restante
        return baseNum * potencia(baseNum, exponente - 1);
    }
    static void Main()
    {
        // Captura de la base
        Console.WriteLine("Ingresa la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        // Captura del exponente
        Console.Write("Ingresa el exponente  (0 - 30): ");
        int exponente = int.Parse(Console.ReadLine());

        // Validación del exponente
        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango. ");
            return;
        }
        // Imprime la potencia calculada
        Console.WriteLine("Resultado: " + potencia(baseNum, exponente));
    }
}
