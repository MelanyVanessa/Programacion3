using System;


namespace MiCasa
{
    internal class Program
    {
        int Capital = new int();
        int InteresC = new int();
        int TotalCuota = new int();
        static void Main(string[] args)
        {
            Program Ejecutar = new Program();

            Ejecutar.IngresoDatos();



        }

        public void IngresoDatos()
        {
            Console.WriteLine("Bienvenido a Credito De Vivienda Mi Casa");

            Console.WriteLine("Por favor ingrese el valor de la vivienda:  ");
            int valor = new int();

            Console.WriteLine("Por favor ingrese la tasa de interes mensual en decimales:  ");
            int InteresM = new int();

            Console.WriteLine("por favor ingrese el plazo en meses");
            int Plazo = new int();


            for (int i = 0; i < Plazo; i++ )
            {
                if (Plazo > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("No se puede hacer el calculo");

                }

                InteresC = Capital * InteresM;


                TotalCuota = Capital + InteresM;



            }
        }

        public void SalidaDatos()
        {
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("Mes: ");
            Console.WriteLine("Capital:  " + Capital + "es el capital mensual para la casa");
            Console.WriteLine("Interes Mensual:  " + InteresC + "es el interes en la cuota mensual");
            Console.WriteLine("Total: " + TotalCuota + "total a pagar este mes");
            Console.WriteLine("_____________________________________________________________________");
        }


    }
}
