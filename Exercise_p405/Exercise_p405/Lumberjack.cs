using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_p405
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                meal.Push(food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(this.Name + " eating flapjacks" + Environment.NewLine);
            foreach(Flapjack flapjack in meal)
            {
                Console.WriteLine(this.Name + " ate a " + flapjack.ToString() + " flapjack");
            }
            for (int i = 0; i < meal.Count; i++)
            {
                meal.Pop();
            }
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }
}
