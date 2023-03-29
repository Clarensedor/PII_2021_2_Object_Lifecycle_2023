//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            //8
            var t1 = new Train("Last Train To London");
            Console.WriteLine(Train.Count);
            var t2 = new Train("Last Train To London");
            Console.WriteLine(Train.Count);
            var t3 = new Train("Runaway Train");
            Console.WriteLine(Train.Count);

            //crea las 100 instancias exitosamente
            for (int i = 0; i < 1000000000; i++)
            {
                //una instancia
                var t = new Train("Last Train To London");

            }



            //parte 9 ambos dan false porque se encuentran en distintos espacios de memoria          
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);

        }
    }
}