namespace Proyecto_2_Parte_B_Hamilton_Cuevas_1190526
{
    internal class Program
    {
        //asiganacion e inicializacion de variables globales 
        public double dinero = 0;
        public double sueldoEmpleados = 0;
        public double totalIngresos = 0;
        public double totalEgresos = 0;

        public int numEmpleados = 0;
        public int mesesRenta = 0;
        public int mesesSimulados = 0;
        public int contMaizsembrado = 0;
        public int contZanahoriasembrada = 0;
        public int contLechugasembrada = 0;
        public int contMaizcosechado = 0;
        public int contZanahoriacosechada = 0;
        public int contLechugacosechada = 0;

        bool usoDeFertilizante = false;
        public int filas, columnas;
        // creacion de la matriz principal 
        public Parcela[,] parcela;


        // creacion de procedimiento para mostar la parcela en en la consola
        void MostrarParcela()
        {
            // el console clear es para limpiar la terminal cada que se inicia o se llama este procemiento
            Console.Clear();
            //bucles anidados que leen las fila y las columnas de la matriz para mostrar el estado de cada parcela
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{parcela[i, j].estado} ");
                }
                //console Write lina para dejar un espacio entre la impresion de las parcelas 
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //procedimiento en el que se debe asiganr los balores inciales para poder iniciar la simulacion
        void configuracionInicial()
        {   //bucle en el que se declarara todos los valores de las variables que son indispensables para la simualacion 

            //dinero y mientras este no sea mayor a 0 no podremos avanzar 
            while (dinero <= 0)
            {
                Console.WriteLine("Ingrese el dinero inicial: ");
                dinero = double.Parse(Console.ReadLine());
                if (dinero <= 0)
                Console.WriteLine("El dinero inicial debe ser mayor a 0, ingrese un valor valido: ");
            }

            //numero de empleados mientras este no sea mayor a 0 no podremos avanzar 
            while (numEmpleados <= 0)
            {
                Console.WriteLine("Ingrese el numero de empleados que se contrataran: ");
                numEmpleados = int.Parse(Console.ReadLine());
                if (numEmpleados <= 0)
                    Console.WriteLine("El numero de empleados debe ser mayor a 0, ingrese un valor valido: ");
            }

            //declaramos el sueldo de los empleados, si no es mayort a 0 no podremos avanzar
            while (sueldoEmpleados <= 0)
            {
                Console.WriteLine("Ingrese sueldo por empleado: ");
                sueldoEmpleados = double.Parse(Console.ReadLine());
                if (sueldoEmpleados <= 0)
                    Console.WriteLine("El sueldo por empleado debe ser mayor a 0, ingrese un valor valido: ");
            }

            //numero de meses simulados, aca debemos declara el numero de meses que se vana a simular, si el numero de meses es menora 0 no podremos avanzar 
            while (mesesSimulados <= 0)
            {
                Console.WriteLine("Ingrese cuantos meses quiere simular: ");
                mesesSimulados = int.Parse(Console.ReadLine());
                if (mesesSimulados <= 0)
                    Console.WriteLine("El numero de meses a simular debe ser mayor a 0, ingrese un valor valido: ");
            }

            //declaracion de las filas de la matriz que contendra las parcelas, si el numero de filas es menor 0 no podremos avanzar
            while (filas <= 0)
            {
                Console.WriteLine("Ingrese el numero de filas para la parcela: ");
                filas = int.Parse(Console.ReadLine());
                if (filas <= 0)
                    Console.WriteLine("El numero de filas debe ser mayor a 0, ingrese un valor valido: ");
            }

            //declaracion de las columnas de la matriz pirncipal, si el numero de columnas es menor a 0 no pordremos avanzar 
            while (columnas <= 0)
            {
                Console.WriteLine("Ingrese el numero de columnas para la parcela: ");
                columnas = int.Parse(Console.ReadLine());
                if (columnas <= 0)
                    Console.WriteLine("El numero de columnas debe ser mayor a 0, ingrese un valor valido: ");
            }
            //inicializacion de la matriz principal con el numero de filas y columnas que se declaro anteriormente, ademas se inicializa cada parcela con un estado vacio representado por "|-|"
            parcela = new Parcela[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                {
                    parcela[i, j] = new Parcela(0, 0, 0, 0, false, false, false);
                    parcela[i, j].estado = "|-|";
                }
            //llamamos al procedimiento para mostrar la parcela inicial vacia en la consola

            MostrarParcela();
        }
        //procedimiento para mostrar el reporte final al finalizar la simulacion, en este reporte se mostrara el dinero final, 
        //los ingresos y egresos totales, el numero de meses simulados, el numero de parcelas sembradas y cosechadas de cada tipo de cultivo
        void MostrarReporte()
        {
            Console.WriteLine("\n--- Reporte final ---");
            Console.WriteLine($"Dinero final: Q{dinero}");
            Console.WriteLine($"Total de ingresos: Q{totalIngresos}");
            Console.WriteLine($"Total de egresos: Q{totalEgresos}");
            Console.WriteLine($"Meses simulados: {mesesRenta}");
            Console.WriteLine($"Parcelas de maiz sembradas: {contMaizsembrado}");
            Console.WriteLine($"Parcelas de zanahoria sembradas: {contZanahoriasembrada}");
            Console.WriteLine($"Parcelas de lechuga sembradas: {contLechugasembrada}");
            Console.WriteLine($"Cosechas de maiz realizadas: {contMaizcosechado}");
            Console.WriteLine($"Cosechas de zanahoria realizadas: {contZanahoriacosechada}");
            Console.WriteLine($"Cosechas de lechuga realizadas: {contLechugacosechada}");
            Console.WriteLine("---------------------");
        }
        //procedimiento principal del programa, en este procedimiento se encuentra el menu principal y se llama a los procedimientos 
        //para sembrar, fertilizar, mostrar estado de la parcela, avanzar mes y mostrar el reporte final
        void ProgramaMain()
        {
            int opcion = 0;
            //bucle principal del programa, este bucle se ejecutara mientras el usuario no seleccione la opcion de salir, tenga dinero y no se hayan simulado todos los meses
            while (opcion != 5 && dinero > 0 && mesesRenta < mesesSimulados)
            {
                //cada vez que se inicia el bucle se muestra la parcela actualizada, el dinero disponible, el mes actual y el menu de opciones
                MostrarParcela();
                Console.WriteLine($"Dinero: Q{dinero}  |  Mes: {mesesRenta}/{mesesSimulados}");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Sembrar \n2. Fertilizar \n3. Mostrar estado de la parcela \n4. Avanzar mes \n5. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    //caso 1 para sembrar, en este caso se le pedira al usuario que seleccione el tipo de cultivo, la fila y la columna donde desea sembrar, ademas se validara que la parcela seleccionada no este ocupada
                    case 1:
                        {
                            int tiposiembra = 0;

                            //blucle que valida que se ingrese un tipo de cultivo valido, si el usuario ingresa un numero menor a 1 o mayor a 3 se le pedira que ingrese un valor valido
                            while (tiposiembra < 1 || tiposiembra > 3)
                            {
                                Console.WriteLine("Seleccione el tipo de cultivo a sembrar: \n1. Maíz \n2. Zanahoria \n3. Lechuga");
                                tiposiembra = int.Parse(Console.ReadLine());
                                if (tiposiembra < 1 || tiposiembra > 3)
                                    Console.WriteLine("Tipo de cultivo no válido, ingrese 1, 2 o 3.");
                            }
                            //se le asigna un valor de -1 a la variable fila y columna para poder validar que el usuario ingrese un valor valido
                            //si el usuario ingresa un numero menor a 0 o mayor o igual al numero de filas o columnas se le pedira que ingrese un valor valido
                            int fila = -1;
                            while (fila < 0 || fila >= filas)
                            {
                                Console.WriteLine($"Ingrese la fila donde desea sembrar (0 a {filas - 1}): ");
                                fila = int.Parse(Console.ReadLine());
                                if (fila < 0 || fila >= filas)
                                    Console.WriteLine($"Fila invalida, ingrese un valor entre 0 y {filas - 1}.");
                            }

                            int columna = -1;
                            while (columna < 0 || columna >= columnas)
                            {
                                Console.WriteLine($"Ingrese la columna donde desea sembrar (0 a {columnas - 1}): ");
                                columna = int.Parse(Console.ReadLine());
                                if (columna < 0 || columna >= columnas)
                                    Console.WriteLine($"Columna invalida, ingrese un valor entre 0 y {columnas - 1}.");
                            }
                            //validacion para verificar que la parcela seleccionada no este ocupada, si la parcela esta ocupada se le informara al usuario y se le pedira que presione Enter para continuar
                            if (parcela[fila, columna].estaOcupada)
                            {
                                Console.WriteLine("La parcela seleccionada ya esta ocupada, presione Enter para continuar.");
                                Console.ReadLine();//espera a que el usuario presione Enter para continuar, es una pausa 
                                break;
                            }
                            //dependiendo del tipo de cultivo seleccionado se asignaran los valores correspondientes a la parcela
                            //ademas se actualizara el estado de la parcela y se incrementara el contador de parcelas sembradas para cada tipo de cultivo
                            switch (tiposiembra)
                            {
                                case 1:
                                    parcela[fila, columna] = new Parcela(1, 0, 3, 700, false, false, true);
                                    parcela[fila, columna].estado = "|M|";
                                    contMaizsembrado++;
                                    Console.WriteLine($"Maíz sembrado en la parcela ({fila}, {columna}). Presione Enter para continuar.");
                                    break;
                                case 2:
                                    parcela[fila, columna] = new Parcela(2, 0, 2, 500, false, false, true);
                                    parcela[fila, columna].estado = "|Z|";
                                    contZanahoriasembrada++;
                                    Console.WriteLine($"Zanahoria sembrada en la parcela ({fila}, {columna}). Presione Enter para continuar.");
                                    break;
                                case 3:
                                    parcela[fila, columna] = new Parcela(3, 0, 1, 200, false, false, true);
                                    parcela[fila, columna].estado = "|L|";
                                    contLechugasembrada++;
                                    Console.WriteLine($"Lechuga sembrada en la parcela ({fila}, {columna}). Presione Enter para continuar.");
                                    break;
                            }//despues de sembrar se le informara al usuario que la siembra se realizo con exito y se le pedira que presione Enter para continuar
                            Console.ReadLine();
                            break;
                        }
                    //caso 2 para fertilizar, en este caso se le pedira al usuario que seleccione la fila y la columna de la parcela que desea fertilizar
                    //ademas se validara que el usuario tenga suficiente dinero para comprar fertilizante, que no haya utilizado fertilizante en el mes actual, que la parcela seleccionada tenga un cultivo y que no haya sido fertilizada previamente

                    case 2:
                        {
                            //validacion de dinero, que sea suficiente
                            if (dinero < 50)
                            {
                                Console.WriteLine("No tienes suficiente dinero para comprar fertilizante. Presione Enter para continuar.");
                                Console.ReadLine();
                                break;
                            }

                            //validacion de uso de fertilizante, que no se haya utilizado en el mes actual
                            if (usoDeFertilizante)
                            {
                                Console.WriteLine("Ya has utilizado fertilizante este mes. Presione Enter para continuar.");
                                Console.ReadLine();
                                break;
                            }
                            //validacion de fila y columna, que sean validas y que la parcela seleccionada tenga un cultivo y no haya sido fertilizada previamente
                            int filaFertilizar = -1;
                            while (filaFertilizar < 0 || filaFertilizar >= filas)
                            {
                                Console.WriteLine($"Ingrese la fila de la parcela que desea fertilizar (0 a {filas - 1}): ");
                                filaFertilizar = int.Parse(Console.ReadLine());
                                if (filaFertilizar < 0 || filaFertilizar >= filas)
                                    Console.WriteLine($"Fila invalida, ingrese un valor entre 0 y {filas - 1}.");
                            }

                            int columnaFertilizar = -1;
                            while (columnaFertilizar < 0 || columnaFertilizar >= columnas)
                            {
                                Console.WriteLine($"Ingrese la columna de la parcela que desea fertilizar (0 a {columnas - 1}): ");
                                columnaFertilizar = int.Parse(Console.ReadLine());
                                if (columnaFertilizar < 0 || columnaFertilizar >= columnas)
                                    Console.WriteLine($"Columna invalida, ingrese un valor entre 0 y {columnas - 1}.");
                            }
                            //validacion de parcela, que tenga un cultivo y que no haya sido fertilizada previamente el ! es para indicar que una negacion
                            if (!parcela[filaFertilizar, columnaFertilizar].estaOcupada)
                            {
                                Console.WriteLine("La parcela seleccionada no tiene cultivo. Presione Enter para continuar.");
                                Console.ReadLine();
                                break;
                            }
                            //validacion de fertilizacion previa, que no haya sido fertilizada previamente
                            if (parcela[filaFertilizar, columnaFertilizar].yaFertilizada)
                            {
                                Console.WriteLine("La parcela seleccionada ya ha sido fertilizada. Presione Enter para continuar.");
                                Console.ReadLine();
                                break;
                            }
                            //si se cumplen todas las validaciones anteriores, se procede a fertilizar la parcela seleccionada, se descuenta el dinero por el fertilizante, se actualiza el estado de la parcela y se incrementa el ingreso de la cosecha en un 10%
                            dinero -= 50;
                            totalEgresos += 50;
                            parcela[filaFertilizar, columnaFertilizar].yaFertilizada = true;
                            parcela[filaFertilizar, columnaFertilizar].tieneFertilizante = true;
                            parcela[filaFertilizar, columnaFertilizar].ingresoCosecha += parcela[filaFertilizar, columnaFertilizar].ingresoCosecha * 0.1;
                            Console.WriteLine($"Parcela ({filaFertilizar}, {columnaFertilizar}) fertilizada. Dinero restante: Q{dinero}");
                            //despues de fertilizar la parcela seleccionada, se verifica si las parcelas vecinas a la izquierda y derecha tienen un cultivo, si es asi se fertilizan tambien 
                            //y se incrementa el ingreso de la cosecha en un 10%, si no tienen cultivo o no existen se le informara al usuario
                            if (columnaFertilizar - 1 >= 0)
                            {
                                //validacion de parcela vecina izquierda, que tenga un cultivo para fertilizar
                                if (parcela[filaFertilizar, columnaFertilizar - 1].estaOcupada)
                                {
                                    parcela[filaFertilizar, columnaFertilizar - 1].yaFertilizada = true;
                                    parcela[filaFertilizar, columnaFertilizar - 1].tieneFertilizante = true;
                                    parcela[filaFertilizar, columnaFertilizar - 1].ingresoCosecha += parcela[filaFertilizar, columnaFertilizar - 1].ingresoCosecha * 0.1;
                                    Console.WriteLine($"Parcela vecina izquierda ({filaFertilizar}, {columnaFertilizar - 1}) también fertilizada.");
                                }
                                else
                                    Console.WriteLine("La parcela vecina izquierda no tiene cultivo, no se fertilizará.");
                            }
                            else
                                Console.WriteLine("No hay parcela vecina a la izquierda.");
                            //validacion de parcela vecina derecha, que tenga un cultivo para fertilizar
                            if (columnaFertilizar + 1 < columnas)
                            {
                               
                                if (parcela[filaFertilizar, columnaFertilizar + 1].estaOcupada)
                                {
                                    parcela[filaFertilizar, columnaFertilizar + 1].yaFertilizada = true;
                                    parcela[filaFertilizar, columnaFertilizar + 1].tieneFertilizante = true;
                                    parcela[filaFertilizar, columnaFertilizar + 1].ingresoCosecha += parcela[filaFertilizar, columnaFertilizar + 1].ingresoCosecha * 0.1;
                                    Console.WriteLine($"Parcela vecina derecha ({filaFertilizar}, {columnaFertilizar + 1}) también fertilizada.");
                                }
                                else
                                    Console.WriteLine("La parcela vecina derecha no tiene cultivo, no se fertilizará.");
                            }
                            else
                                Console.WriteLine("No hay parcela vecina a la derecha.");

                            usoDeFertilizante = true;
                            Console.WriteLine("Presione Enter para continuar.");
                            Console.ReadLine();
                            break;
                        }
                    //caso 3 para mostrar el estado de la parcela, en este caso se le pedira al usuario que seleccione la fila y la columna de la parcela que desea consultar
                    //ademas se validara que las coordenadas ingresadas sean validas
                    case 3:
                        {
                            //validacion de fila y columna, que sean validas
                            int filaEstado = -1;
                            while (filaEstado < 0 || filaEstado >= filas)
                            {
                                Console.WriteLine($"Ingrese la fila de la parcela (0 a {filas - 1}): ");
                                filaEstado = int.Parse(Console.ReadLine());
                                if (filaEstado < 0 || filaEstado >= filas)
                                    Console.WriteLine($"Fila invalida, ingrese un valor entre 0 y {filas - 1}.");
                            }

                            int columnaEstado = -1;
                            while (columnaEstado < 0 || columnaEstado >= columnas)
                            {
                                Console.WriteLine($"Ingrese la columna de la parcela (0 a {columnas - 1}): ");
                                columnaEstado = int.Parse(Console.ReadLine());
                                if (columnaEstado < 0 || columnaEstado >= columnas)
                                    Console.WriteLine($"Columna invalida, ingrese un valor entre 0 y {columnas - 1}.");
                            }
                            //despues de validar las coordenadas ingresadas, se muestra el estado de la parcela seleccionada, si la parcela esta vacia se le informara al usuario que no hay cultivo en esa parcela

                            parcela[filaEstado, columnaEstado].MostrarEstado();
                            Console.WriteLine($"Meses restantes para cosechar: {parcela[filaEstado, columnaEstado].mesesParaCrecer - parcela[filaEstado, columnaEstado].edadMeses}");
                            Console.WriteLine("Presione Enter para continuar.");
                            Console.ReadLine();
                            break;
                        }

                        //caso 4, para avanzar un mes en la simulacion
                    case 4:
                        {

                            //al avanzar el mes, se incrementa el contador de meses de renta, se verifica si se ha utilizado fertilizante en el mes actual para resetear su uso, se paga a los empleados y se actualiza el dinero disponible
                            mesesRenta++;
                            usoDeFertilizante = false;
                            //se calcula el pago de los empleados, se descuenta del dinero disponible y se suma a los egresos el pago de los empleados
                            double pagoEmpleados = numEmpleados * sueldoEmpleados;
                            dinero -= pagoEmpleados;
                            totalEgresos += pagoEmpleados;
                            Console.WriteLine($"Se pagaron Q{pagoEmpleados} a los empleados. Dinero restante: Q{dinero}");
                            //bucle anidado para recorrer cda parcela de la matriz para mostrar los datos de las parcelas 
                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    if (parcela[i, j].estaOcupada)
                                    {
                                        parcela[i, j].edadMeses++;
                                        Console.WriteLine($"Parcela ({i}, {j}): la planta creció, tiene {parcela[i, j].edadMeses} mes(es).");

                                        if (parcela[i, j].edadMeses >= parcela[i, j].mesesParaCrecer)
                                        {
                                            dinero += parcela[i, j].ingresoCosecha;
                                            totalIngresos += parcela[i, j].ingresoCosecha;
                                            Console.WriteLine($"Parcela ({i}, {j}): cosecha lista, se obtuvieron Q{parcela[i, j].ingresoCosecha}.");

                                            if (parcela[i, j].tipoSiembra == 1)
                                                contMaizcosechado++;
                                            else if (parcela[i, j].tipoSiembra == 2)
                                                contZanahoriacosechada++;
                                            else if (parcela[i, j].tipoSiembra == 3)
                                                contLechugacosechada++;

                                            parcela[i, j] = new Parcela(0, 0, 0, 0, false, false, false);
                                            parcela[i, j].estado = "|-|";
                                        }
                                    }
                                }
                            }
                            //si el dinero disponilbe es menor o igual a 0 despues de pagar a los empleados la simulacion se termina la simulacion y se muestra el informe final de la simulacion 
                            if (dinero <= 0)
                            {
                                Console.WriteLine("Se ha quedado sin dinero. Fin de la simulacion.");
                                MostrarReporte();
                                Console.ReadLine();
                                opcion = 5;
                                break;
                            }

                            Console.WriteLine("Presione Enter para continuar.");
                            Console.ReadLine();
                            break;
                        }
                    //caso 5 para salir de la simulacion, en este caso se muestra el reporte final de la simulacion y se termina el programa
                    case 5:
                        MostrarReporte();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, seleccione una opcion del 1 al 5. Presione Enter para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
            //si los meses de renta son matores o iguales a los meses simulados y el usuario no selecciono la opcion de salir, se muestra un mensaje indicando que se han completado todos los meses simulados y se muestra el reporte final de la simulacion
            if (mesesRenta >= mesesSimulados && opcion != 5)
            {
                Console.WriteLine("Se han completado todos los meses simulados. Fin de la simulacion.");
                MostrarReporte();
                Console.ReadLine();
            }
        }
        //metodo main del programa, en este metodo se crea una instancia de la clase Program, se llama al procedimiento de configuracion inicial para asignar los valores iniciales y luego se llama al procedimiento principal del programa para iniciar la simulacion
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.configuracionInicial();
            programa.ProgramaMain();
            //se crearon estas insatancias de la clase porque los metodos no eran estaticos y cuando se cambiaban el programa se rompia XDD
        }
    }
}