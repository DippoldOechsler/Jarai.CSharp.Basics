using System;
using System.Diagnostics;

namespace Jarai.Pattern.State
{
    public class Telefon
    {
        // Ein Telefon hat einen zustand
        // Beispiel f�r "Zustand Entwurfsmuster"

        public Telefon()
        {
            AktuellerZustand = new Aufgelegt();
            if (OnAufgelegt != null)
                OnAufgelegt(this, null);
        }

        public Zustand AktuellerZustand { get; private set; }

        public void Abheben()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            // Die tats�chliche aktion ist abh�ngig vom aktuellen Zustand
            // (sp�tes binden)
            if (AktualisiereZustand(AktuellerZustand.Abheben()))
                if (OnAbgehoben != null)
                    OnAbgehoben(this, null);
        }

        public void AnnehmenAnruf()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);

            if (AktualisiereZustand(AktuellerZustand.AnnehmenAnruf()))
                if (OnVerbunden != null)
                    OnVerbunden(this, null);
        }


        public void Auflegen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            if (AktualisiereZustand(AktuellerZustand.Auflegen()))
                if (OnAufgelegt != null)
                    OnAufgelegt(this, null);
        }

        public void Sprechen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktuellerZustand = AktuellerZustand.Sprechen();
        }

        public void W�hlen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            if (AktualisiereZustand(AktuellerZustand.W�hlen()))
                if (OnVerbunden != null)
                    OnVerbunden(this, null);
        }

        public event EventHandler OnAbgehoben;

        public event EventHandler OnAufgelegt;
        public event EventHandler OnVerbunden;

        public event EventHandler OnZustandGe�ndert;

        private bool AktualisiereZustand(Zustand neuerZustand)
        {
            var istGe�ndert = false;

            if (AktuellerZustand != neuerZustand)
            {
                istGe�ndert = true;
                AktuellerZustand = neuerZustand;
                if (OnZustandGe�ndert != null)
                    OnZustandGe�ndert(this, null);
            }

            return istGe�ndert;
        }
    }
}
