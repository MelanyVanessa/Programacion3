using System;

class ReglaFalsa
{
    static void Main(string[] args)
    {
        Console.Title = "Método de la Regla Falsa - Calculadora de Raíces";

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Seleccione la función a resolver:");
        Console.WriteLine("1. f(x) = x^2 - 2");
        Console.WriteLine("2. f(x) = x^3 - x - 2");
        Console.WriteLine("3. f(x) = cos(x) - x");
        Console.WriteLine("4. f(x) = e^x - 3x");
        Console.WriteLine("5. f(x) = ln(x) + x^2 - 4");
        Console.WriteLine("6. f(x) = sin(x) - 0.5");
        Console.WriteLine("7. f(x) = x^3 - 7x + 6");
        Console.WriteLine("8. f(x) = e^(3x) - 4");
        Console.WriteLine("9. f(x) = 4x^4 - 9x^2 + 1");
        Console.ResetColor();

        int opcion = int.Parse(Console.ReadLine());

        Func<double, double> f;
        switch (opcion)
        {
            case 1: f = x => Math.Pow(x, 2) - 2; break;
            case 2: f = x => Math.Pow(x, 3) - x - 2; break;
            case 3: f = x => Math.Cos(x) - x; break;
            case 4: f = x => Math.Exp(x) - 3 * x; break;
            case 5: f = x => Math.Log(x) + Math.Pow(x, 2) - 4; break;
            case 6: f = x => Math.Sin(x) - 0.5; break;
            case 7: f = x => Math.Pow(x, 3) - 7 * x + 6; break;
            case 8: f = x => Math.Exp(3 * x) - 4; break;
            case 9: f = x => 4 * Math.Pow(x, 4) - 9 * Math.Pow(x, 2) + 1; break;
            default: Console.WriteLine("Opción inválida."); return;
        }

        Console.Write("Ingrese el límite inferior a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el límite superior b: ");
        double b = double.Parse(Console.ReadLine());

        if (f(a) * f(b) > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nEl intervalo no es válido porque f(a) y f(b) tienen el mismo signo.");
            Console.ResetColor();
            return;
        }

        Console.Write("Ingrese la tolerancia: ");
        double tolerancia = double.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nIniciando cálculo con Regla Falsa...\n");
        Console.ResetColor();

        Console.WriteLine("Iteración |     a    |     b    |   f(a)   |   f(b)   |    xi    |   f(xi)  | f(a)*f(xi)  |  Error %");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

        int iteracion = 0;
        double xi = a;
        double xiAnterior = a;
        double errorPorcentaje = 100;

        while (errorPorcentaje > tolerancia)
        {
            iteracion++;
            double fa = f(a);
            double fb = f(b);

            xi = (a * fb - b * fa) / (fb - fa);
            double fxi = f(xi);
            double producto = fa * fxi;

            errorPorcentaje = iteracion == 1 ? 100 : Math.Abs((xi - xiAnterior) / xi) * 100;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{iteracion,9} | {a,8:F4} | {b,8:F4} | {fa,8:F4} | {fb,8:F4} | {xi,8:F4} | {fxi,8:F4} | {producto,11:F4} | {errorPorcentaje,8:F4}%");
            Console.ResetColor();

            if (producto < 0) b = xi;
            else a = xi;

            xiAnterior = xi;

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
        Console.WriteLine($" La raíz aproximada encontrada es: {xi:F6}");
        Console.WriteLine(" ¡Cálculo completado con éxito!");
        Console.WriteLine("************************************************************");
        Console.ResetColor();
    }
}
