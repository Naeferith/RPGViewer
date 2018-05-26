using RPGViewer.Game.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Playfield.Terrain
{
    public class Ground
    {
        /// <summary>
        /// List of <see cref="Effect"/> due to AOE Abilities and/or environement bahvior.
        /// </summary>
        private List<Effect> _effects;

        /// <summary>
        /// Ground movespeed delta.
        /// </summary>
        private double _movementFactor;

        public Ground()
        {
            _effects = new List<Effect>();
            _movementFactor = 1;
        }

        public Ground(List<Effect> effects, double movementFactor)
        {
            _effects = effects;
            _movementFactor = movementFactor;
        }
    }
}
