using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public class Absobtion : Effect
    {
        /// <summary>
        /// Absorb a certain quantity of damages
        /// </summary>
        /// <param name="value">The quantity of damages</param>
        protected Absobtion(int value, int nbTurns = -1) : base(value, nbTurns)
        {
        }
    }
}
