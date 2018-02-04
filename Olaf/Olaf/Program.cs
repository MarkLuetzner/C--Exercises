using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olaf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            string result = "";

            while (x>0)
            {
                if (x == 2)
                    result = result + "im Maaß zu";

                if (x > 4)
                    result = result + "in Maßen vor";

                if (x == 3)
                    result = result + "n, nur ";

                x = x - 1;

                if (x == 1)
                { result = result + "finden"; x = x - 1; }

                if (x == 4)
                    result = result + "hande";


                result = result + "";
            }

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
