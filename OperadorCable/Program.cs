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

            for (int j = 1; j < cantOperadores + 1; j++)
            {
                coladeOrdenes.Enqueue(j);
            }


        }
        static int ValidarNumero(int min, int max, string msj)
        {
            //Validar que el número esté dentro de los parámetros solicitados
            int res;

            do
            {

                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine($"\nCantidad mínima de operadores: {min} \nCantidad máxima de operadores: {max}");

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
