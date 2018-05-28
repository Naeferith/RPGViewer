using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public class PoisonDot : ElementalDot
    {
        public PoisonDot(int value, int nbTurns = -1) : base(Element.Poison, value, nbTurns)
        {
        }
    }
}
