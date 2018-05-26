using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Effects;

namespace RPGViewer.Game.Playfield.Terrain
{
    public abstract class Obstacle : Ground
    {
        public Obstacle(List<Effect> effects) : base(effects, 0)
        {
        }
    }
}
