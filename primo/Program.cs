using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Introduce un número:"); // Solicitar un número al usuario
            int numero = int.Parse(Console.ReadLine()); // Leer el número como entero

            if (EsPrimo(numero))
            {
                Console.WriteLine($"El número {numero} es primo."); // Mensaje si el número es primo
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo."); // Mensaje si el número no es primo
            }

        } while (Reintentar()); // Repetir el programa si el usuario lo desea
    }

    /// <summary>
    /// Verifica si un número es primo.
    /// </summary>
    /// <param name="n">Número a verificar</param>
    /// <returns>True si el número es primo, False en caso contrario</returns>
    static bool EsPrimo(int n)
    {
        if (n <= 1) // Los números menores o iguales a 1 no son primos
        {
            return false;
        }

        // Comprobar divisores desde 2 hasta la raíz cuadrada del número
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) // Si el número es divisible por i, no es primo
            {
                return false;
            }
        }
        
        return true; // Si no se encontró divisor, el número es primo
    }

    /// <summary> 
    /// Pregunta al usuario si desea ejecutar el programa nuevamente.
    /// </summary>
    /// <returns>True si el usuario desea continuar, False en caso contrario</returns>
    static bool Reintentar()
    {
        Console.WriteLine("¿Deseas verificar otro número? (S/N)"); // Preguntar si desea continuar
        string respuesta = Console.ReadLine().Trim().ToUpper(); // Leer y normalizar respuesta
        return respuesta == "S"; // Continuar solo si la respuesta es 'S'
    }
}
