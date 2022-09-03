using System;

namespace Jarai.CSharp.Relation.Inheritance
{
    public abstract class M�bel // Sobald eine Klasse mindestens eine abstracte Methode enth�lt,
        // wird die Klasse zur abstracten Basisclasse (ABC)
        // Von abstracten Klassen kann keine Instanz erstellt werden 
    {
        protected bool IsAssembled = false;

        protected string Name;

        protected double Preis;


        protected M�bel(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public abstract void Benutzen(); // Abstracte Methoden M�SSEN �berschrieben werden

        public abstract void Montieren(); // und k�nnen in der Basisklasse NICHT implementiert werden

        protected void ThrowExceptionIfNotAssembled()
        {
            if (!IsAssembled)
                throw new InvalidOperationException("M�bel ist nicht montiert.");
        }
    }
}
