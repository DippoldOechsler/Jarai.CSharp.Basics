﻿using System;

namespace Jarai.CSharp.Basics.Parameters
{
    internal class Program
    {
        /// <summary>
        ///     Rahmenprogramm
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int a = 100, b = 200;

            TauscheByValue(a, b);
            Console.WriteLine("nach TauscheByValue: a={0:d}, b={0:d}" + a + b);

            TauscheByRef(ref a, ref b);
            Console.WriteLine("nach TauscheByRef: a={0:d}, b={0:d}" + a + b);

            Console.ReadLine();
        }

        private static void TauscheByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static void TauscheByValue(int x, int y) // Funktioniert nicht, da nur die Kopien getauscht werden
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
