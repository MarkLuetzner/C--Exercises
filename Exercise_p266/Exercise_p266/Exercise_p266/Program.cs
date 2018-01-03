using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p266
{
    class Program
    {
        static void Main(string[] args)
        {
            Besitzer besitzer = new Besitzer();
            Safe safe = new Safe();
            Dieb dieb = new Dieb();
            dieb.SafeÖffnen(safe, besitzer);
            Console.ReadKey();
        }
    }

    class Juwelen
    {
        public string Glitzern()
        {
            return "Blink, blink!";
        }
    }

    class Safe
    {
        private Juwelen inhalt = new Juwelen();
        private string safeKombination = "12345";
        public Juwelen Öffnen(string kombination)
        {
            if (kombination == safeKombination)
                return inhalt;
            else
                return null;

        }
        public void SchlossKnacken(Schlosser knacker)
        {
            knacker.KombinationAufschreiben(safeKombination);
        }

    }
    
    class Besitzer
    {
        private Juwelen erhaltenerInhalt;
        public void InhaltEntnehmen(Juwelen safeInhalt)
        {
            erhaltenerInhalt = safeInhalt;
            Console.WriteLine("Vielen Dank für meine Steinchen!" + safeInhalt.Glitzern());
        }

    }

    class Schlosser
    {

        private string notierteKombination = null;

        public void SafeÖffnen(Safe safe, Besitzer besitzer)
        {
            safe.SchlossKnacken(this);
            Juwelen safeInhalt = safe.Öffnen(notierteKombination);
            InhaltZurückgeben(safeInhalt, besitzer);
        }

        public void KombinationAufschreiben(string kombination)
        {
            notierteKombination = kombination;
        }

        virtual public void InhaltZurückgeben(Juwelen safeInhalt, Besitzer besitzer)
        {
            besitzer.InhaltEntnehmen(safeInhalt);
        }

    }

    class Dieb : Schlosser {
        private Juwelen gestohleneJuwelen = null;
        override public void InhaltZurückgeben(Juwelen safeInhalt, Besitzer besitzer) { 
        gestohleneJuwelen = safeInhalt;
            Console.WriteLine("Ich laue die Klunker!" + gestohleneJuwelen.Glitzern());
    }
    }


}
