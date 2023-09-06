using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio1, precio2, distancia, monto;
            char fruta;
            int cajas;

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\t\t\tTransporte de frutas");
            Console.WriteLine("\t\t\t********************\n");
            Console.WriteLine("Menú: \n");
            Console.WriteLine("Naranja........(N)");
            Console.WriteLine("Fresa..........(F)");
            Console.WriteLine("Mango..........(M)\n");
            Console.Write("Ingrese el tipo de fruta que desea transportar según el código del menú: ");
            fruta = char.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de cajas que transportará: ");
            cajas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la distancia que se recorrerá en kilómetros: ");
            distancia = float.Parse(Console.ReadLine());

            switch (fruta)
            {
                case 'N':
                    precio1 = 2;
                    precio2 = 4;
                    break;
                case 'F':
                    precio1 = 6;
                    precio2 = 9;
                    break;
                case 'M':
                    precio1 = 3;
                    precio2 = 5;
                    break;
                default:
                    Console.WriteLine("Debe ingresar una fruta del menú");
                    Console.ReadKey();
                    return;
            }

            monto = 0;
            if (distancia > 0)
            {
                if (distancia <= 30)
                    monto = cajas * precio1;
                else 
                    monto = cajas * precio2;
            }
            else
                Console.WriteLine("¡Error! Debe ingresar una distancia válida (mayor a cero)");

            Console.WriteLine("El pago por la carga es: S/. " + monto);
            Console.ReadKey();
        }
    }
}
