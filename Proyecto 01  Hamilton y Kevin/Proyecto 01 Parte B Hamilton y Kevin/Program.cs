using System.Diagnostics;

Console.WriteLine("Equipo de Kevin Ventura 1134726 \n Hamilton Cuevas 1190526");
//Creación de un objeto de la clase Random para generar números aleatorios
Random random = new Random();
//Decalaracion e inicialización de variables principales
int opcion = 1; 
int numerosuerte = random.Next(1, 3);
int total2 = 0;
int total = 0;
int activo = 0;
int activo2 = 0;
int b = 0;
int valor1 = 0;
int valor2 = 0;
int tipo = 0;
string ncliente = "";
int rines = 0;
int numero = 0;
string placa = "";
int carros = 0;

//Ingreso del nombre del operador
Console.WriteLine("Ingrese el nombre del operador: ");
string noperador = Console.ReadLine();
//Bucle principal del programa, se repetirá hasta que el usuario ingrese la opción 5 para salir
while (opcion != 5)
{   //Si no hay un carro activo, se muestra el menú de opciones y se solicita al usuario que ingrese su opción
    if (b == 0)
    {   //Menú de opciones para el usuario
        Console.WriteLine("Menú de opciones \n1: Crear ticket de entrada \n2: Lavado de llantas y rines \n3: Consultar monto a cobrar \n4: Registrar salida y calcular cobro \n5: Salir del programa");
        Console.WriteLine("Ingrese su opción");
        opcion = int.Parse(Console.ReadLine());
    }//casos para cada opción del menú, se ejecutará el bloque de código correspondiente a la opción ingresada por el usuario
    switch (opcion)
    {   /*caso 1 para crear un ticket de entrada, se solicita al usuario que ingrese la placa del carro, el tipo de vehículo y el nombre del cliente,  
        se valida que la placa tenga 6 caracteres y no contenga espacios, y que el tipo de vehículo* sea 1 o 2, 
        si todo es correcto se activa el ticket y se incrementa el contador de carros atendidos*/
        case 1:
            if (activo == 0)//si no hay un carro activo, se permite iniciar el proceso de creación del ticket de entrada
            {
                b = 0;
                int i1 = 0;
                int i2 = 0;

                Console.WriteLine("Ingrese la placa del carro: ");
                placa = Console.ReadLine();
                while (i1 != 1)
                {   //validacion de la placa conntenga 6 caracteres y que no tenga espacios, si no cumple con estas condiciones se solicita al usuario que ingrese la placa nuevamente
                    if (placa.Length != 6 || placa.Contains(" "))
                    {
                        Console.WriteLine($"Ingrese la placa del carro, deben de ser 6 carácteres y no puede tener espacios:");
                        placa = Console.ReadLine();
                    }
                    else //si la placa es válida, se activa el proceso para ingresar el tipo de vehículo 
                    {   //bucle que valida que el tipo de vehículo sea 1 o 2, e ingresar los datos que se soliciten  
                        while (i2 != 1) 
                        {
                            i1 = 1; //seleccion del tipico de vehículo, 1 para Sedan y 2 para Pickup o SUV, si el usuario ingresa un número diferente se solicita que ingrese nuevamente el tipo de vehículo
                            Console.WriteLine("Ingrese el tipo de vehículo, 1 = Sedan; 2 = Pickup o SUV: ");
                            tipo = int.Parse(Console.ReadLine());
                            //bucle que se activa para ingresar los datos del tipo de vehículo seleccionado 
                            while (i2 != 1)
                            {   /*si el tipo de vehiculo es 1, se le asigna valor de 50 a valor1, que en este caso es el costo del servicio basico,
                                 ingresa el nombre del cliente*/
                                if (tipo == 1)
                                {

                                    i2 = 1;
                                    valor1 = 50;
                                    Console.WriteLine("Ingrese el nombre del cliente: ");
                                    ncliente = Console.ReadLine();
                                } /*si el tipo de vehículo es 2 se le asigna el valor de 75 a valor1 el cual sigue siendo el monto del servicio basico
                                   pregunta el nombre del cliente*/
                                else if (tipo == 2)
                                {
                                    i2 = 1;
                                    valor1 = 75;
                                    Console.WriteLine("Ingrese el nombre del cliente: ");
                                    ncliente = Console.ReadLine();
                                }

                                else /* si no se puede validar loas dos condicionales anteriores se le vuelve a preguntar en bucle hasta que ingrese un tipo 
                                      de vehículo valido*/
                                {
                                    Console.WriteLine("Ingrese el tipo de vehículo, 1 = Sedan; 2 = Pickup o SUV, tiene que ser 1 o 2: ");
                                    tipo = int.Parse(Console.ReadLine());
                                }

                            }

                        }
                    }
                }//si todo el proceso de validación e ingreso de datos es correcto, se activa el ticket y se incrementa el contador de carros atendidos
                activo = 1;
                carros++;
            }

            else //si ya hay un carro activo, se muestra un mensaje indicando que no se puede ingresar otro carro hasta que el actual salga
            {
                Console.WriteLine("No puede ingresar otro carro, porque ya hay uno activo");
            }

            break;
        case 2:/* caso 2 en el que se pregunta si quiere un servicio extra */
            int i = 0;
            int i3 = 0;
            if (activo2 == 0) /*si no hay un servicio extra activo, se pregunta al usuario si desea agregar el servicio de lavado de llantas y rines, si el usuario responde que si, 
                               se activa el proceso para ingresar el tamaño de los rines y calcular el costo del servicio extra, 
                               si el usuario responde que no, se muestra un mensaje indicando que se ingresarán los datos del carro*/
            {
                if (activo == 1)//si hay un carro activo, se puede proseguir con el servicio extra, si no hay un carro activo, se muestra un mensaje indicando que se ingresarán los datos del carro
                {
                    b = 0;
                    Console.WriteLine("Ingrese el tamaño de los rines, de 12 a 22: ");
                    rines = int.Parse(Console.ReadLine());
                    while (i != 1)
                    {
                        if (rines >= 12 && rines <= 16)//validacion del tamaño de los rines y recargo del servicio extra en el rango de 12 a 16
                        {
                            valor2 = 30;
                            i = 1;
                            activo2 = 1;

                        }
                        else if (rines >= 17 && rines <= 19)//validacion del tamaño de los rines y recargo del servicio extra pero en el rango de 17 a 19
                        {
                            valor2 = 40;
                            i = 1;
                            activo2 = 1;

                        }
                        else if (rines >= 20 && rines <= 22)//validacion del tamaño de los rines y recargo del servicio extra pero en el rango de 20 a 22
                        {
                            valor2 = 60;
                            i = 1;
                            activo2 = 1;

                        }

                        else//si el tamaño de los rines no se encuentra en ninguno de los rangos anteriores, se muestra un mensaje indicando que se debe ingresar un tamaño correcto de los rines y se solicita nuevamente el tamaño de los rines
                        {
                            Console.WriteLine("Ingrese el tamaño correcto de los rines, de 12 a 22: ");
                            rines = int.Parse(Console.ReadLine());
                        }

                    }
                }
                else//si no hay un carro activo, se solicitan los datos de un nuevo carro para poder agregar el servicio extra, se muestra un mensaje indicando que se ingresarán los datos del carro
                {
                    Console.WriteLine("Ingrese los datos del carro");
                    b = 1;
                    opcion = 1;
                }
            }
            else //si ya hay un servicio extra activo, se pregunta al usuario si desea cancelar el servicio extra y volver a ingresar el tamaño de los rines, si el usuario responde que si, se cancela el servicio extra y se reinician las variables relacionadas con el servicio extra, si el usuario responde que no, se muestra un mensaje indicando que el servicio extra no ha sido cancelado
            {
                Console.WriteLine("Quiere cancelar su servicio extra y volver a ingresar el tamaño de los rines, Si/No");
                string a = Console.ReadLine();
                if (a == "Si" || a == "si")
                {
                    Console.WriteLine("Su servicio extra ha sido cancelado");
                    valor2 = 0;
                    activo2 = 0;
                }
                else//se muestra que el servicio no fue cancelado y se mantiene el servicio extra que está activo
                {
                    Console.WriteLine("Su servicio extra no ha sido cancelado");
                }

            }
            break;


        case 3://muestra el monto acumulado que lleva el cliente hasta el momento
            total = valor1 + valor2;
            Console.WriteLine("El monto a cobrar es de: Q." + total);
            break;
        case 4://imprime el ticket de salida con los datos del cliente si y solo si hay un carro activo imprime el tipo de vehículo, el servicio extra,
               //el monto total a pagar y la promoción para ganar un premio, luego reinicia las variables para permitir ingresar un nuevo carro
            if (activo == 1)
            {
                total = valor1 + valor2;
                total2 += total;
                if (tipo == 1)//datos que el programa imprimira si el tipo de vehículo que se seleccionó es del tipo 1
                              //genera un numero aleatorio entre 1 y 3 para la promoción, si el número ingresado por el usuario coincide con el número aleatorio,
                              //se le permite al usuario elegir un premio, si no coincide se muestra un mensaje indicando que en una próxima oportunidad podrá ganar*/
                {
                    Console.WriteLine("Fue atendido por: " + noperador);
                    Console.WriteLine("Cliente: " + ncliente);
                    Console.WriteLine("La placa del carro es: " + placa);
                    Console.WriteLine("El carro es un Sedan:                      Q." + valor1);
                    Console.WriteLine("Servicio extra, Tamaño de rines: " + rines + "        Q." + valor2);
                    Console.WriteLine("El monto total a pagar es de:              Q." + total);
                    Console.WriteLine("Como parte de una promoción, escoja un número del 1 al 3 y mire si es un afortunado");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("El número afortunado es: " + numerosuerte);
                    if (numero == numerosuerte)//si el numero ingresado es igual al numero aleatorio que se generó se le pide al cliente que ingrese el premio que dese
                                               //siempre y cuando lo podamos cumplir*/
                    {
                        Console.WriteLine("Escriba el premio que quiere, siempre y cuando este a nuestra disposición");
                        string premio = Console.ReadLine();
                        Console.WriteLine("Ha ganado " + premio);
                    }
                    else//sino se imprime el mensaje de "En una próxima ganará" y se reinician las variables para permitir ingresar un nuevo carro
                    {
                        Console.WriteLine("En una próxima ganará");
                    }
                    activo = 0;
                    activo2 = 0;
                    tipo = 0;
                    ncliente = "";
                    placa = "";
                    valor1 = 0;
                    valor2 = 0;
                    rines = 0;
                    total = 0;
                }
                if (tipo == 2)//imprime los datos que el programa imprimira si el tipo de vehículo que se seleccionó es del tipo 2
                              //genera un numero aleatorio entre 1 y 3 para la promoción, si el número ingresado por el usuario coincide con el número aleatorio,
                              //se le permite al usuario elegir un premio, si no coincide se muestra un mensaje indicando que en una próxima oportunidad podrá ganar*/
                {
                    Console.WriteLine("Fue atendido por: " + noperador);
                    Console.WriteLine("Cliente: " + ncliente);
                    Console.WriteLine("La placa del carro es: " + placa);
                    Console.WriteLine("El carro es un Pickup o SUV:                   Q." + valor1);
                    Console.WriteLine("Servicio extra, Tamaño de rines: " + rines + "            Q." + valor2);
                    Console.WriteLine("El monto total a pagar es de:                  Q." + total);
                    Console.WriteLine("Como parte de una promoción, escoja un número del 1 al 3 y mire si es un afortunado");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("El número afortunado es: " + numerosuerte);
                    if (numero == numerosuerte)
                    {
                        Console.WriteLine("Escriba el premio que quiere, siempre y cuando este a nuestra disposición");
                        string premio = Console.ReadLine();
                        Console.WriteLine("Ha ganado: " + premio);
                    }
                    else
                    {
                        Console.WriteLine("En una próxima ganará");
                    }
                    activo = 0;
                    activo2 = 0;
                    tipo = 0;
                    ncliente = "";
                    placa = "";
                    valor1 = 0;
                    valor2 = 0;
                    rines = 0;
                    total = 0;
                }
            }
            else //si no hay un carro activo, se muestra un mensaje indicando que no hay un vehículo actual y se reinicia el proceso para ingresar un nuevo carro
            {
                Console.WriteLine("No hay vehículo actual");
            }
            break;
        case 5://imprime un mensaje de despedida y muestra la cantidad de carros atendidos y el total de ingresos adquiridos antes de salir del programa
            Console.WriteLine("La cantidad de carros atendidos fue de: " + carros);
            Console.WriteLine("La cantidad total de ingresos adquiridos fue de: " + total2);
            break;
    }
}