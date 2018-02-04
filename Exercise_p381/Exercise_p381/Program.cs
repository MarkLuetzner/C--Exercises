using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p381
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Values.Three);
            Console.WriteLine(doesItMatch);
            Console.ReadKey();

        }
    }
}
