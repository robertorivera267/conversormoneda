using System;

class ConversorMonedas
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- CONVERSOR DE MONEDAS ---");
            Console.WriteLine("1. Córdobas a Dólares");
            Console.WriteLine("2. Dólares a Córdobas");
            Console.WriteLine("3. Córdobas a Euros");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ConvertirCordobasADolares();
                    break;
                case "2":
                    ConvertirDolaresACordobas();
                    break;
                case "3":
                    ConvertirCordobasAEuros();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    
    static void ConvertirCordobasADolares()
    {
        Console.Write("Ingrese cantidad en córdobas: ");
        double cordobas = Convert.ToDouble(Console.ReadLine());
        double dolares = cordobas / 36.5; 
        Console.WriteLine($"{cordobas} Córdobas = {dolares:F2} Dólares");
    }

    static void ConvertirDolaresACordobas()
    {
        Console.Write("Ingrese cantidad en dólares: ");
        double dolares = Convert.ToDouble(Console.ReadLine());
        double cordobas = dolares * 36.5;
        Console.WriteLine($"{dolares} Dólares = {cordobas:F2} Córdobas");
    }

    static void ConvertirCordobasAEuros()
    {
        Console.Write("Ingrese cantidad en córdobas: ");
        double cordobas = Convert.ToDouble(Console.ReadLine());
        double euros = cordobas / 40.0; 
        Console.WriteLine($"{cordobas} Córdobas = {euros:F2} Euros");
    }
}
