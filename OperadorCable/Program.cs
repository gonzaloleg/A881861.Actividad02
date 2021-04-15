using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorCable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema de Operadores de Cable. Pulse una tecla para comenzar.");
            Console.ReadKey();
            Console.Clear();

            Dictionary<int, int> listaOperadores = new Dictionary<int, int>();
            
            //Establezco un tope de operadores de acuerdo al tipo de negocio
            int cantOperadores = ValidarNumero(1, 100, "¿Cuántos operadores desea cargar?");

            //Le asigno de manera secuencial un numero de ID a c/ operador
            for (int i = 1; i < cantOperadores +1 ; i++)
            {
                listaOperadores.Add(i,0);
            }

            int cantOrdenes = ValidarNumero(1, 400, "¿Cuántas órdenes de trabajo desea cargar?");

            Queue<int> coladeOrdenes = new Queue<int>();

            //Asigno un numero de ID a cada orden de manera secuencial
            for (int j = 1; j < cantOrdenes + 1; j++)
            {
                coladeOrdenes.Enqueue(j);
            }

            Console.Clear();
            bool continuar = true;

            do
            {
                Console.WriteLine("1 - Asignar una orden a un operador");
                Console.WriteLine("2 - Obtener reporte y finalizar programa");
                Console.WriteLine("\nEn la siguiente pantalla se le será solicitado el número de opción. Presione una tecla para continuar.");
                Console.ReadKey();
                continuar = true;

                int menu = ValidarNumero(1, 2, "Ingrese número de opción deseada:");

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            int seleccion = ValidarNumero(1, cantOperadores, "Ingrese Identificador de operador para asignar la siguiente orden");
                            coladeOrdenes.Dequeue();
                            listaOperadores[seleccion] = +1;
                            Console.Clear();

                            bool continuar2 = true;
                            do
                            {
                                Console.WriteLine("¿Desea volver a asignar una orden a un operador?");
                                Console.WriteLine("1 - SI");
                                Console.WriteLine("2 - NO");
                                int seleccion2 = ValidarNumero(1, 2, "Ingrese opción");

                                if (seleccion2 == 1)
                                {
                                    seleccion = ValidarNumero(1, cantOperadores, "Ingrese Identificador de operador para asignar la siguiente orden");
                                    coladeOrdenes.Dequeue();
                                    listaOperadores[seleccion] = +1;
                                    Console.Clear();

                                    continuar2 = true;
                                }
                                if (seleccion2 == 2)
                                {
                                    continuar2 = false;
                                }
                            } while (continuar2);

                        } while (coladeOrdenes.Count > 0);
                        continuar = true;
                        break;
                        
                }
            } while (continuar);
            


        }
        static int ValidarNumero(int min, int max, string msj)
        {
            //Validar que el número esté dentro de los parámetros solicitados
            int res;

            do
            {

                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine($"\nCantidad mínima: {min} \nCantidad máxima: {max}");

                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("Por favor ingrese un número válido.");
                    res = -1;
                }

            } while (res < min || res > max);

            return res;
        }
    }

    
}
