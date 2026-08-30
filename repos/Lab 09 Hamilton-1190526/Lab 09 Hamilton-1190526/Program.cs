 class Program
{
    static int x=0 , y=0 ;
    static void moverHaciaAbajo()
    {
        y--;
    }
    static void moverHaciaDerecha()
    {
        x++;
    }
    static void moverHaciaIzquierda()
    {
        x--;
    }
    static void sembrarPlata()
    {
        string planta = "";
        Console.WriteLine("Ingrese el nombre de la planta que quiere sembrar:");
        planta = Console.ReadLine();
        Console.WriteLine($"La planta {planta} ha sido sembrada en las coordenadas x={x} y={y}");
    }
    static void imprimirCordenadas()
    {
        Console.WriteLine(($"Cordenadas Acutuales: x={x} y={y}"));
    }

    static void moverHaciaArriba()
    {
        y++;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 1: Personaje 2D");
        Console.WriteLine("Programa hecho por Hamilton Cuevas");

        int opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine("Menu: \n 1. Subir \n 2. bajar \n 3. Izquierda \n 4. Derecha \n 5. sembrar planta \n 6. Salir ");
            Console.WriteLine("Ingrese la opcion:");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)

            {
                case 1: 
                    moverHaciaArriba();
                    imprimirCordenadas();
                    break;

                case 2:
                    moverHaciaAbajo();
                    imprimirCordenadas();
                    break ;

                case 3:
                    moverHaciaIzquierda();
                    imprimirCordenadas();
                    break;

                case 4:
                    moverHaciaDerecha();
                    imprimirCordenadas();
                    break;
                case 5:
                    sembrarPlata();
                    break;
              case 6: 
                Console.WriteLine("Adios Gracias por jugar");
                break;
            }
    }
}
}
