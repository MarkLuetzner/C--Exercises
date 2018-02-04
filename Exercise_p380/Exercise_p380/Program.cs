using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p380
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
                        {
            new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
        };

            IEnumerable<Bird> upcastDucks = ducks;

            List<Object> objects = new List<Object>();
            objects.Add(new Bird() { Name = "Feathers" });
            objects.AddRange(ducks);
            objects.Add(new Penguin() { Name = "George" });

            foreach (Object obj in objects)
            {
                Console.WriteLine(obj);
                Console.ReadKey();
            }

        }
    }


    class Bird
    {
        public string Name { get; set; }
        public virtual void Fly()
        {
            Console.WriteLine("Flap, flap");
        }
        public override string ToString()
        {
            return "A bird named " + Name;
        }
    }

    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly");
        }
        public override string ToString()
        {
            return "A penguin named " + base.Name;
        }
    }


    class Duck : Bird,IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return "A " + Size + "inch " + Kind.ToString();
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
