using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p300
{
    class Program
    {
        static void Main(string[] args)
        {
            SchreckSchreck maxeDerClown = new SchreckSchreck("Große Schuhe", 14);
            LustigLustig lustigerClown = maxeDerClown;
            ISchreckClown schreckClown = lustigerClown as SchreckSchreck;
            schreckClown.KinderErschrecken();
            Console.ReadKey();
        }
    }

    class GroßerTyp : IClown
    {
        public string Name;
        public string MeinLustigesDing { get { return "große Schuhe"; } }
        public int Größe;

        public void ÜberSichSelbstReden()
        {
            Console.WriteLine("Ich heiße " + Name + "und bin" + Größe + "cm groß.");
        }

        public void Hupen()
        {
            Console.WriteLine("Hup, Hup");
        }
    }

    interface IClown
    {
        string MeinLustigesDing { get; }
        void Hupen();
    }

    interface ISchreckClown : IClown
    {
        string MeinSchreckDing { get; }
        void KinderErschrecken();
    }

    class LustigLustig : IClown
    {
        protected string meinLustigesDing;
        public string MeinLustigesDing
        {
            get
            {
                return "Hallo Kinder! Ich habe " + meinLustigesDing;
            }
        }

        public LustigLustig(string lustigesDing)
        {
            this.meinLustigesDing = lustigesDing;
        }

        public void Hupen()
        {
            Console.WriteLine(this.MeinLustigesDing);
        }
    }

    class SchreckSchreck : LustigLustig, ISchreckClown
    {
        private int anzahlSchreckDinge;
        public string MeinSchreckDing
        {
            get
            {
                return "Ich habe" + anzahlSchreckDinge + "Spinnen";
            }
        }

        public SchreckSchreck(string lustigesDing, int anzahlSchreckDinge) : base(lustigesDing)
        {
            this.anzahlSchreckDinge = anzahlSchreckDinge;
        }

        public void KinderErschrecken()
        {
            //Console.WriteLine("Buh ich hab dich");
            Console.WriteLine("Du kriegst mein " + base.meinLustigesDing + "nicht");
        }

}
}
