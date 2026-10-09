using System;

// Clase: CilindroNeumatico
class CilindroNeumatico
{
    // Propiedades
    public double PresionKpa { get; set; }
    public double AreaCm2 { get; set; }
    public double RequerimientoMinimo { get; set; }

    // Método para calcular la fuerza del cilindro
    public double CalcularFuerza()
    {
        double presionPa = PresionKpa * 1000;
        double areaM2 = AreaCm2 / 10000;
        return presionPa * areaM2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Ejercicio 2: Fuerza de Cilindro Neumático ---");

        // Objeto creado a partir de la clase CilindroNeumatico
        CilindroNeumatico cilindro = new CilindroNeumatico();

        Console.Write("Ingrese la presión en kPa: ");
        cilindro.PresionKpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el área efectiva del pistón en cm²: ");
        cilindro.AreaCm2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el requerimiento mínimo de fuerza (N): ");
        cilindro.RequerimientoMinimo = Convert.ToDouble(Console.ReadLine());

        // Llamada al método
        double fuerza = cilindro.CalcularFuerza();
        Console.WriteLine($"Fuerza calculada: {fuerza} N");

        if (fuerza >= cilindro.RequerimientoMinimo)
        {
            Console.WriteLine("La fuerza cumple con el requerimiento.");
        }
        else
        {
            Console.WriteLine("La fuerza NO cumple con el requerimiento.");
        }
    }
}