//Programa hecho por Hamilton Cuevas

using System.Timers;

Console.WriteLine("Programa hecho por Hamilton Cuevas");
Console.WriteLine("Ejercicio 01 ");
float saldo = 0;

Console.WriteLine("Ingrese el saldo inicial: ");
saldo = float.Parse(Console.ReadLine());

//generar un numero de cuanta random

Random random = new Random();
int numeroCuenta = random.Next(10000,99999);

//Impriir menù de opccioones
int opcion = 1;



while (opcion!= 4)
{
    Console.WriteLine("Menú de opciones: \n 1. Consultar saldo \n 2. Deppostiar \n 3. Retirar \n 4. salir \n Ingrese su opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Consultar saldo: {saldo}");
            break;
        case 2:
            Console.WriteLine("Depositar:"); 
            Console.WriteLine("ingrese la cantidad a depositar: ");
            float saldoDeposito = float.Parse(Console.ReadLine());
       

            if (saldoDeposito > 0)
            {
                saldo += saldoDeposito;
                Console.WriteLine($"tu saldo despues del deposito es: {saldo}");
            }
            break;
            case 3: 
                Console.WriteLine("Retirar:");
                Console.WriteLine("ingrese la cantidad a retirar: ");
                float saldoRetirar = float.Parse(Console.ReadLine());
            
                if (saldoRetirar > 0 && saldoRetirar <=saldo)
                {
                    saldo -= saldoRetirar;
                Console.WriteLine($"su saldo restante es de:{saldo}");


                }
                else
                {
                Console.WriteLine("Notiene suficiente saldo para retirar esa cantidad: ");   
                }
                break;
            case 4:
            Console.WriteLine("Gracios por usar el servicio, hasta luego");
                break;
        default: Console.WriteLine("Opcion no valida");
            break; 
    }

}