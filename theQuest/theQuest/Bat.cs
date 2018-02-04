using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace theQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            //Move randomly
            if(random.Next(0, 2)==0)
            this.location=Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            else
            this.location = Move((Direction)random.Next(0, 4), game.Boundaries);

            // Attack 
            if (NearPlayer())
                game.HitPlayer(2, random);
        }

    }
}
