using Laboratorio14.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tCentro comercial 'Plazuela Norteña'");
            Console.WriteLine("\t***********************************\n");
            int opcion = Interfaz.MenuPrincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        opcion = Interfaz.MenuPrincipal();
                        break;
                    case 1:
                        opcion = Interfaz.RealizarEncuesta();
                        break;
                    case 2:
                        opcion = Interfaz.MostrarDatosE();
                        break;
                    case 3:
                        opcion = Interfaz.MostrarResultados();
                        break;
                    case 4:
                        opcion = Interfaz.BuscarEdad();
                        break;
                }
            } while (opcion != 5);

            Console.WriteLine("\n ¡Gracias por usar el programa!\n Hecho por: Elías Díaz");
            Console.ReadKey();
        }
    }
}
