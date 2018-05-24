using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Playfield.Terrain
{
    class Obstacle : Ground
    {
        public Obstacle() : base(new List<Effect>(), 0)
        {
        }
    }
}
