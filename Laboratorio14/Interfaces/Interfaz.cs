using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio14.Interfaces
{
    public class Interfaz
    {
        public static int[] Edades = new int[1001];
        public static string[] Vacunacion = new string[1001];
        public static int contador = 0;
        public static int MenuPrincipal()
        {
            Operaciones.Encabezado(" Encuesta Covid-19");
            Console.WriteLine(" 1: Realizar Encuesta\n " +
                "2: Mostrar Datos de la encuesta\n " +
                "3: Mostrar Resultados\n " +
                "4: Buscar Personas por edad\n " +
                "5: Salir ");
            Operaciones.Espaciado();
            return Operaciones.getEntero(" Ingrese una opción: ");
        }
        public static int RealizarEncuesta()
        {
            if (contador == Edades.Length)
            {
                Console.WriteLine(" Lo sentimos, el espacio en la memoria se encuentra llena. Reinicie el programa para volverlo a usar");
            }
            else
            {
                Operaciones.Encabezado(" Encuesta de Vacunación");
                Edades[contador] = Operaciones.getEntero(" ¿Qué edad tienes?: ");
                Console.WriteLine(" ¿Te has vacunado?\n " +
                    "1: Sí\n " +
                    "2: No");
                Operaciones.Espaciado();
                int opcion = Operaciones.getEntero(" Ingrese una opción: ");
                if (opcion == 1 || opcion == 2)
                {
                    if (opcion == 1)
                    {
                        Vacunacion[contador] = "Sí";
                        contador++;
                    }
                    else
                    {
                        Vacunacion[contador] = "No";
                        contador++;
                    }

                    Console.Clear();
                    Operaciones.Encabezado(" Encuesta de Vacunación");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ¡Gracias por participar!\n");
                    Operaciones.Espaciado();
                    Console.Write(" Presione una tecla...");
                }
                else
                {
                    Console.WriteLine(" ¡Error! Debe colocar una alternativa válida");
                    Console.ReadKey();
                    return 0;
                }
            }
            Console.ReadKey();
            return 0;
        }
        public static int MostrarDatosE()
        {
            Operaciones.Encabezado(" Datos de la Encuesta");
            Console.WriteLine(" ");
            Console.WriteLine(" ID    | Edad | Vacunado");
            Console.WriteLine(" =======================");
            for (int i = 0; i < contador; i++)
            {
                if (i >= 0 && i < 10) Console.WriteLine($" 000{i}  |  {Edades[i]}  |   {Vacunacion[i]}");
                if (i >= 10 && i < 100) Console.WriteLine($" 00{i}  |  {Edades[i]}  |   {Vacunacion[i]}");
                if (i >= 100 && i < 1000) Console.WriteLine($" 0{i}  |  {Edades[i]}  |   {Vacunacion[i]}");
                if (i == 1000) Console.WriteLine($" {i}  |  {Edades[i]}  |   {Vacunacion[i]}");
            }
            Console.WriteLine(" ");
            Operaciones.Espaciado();
            Console.Write(" Presione una tecla para regresar...");
            Console.ReadKey();
            return 0;
        }
        public static int MostrarResultados()
        {
            int vacunados = 0, noVacunados = 0, a = 0, b = 0, c = 0, d = 0, e = 0, f = 0;
            Operaciones.Encabezado(" Resultados de la Encuesta");
            Console.WriteLine(" ");
            for (int i = 0; i < contador; i++)
            {
                if (Vacunacion[i] == "Sí") vacunados++;
                if (Vacunacion[i] == "No") noVacunados++;
                if ((Edades[i] >= 1) && (Edades[i] <= 20)) a++;
                if ((Edades[i] >= 21) && (Edades[i] <= 30)) b++;
                if ((Edades[i] >= 31) && (Edades[i] <= 40)) c++;
                if ((Edades[i] >= 41) && (Edades[i] <= 50)) d++;
                if ((Edades[i] >= 51) && (Edades[i] <= 60)) e++;
                if (Edades[i] >= 61) f++;
            }
            if (vacunados >= 0 && vacunados < 10) { Console.WriteLine($" 0{vacunados} personas se han vacunado"); }
            else { Console.WriteLine($" {vacunados} personas se han vacunado"); }

            if (noVacunados >= 0 && noVacunados < 10) { Console.WriteLine($" 0{noVacunados} personas no se han vacunado\n"); }
            else { Console.WriteLine($" {noVacunados} personas no se han vacunado\n"); }

            if (a >= 0 && a < 10) { Console.WriteLine($" Existen:\n 0{a} personas entre 01 y 20 años"); }
            else { Console.WriteLine($" Existen:\n {a} personas entre 01 y 20 años"); }
            if (b >= 0 && b < 10) { Console.WriteLine($" 0{b} personas entre 21 y 30 años"); }
            else { Console.WriteLine($" {b} personas entre 21 y 30 años"); }
            if (c >= 0 && c < 10) { Console.WriteLine($" 0{c} personas entre 31 y 40 años"); }
            else { Console.WriteLine($" {c} personas entre 31 y 40 años"); }
            if (d >= 0 && d < 10) { Console.WriteLine($" 0{d} personas entre 41 y 50 años"); }
            else { Console.WriteLine($" {d} personas entre 41 y 50 años"); }
            if (e >= 0 && e < 10) { Console.WriteLine($" 0{e} personas entre 51 y 60 años"); }
            else { Console.WriteLine($" {e} personas entre 51 y 60 años"); }
            if (f >= 0 && f < 10) { Console.WriteLine($" 0{f} personas de 61 años a más\n "); }
            else { Console.WriteLine($" {f} personas de 61 años a más\n ");}

            Operaciones.Espaciado();
            Console.Write(" Presione una tecla para regresar...");
            Console.ReadKey();
            return 0;
        }
        public static int BuscarEdad()
        {
            int vacunaron = 0, noVacunaron = 0, existe = 0;
            Operaciones.Encabezado(" Busca a Personas por Edad");
            int edadBuscar = Operaciones.getEntero(" ¿Qué edad quieres buscar?: ");
            Console.WriteLine(" ");
            for (int i = 0; i < contador; i++)
            {
                if (Edades[i] == edadBuscar)
                {
                    if (Vacunacion[i] == "Sí") vacunaron++;
                    if (Vacunacion[i] == "No") noVacunaron++;
                    existe++;
                }
            }
            if (existe == 0)
            {
                Console.WriteLine(" ¡La edad no existe en el arreglo! Coloque otra\n edad, por favor\n");
            }
            else
            {
                if (vacunaron >= 0 && vacunaron < 10) { Console.WriteLine($" 0{vacunaron} se vacunaron"); }
                else { Console.WriteLine($" {vacunaron} se vacunaron"); }

                if (noVacunaron >= 0 && noVacunaron < 10) { Console.WriteLine($" 0{noVacunaron} no se vacunaron\n"); }
                else { Console.WriteLine($" {noVacunaron} no se vacunaro\n"); }
            }
            Operaciones.Espaciado();
            Console.Write(" Presione una tecla para regresar...");
            Console.ReadKey();
            return 0;
        }
    }
}
