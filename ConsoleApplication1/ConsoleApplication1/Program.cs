using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    using System;

    public class TextInput
    {
        public List<char> currentvalue;

        public virtual void Add(char c)
        {
            currentvalue.Add(c);
        }

        public string GetValue()
        {  
            return currentvalue.ToString(); 
        }
    }

    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if (!char.IsNumber(c))
            {
            }
            else
                currentvalue.Add(c);
        }

    }


    public class UserInput
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}

