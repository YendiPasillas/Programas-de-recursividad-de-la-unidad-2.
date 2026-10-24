//Cuenta regresiva alternando dos metodos (recursividad indirecta) obj; mostrar una cuenta regresevia desde un numero hasta cero utilizando dos metodos que se llaman entre si.
using System;

class program
{
    // Método A que imprime el estado A y delega el siguiente paso a CuentaB
    static void CuentaA(int n)
    {
        // detenerse al llegar a valores menores a 0
        if (n < 0)
            return;
        Console.WriteLine("A:" + n);


        CuentaB(n - 1);
    }
    static void CuentaB(int n)
        {
            if (n < 0)
                return;
            Console.WriteLine("B:" + n);
        CuentaA(n - 1);

        
    }
    static void Main()
    {
        // Lectura del número inicial
        Console.Write("Ingresa el numero inicial: ");
        int n= int.Parse(Console.ReadLine());
// Validación de rango
        if(n<0 || n> 1000)
        {
            
            Console.WriteLine("Ingresa un numero entre 0 y 1000");
            return;


        }
        // Inicia la cadena de llamadas alternadas con CuentaA
        CuentaA(n);

    }
}