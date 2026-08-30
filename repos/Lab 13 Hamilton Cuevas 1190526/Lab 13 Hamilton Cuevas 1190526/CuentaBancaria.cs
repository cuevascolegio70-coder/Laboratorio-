using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13_Hamilton_Cuevas_1190526
{
    public class CuentaBancaria
    {
        private string titular="";
        private double saldo=0;

        public CuentaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void depositar(double cantidadDeposit)
        {
            if (cantidadDeposit > 0)
            {
                saldo+=cantidadDeposit;
                Console.WriteLine($"la cantidad depositada es: {cantidadDeposit}");
                Console.WriteLine($"Depósito exitoso. su nuevo saldo:{saldo}");
            }
            else
            {
                Console.WriteLine("No se puede depositar una cantidad negativa.");
            }
        }

        public void mostrarInformacion()
        {
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo}");
        }

        public void retirar(double cantidadRetiro)
        {
            if (cantidadRetiro < 0 )
            {
                Console.WriteLine("No se puede retirar una cantidad negativa.");
            }
            else if (cantidadRetiro > saldo)
            {
                Console.WriteLine("No se puede retirar más de lo que tiene en la cuenta.");
            }
            else
            {
                saldo -= cantidadRetiro;
            }


        }
    }
}



