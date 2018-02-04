using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace theQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }

        public override void Move(Random random)
        {
            //Move randomly
            if (random.Next(0, 3) == 0)
                this.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            // Attack 
            if (NearPlayer())
                game.HitPlayer(3, random);
        }

    }
}
