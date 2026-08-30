using System.Timers;

class Program
{
    static double CalcularAreaCirculo(double radio)
    {
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        return areaCirculo;
    }

    static double CalcularAreaCuadrado(double lado)
    {
        double areaCuadrado = Math.Pow(lado, 2);
        return areaCuadrado;
    }

    static double CalcularAreaRectangulo(double Base, double Altura)
    {
        double areaRectangulo = Base * Altura;
        return areaRectangulo;
    }

    static double CalcularAreaTriangulo(double Base, double Altura)
    {
        double areaTriengulo = (Base * Altura) / 2;
        return areaTriengulo;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hecho por: Hamilton Cuevas \n Carnet: 1190526 \n Laboratorio 10 \n Ejercicio Figuras Geometricas");


        //Menú

        int opcion = 0;

        while (opcion != 5)
        {
           Console.WriteLine("Seleccione una figura geométrica de la cual quiere calcular el area \n 1. Circulo \n 2. Cuadradro \n 3. Rectangulo \n 4. Triangulo \n 5. Salir");
             opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Ingrese el radio del circulo: ");
                        double radio = double.Parse(Console.ReadLine());
                        double areaCirculo = CalcularAreaCirculo(radio);
                        Console.WriteLine($"El area del circulo es: {areaCirculo}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ingrese el tamaño de un lado del cuadrado: ");
                        double lado = double.Parse(Console.ReadLine());
                        Console.WriteLine($"El area del cuadrado es: {CalcularAreaCuadrado(lado)}");
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Ingrese el tamaño de la base del rectangulo: ");
                        double BaseRectangulo = double.Parse((Console.ReadLine()));
                        Console.WriteLine("Ingrese el tamaño de la altura del rectangulo: ");
                        double AlturaRectangulo = double.Parse((Console.ReadLine()));
                        Console.WriteLine($"El area del rectangulo es: {CalcularAreaRectangulo(BaseRectangulo, AlturaRectangulo)}");
                        break;

                    }
                case 4:
                    {
                        Console.WriteLine("Ingrese La base del triengulo:");
                        double BaseTriengulo = double.Parse((Console.ReadLine()));
                        Console.WriteLine("Ingrese la altura del triengulo:");
                        double AlturaTriengulo = double.Parse((Console.ReadLine()));
                        double areaTriengulo = CalcularAreaTriangulo(BaseTriengulo, AlturaTriengulo);
                        Console.WriteLine($"El area del triengulo es: {areaTriengulo}");
                        break;

                    }
                case 5:
                    {
                        Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                        break;
                    }

            }   


        }

    }

}




