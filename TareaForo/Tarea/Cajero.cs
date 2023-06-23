using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Cajero
    {
        private string titular;
        private decimal saldo;
        public Cajero( string titular)
        {
            Console.WriteLine("Bienvenido al cajero automático");
            this.titular = titular;
            saldo = 0;

            bool salir = false;

            do
            {
                Console.WriteLine("\n¿Qué acción desea realizar?");
                Console.WriteLine("1. Depósito");
                Console.WriteLine("2. Retiro");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el monto a depositar: ");
                        decimal montoDeposito = decimal.Parse(Console.ReadLine());
                        Depositar(montoDeposito);
                        Console.WriteLine("Depósito realizado con éxito.");
                        break;
                    case 2:
                        Console.Write("Ingrese el monto a retirar: ");
                        decimal montoRetiro = decimal.Parse(Console.ReadLine());
                        Retirar(montoRetiro);
                        Console.WriteLine("Retiro realizado con éxito.");
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (!salir);
            Console.WriteLine("Gracias por utilizar el cajero automático. ¡Hasta luego!");
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Titular: {titular}, Saldo: {saldo}");
        }
        public string Titular 
        { 
            get {  return titular; } 
            set { titular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Depositar( decimal monto ) 
        {
            saldo += monto;
        }

        public virtual void Retirar( decimal monto )
        { 
            saldo -= monto; 
        }
    }

    public class CuentaCorriente : Cajero
    {
        private decimal lineaCredito;
        public CuentaCorriente(string titular, decimal lineaCredito) : base(titular) 
        {
            this.lineaCredito = lineaCredito;
        }

        public decimal LineaCredito 
        {
            get { return lineaCredito; }
            set { lineaCredito = value; }
        }

        public override void Retirar(decimal monto)
        {
            if (monto <= Saldo + lineaCredito)
            {
                Saldo -= monto;
            }
            else
            {
                Console.WriteLine("No se puede retirar el monto especifico");
            }
        }
    }

}
