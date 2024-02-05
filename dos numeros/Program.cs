
using System;
class DosNumeros
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese el primer valor");
            double Numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            double Numero2 = double.Parse(Console.ReadLine());
            if (Numero1 > Numero2)
            {
                double Suma = Numero1 + Numero2;
                double Resta = Numero1 - Numero2;
                Console.WriteLine($"La suma de los numeros es: {Suma}");
                Console.WriteLine($"La resta de los numeros es: {Resta}");

            }
            else
            {
                double Producto = Numero1 * Numero2;
                if (Numero2 != 0)
                {
                    double Division = Numero1 / Numero2;
                    Console.WriteLine($"El producto de los numeros es: {Producto}");
                    Console.WriteLine($"La division del numero primero respecto al segundo  es: {Division}");
                }
                else
                {
                    Console.WriteLine("El segundo valor es 0, no se puede realizar la division");
                }
            }
        } catch (FormatException)
        {
            Console.WriteLine("Error. Ingrese un valor valido");

        }
        catch (Exception ex) 
        {
            Console.WriteLine($"Error. Enter para salir: {ex.Message}");
        
        }
    }

}
