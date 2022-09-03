using System;

namespace Jarai.CSharp.Relation.Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ikeaFrankfurt = new Ikea("Frankfurt");
            var ikeaStuttgart = new Ikea("Stuttgart");

            try
            {
                var meinM�bel = ikeaFrankfurt.Verkaufen();

                // meinM�bel.Benutzen(); // Exception: Nicht montiert!
                meinM�bel.Montieren();
                meinM�bel.Benutzen();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ikeaFrankfurt.Show();
        }
    }
}
