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
            //Ingreso operadores

            Console.WriteLine("Ingrese cantidad de operadores: ");
            string ingreso = Console.ReadLine(); 
            int cantOperadores;

            bool ok = int.TryParse(ingreso, out cantOperadores);

            do
            {
                Console.WriteLine("Por favor ingrese un número: ");
                ingreso = Console.ReadLine();
                ok = int.TryParse(ingreso, out cantOperadores);
            } while (!ok);

            do
            {
                Console.WriteLine("Debe ingresar un numero positivo: ");
                ingreso = Console.ReadLine();
                ok = int.TryParse(ingreso, out cantOperadores);
            } while (cantOperadores <= 0);

            //Ingreso ordenes de trabajo

            Console.WriteLine("Ingrese cantidad de órdenes de trabajo: ");
            string ingreso2 = Console.ReadLine();
            int cantOrdenes;

            ok = int.TryParse(ingreso2, out cantOrdenes);

            do
            {
                Console.WriteLine("Por favor ingrese un número: ");
                ingreso2 = Console.ReadLine();
                ok = int.TryParse(ingreso2, out cantOrdenes);
            } while (!ok);

            do
            {
                Console.WriteLine("Debe ingresar un numero positivo: ");
                ingreso2 = Console.ReadLine();
                ok = int.TryParse(ingreso2, out cantOrdenes);
            } while (cantOrdenes <= 0);

            





        }
    }
    
}
