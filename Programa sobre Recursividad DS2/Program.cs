using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Programa_sobre_Recursividad_DS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine("\nIntroduce la subcadena: ");
            string subcadena = Console.ReadLine();

            int resultado = ContarSubsecuencias(cadena, subcadena);
            Console.WriteLine($"\nEl número de subcadenas de '{subcadena}' en '{cadena}' es: {resultado}");
        }

        static int ContarSubsecuencias(string cadena, string subcadena)
        {
            // Caso base: si la subcadena es vacía, entonces es una subcadena de la cadena original
            if (subcadena.Length == 0)
            {
                return 1;
            }

            // Caso base: si la cadena es vacía, entonces no hay subcadenas posibles
            if (cadena.Length == 0)
            {
                return 0;
            }

            // Si la primera letra de la subcadena coincide con la primera letra de la cadena, 
            // hay dos opciones: tomar la letra o no tomarla
            if (char.ToLower(subcadena[0]) == char.ToLower(cadena[0]))
            {
                int tomar = ContarSubsecuencias(cadena.Substring(1), subcadena.Substring(1));
                int noTomar = ContarSubsecuencias(cadena.Substring(1), subcadena);
                return tomar + noTomar;
            }
            // Si las letras no coinciden, se avanza en la cadena
            else
            {
                return ContarSubsecuencias(cadena.Substring(1), subcadena);
            }

        }
    }
}
