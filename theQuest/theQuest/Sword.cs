using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace theQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            int maxDamage = 4;
            int radius = 25;

            Direction direction1 = Direction.Up;
            Direction direction2 = Direction.Up;

            switch (direction)
            {
                case Direction.Up:
                     direction1 = Direction.Right;
                     direction2 = Direction.Left;
                    break;
                case Direction.Right:
                     direction1 = Direction.Down;
                     direction2 = Direction.Up;
                    break;
                case Direction.Down:
                     direction1 = Direction.Left;
                     direction2 = Direction.Right;
                    break;
                case Direction.Left:
                     direction1 = Direction.Up;
                     direction2 = Direction.Down;
                    break;
            }

            if (!base.DamageEnemy(direction, radius, maxDamage, random))
            {
                if (!base.DamageEnemy(direction1, radius, maxDamage, random))
                {
                    base.DamageEnemy(direction2, radius, maxDamage, random);
                }
            }

        }
    }
}
