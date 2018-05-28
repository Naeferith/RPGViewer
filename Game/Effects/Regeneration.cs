using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    /// <summary>
    /// Regenerate a certain amount of health at the start of each turn
    /// </summary>
    public class Regeneration : Effect
    {
        protected Regeneration(int value, int nbTurns = -1) : base(value, nbTurns)
        {
        }
    }
}
