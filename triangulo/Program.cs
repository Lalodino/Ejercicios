using System;

class Program
{
    static void Main()
    {
        string continuar;

        do
        {
            Console.Clear();
            Console.WriteLine("Calculadora de áreas de triángulos.");
            Console.WriteLine("Selecciona el tipo de triángulo:");
            Console.WriteLine("1. Triángulo equilátero");
            Console.WriteLine("2. Triángulo isósceles");
            Console.WriteLine("3. Triángulo escaleno");

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: // Triángulo equilátero
                    Console.Write("Ingresa la longitud de un lado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());

                    // Fórmula para el área del triángulo equilátero
                    double areaEquilatero = (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
                    Console.WriteLine($"El área del triángulo equilátero es: {areaEquilatero:F2}");
                    break;

                case 2: // Triángulo isósceles
                    Console.Write("Ingresa la longitud de los lados iguales: ");
                    double ladoIgual = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingresa la longitud de la base: ");
                    double baseIsosceles = Convert.ToDouble(Console.ReadLine());

                    // Validación del triángulo
                    if (baseIsosceles >= 2 * ladoIgual)
                    {
                        Console.WriteLine("La base debe ser menor que la suma de los lados iguales para formar un triángulo válido.");
                    }
                    else
                    {
                        // Fórmula para la altura del triángulo isósceles
                        double alturaIsosceles = Math.Sqrt(Math.Pow(ladoIgual, 2) - Math.Pow(baseIsosceles / 2, 2));
                        double areaIsosceles = (baseIsosceles * alturaIsosceles) / 2;
                        Console.WriteLine($"El área del triángulo isósceles es: {areaIsosceles:F2}");
                    }
                    break;

                case 3: // Triángulo escaleno
                    Console.Write("Ingresa el lado a: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingresa el lado b: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingresa el lado c: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    // Validación de triángulo escaleno
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        double p = (a + b + c) / 2; // Semiperímetro
                        double areaEscaleno = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Fórmula de Herón
                        Console.WriteLine($"El área del triángulo escaleno es: {areaEscaleno:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Los lados proporcionados no forman un triángulo válido.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor, selecciona 1, 2 o 3.");
                    break;
            }

            Console.Write("\n¿Quieres calcular otro triángulo? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");

        Console.WriteLine("Gracias por usar la calculadora de áreas. ¡Hasta luego!");
    }
}
