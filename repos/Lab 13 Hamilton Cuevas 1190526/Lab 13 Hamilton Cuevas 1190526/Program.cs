namespace Lab_13_Hamilton_Cuevas_1190526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newTitular = "";
            double saldoinicial = 0;
            Console.WriteLine("Laboratorio de POO}");
            Console.WriteLine("Hecho por hamilton Cuevas 1190526");
            Console.WriteLine("Cree su cuenta vancario, ingrese el nombre del tirular");
            newTitular = Console.ReadLine();
            newTitular = newTitular.Trim();
            Console.WriteLine("Ingrese el saldo inicial de su cuenta bancaria");
            saldoinicial = double.Parse(Console.ReadLine());
            CuentaBancaria cuenta = new CuentaBancaria($"{newTitular} ", saldoinicial);

            cuenta.depositar(200);
            cuenta.retirar(50);
            cuenta.mostrarInformacion();
            

            Termostato termostato = new Termostato("villa Nueva", 25);


            termostato.mostrarInformacion();
            termostato.ajustarTemperatura(30);
            termostato.mostrarInformacion();
            

        }
    }
}
