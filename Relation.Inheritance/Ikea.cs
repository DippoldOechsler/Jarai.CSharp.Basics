using System;
using System.Diagnostics;
using System.Reflection;

namespace Jarai.Relation.Inheritance
{
    public class Ikea
    {
        private static readonly double Konzernumsatz;
        private readonly double _filialumsatz;
        private readonly string _standort;

        static Ikea()
        {
            Konzernumsatz = 0;
        }

        public Ikea(string standort)
        {
            _standort = standort;
            _filialumsatz = 0;
        }

        public void Show()
        {
            Debug.WriteLine("=======================================");
            Debug.WriteLine("Ikea in      : " + _standort);
            Debug.WriteLine("Filialumsatz : " + _filialumsatz);
            Debug.WriteLine("Konzernumsatz: " + Konzernumsatz);
        }

        public M�bel Verkaufen()
        {
            Console.WriteLine($"Willkommen bei Ikea {_standort}.");
            Console.WriteLine("Was m�chten Sie kaufen? (Tisch, Stuhl oder Leer).");

            var eingabe = Console.ReadLine();

            if (string.IsNullOrEmpty(eingabe))
                return null;

            var typeName = GetType().Namespace + "." + eingabe;

            // Instanz via Reflection �ber den Klassennamen erstellen
            var m�bel = (M�bel)Assembly.GetExecutingAssembly().CreateInstance(typeName, true);

            return m�bel;
        }
    }
}
