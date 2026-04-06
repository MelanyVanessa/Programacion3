using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS_POO
{
    internal class Silmulador_de_Cajero_Automatico
    {
        public abstract class CuentaBancaria
        {
            public string Titular { get; set; }
            public decimal Saldo { get; protected set; }

            public abstract void Retirar(decimal monto);

            public void ConsultarSaldo()
            {
                Console.WriteLine($"Saldo actual de {Titular}: ${Saldo}");
            }

            public void Depositar(decimal monto)
            {
                if (monto > 0)
                {
                    Saldo += monto;
                    Console.WriteLine($"Depositado: ${monto}. Nuevo Saldo: ${Saldo}");
                }
                else
                {
                    Console.WriteLine("Error: El depósito debe ser mayor a 0.");
                }
            }
        }

        public class CuentaAhorros : CuentaBancaria
        {
            public override void Retirar(decimal monto)
            {
                if (Saldo >= monto)
                {
                    Saldo -= monto;
                    Console.WriteLine($"Retirado: ${monto}. Nuevo Saldo: ${Saldo}");
                }
                else
                {
                    Console.WriteLine("Error: Saldo insuficiente en Cuenta de Ahorros.");
                }
            }
        }

        public class CuentaCorriente : CuentaBancaria
        {
            private const decimal SobregiroPermitido = 500;

            public override void Retirar(decimal monto)
            {
                if (Saldo + SobregiroPermitido >= monto)
                {
                    Saldo -= monto;
                    Console.WriteLine($"Retirado: ${monto}. Nuevo Saldo: ${Saldo} (Uso de sobregiro)");
                }
                else
                {
                    Console.WriteLine("Error: Excede el límite de sobregiro.");
                }

            }
        }



        public static void Ejecutar()
        {
            Console.WriteLine("--- SIMULADOR DE CAJERO AUTOMÁTICO ---");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            CuentaBancaria cuenta = new CuentaAhorros { Titular = nombre };

            int opcion;
            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
               
                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        
                        break;
                    case 2:
                        Console.Write("Monto a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        cuenta.Depositar(deposito);
                        
                        break;
                    case 3:
                        Console.Write("Monto a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        cuenta.Retirar(retiro);
                        
                        break;
                }
                
            } while (opcion != 4);
        }


    }
}



