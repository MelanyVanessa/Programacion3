using System;

class ReglaFalsa
{
    static void Main()
    {
        Console.Title = "Método de la Regla Falsa - Calculadora de Raíces";

        // Entrada personalizada
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================================================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                                                   ¡Hello, soy Melany!                      ");
        Console.ForegroundColor = ConsoleColor. Cyan;
        Console.WriteLine("========================================================================================================================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Bienvenido a mi programa de cálculo de raíces.");
        Console.WriteLine(" Aquí aprenderás cómo funciona el Método de la Regla Falsa.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================================================================================================");
        Console.ResetColor();

        Console.WriteLine("\nPresiona cualquier tecla para comenzar...");
        Console.ReadKey();
        Console.Clear();

        // Menú de funciones
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Seleccione la función a resolver:");
        Console.WriteLine("1. f(x) = x^2 - 2");
        Console.WriteLine("2. f(x) = x^3 - x - 2");
        Console.WriteLine("3. f(x) = cos(x) - x");
        Console.ResetColor();

        int opcion = int.Parse(Console.ReadLine());

        Func<double, double> f;
        switch (opcion)
        {
            case 1: f = x => Math.Pow(x, 2) - 2; break;
            case 2: f = x => Math.Pow(x, 3) - x - 2; break;
            case 3: f = x => Math.Cos(x) - x; break;
            default: Console.WriteLine("Opción inválida."); return;
        }

        Console.Write("Ingrese el límite inferior a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el límite superior b: ");
        double b = double.Parse(Console.ReadLine());

        // Validar intervalo
        if (f(a) * f(b) > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEl intervalo no es válido porque f(a) y f(b) tienen el mismo signo.");
            Console.ResetColor();
            return;
        }

        Console.Write("Ingrese la tolerancia (o Enter para no usar tolerancia): ");
        string inputTol = Console.ReadLine();
        bool usarTolerancia = !string.IsNullOrWhiteSpace(inputTol);
        double tolerancia = usarTolerancia ? double.Parse(inputTol) : 0.0001; 

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nIniciando cálculo con Regla Falsa...\n");
        Console.ResetColor();

        Console.WriteLine("Iteración |     a    |     b    |    xr    |   f(xr)  | Condición");
        Console.WriteLine("---------------------------------------------------------------------------");

        int iteracion = 0;
        double xr = a;

        while (true)
        {
            iteracion++;
            double fa = f(a);
            double fb = f(b);

            xr = (a * fb - b * fa) / (fb - fa);
            double fxr = f(xr);
            double producto = fa * fxr;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{iteracion,9} | {a,8:F4} | {b,8:F4} | {xr,8:F4} | {fxr,8:F4} | {(usarTolerancia ? $"Error={Math.Abs(fxr):F4}" : $"f(a)*f(xr)={producto:F4}")}");
            Console.ResetColor();

            // Condición de parada
            if (usarTolerancia)
            {
                if (Math.Abs(fxr) <= tolerancia) break;
            }
            else
            {
                if (Math.Abs(producto) <= 0.0001) break; // detener con precisión fix 4
            }

            // Actualizar intervalo
            if (producto < 0) b = xr;
            else a = xr;

            // Seguridad: evitar bucles infinitos
            if (iteracion > 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSe alcanzó el límite de iteraciones. El método no converge.");
                Console.ResetColor();
                return;
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n************************************************************");
        Console.WriteLine(" Resultado Final:");
        Console.WriteLine($" La raíz aproximada encontrada es: {xr:F4}"); // mostrar con 4 decimales
        Console.WriteLine(" ¡Cálculo completado con éxito!");
        Console.WriteLine("************************************************************");
        Console.ResetColor();
    }
}