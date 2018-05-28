using RPGViewer.Game.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    /// <summary>
    /// Alterate a <see cref="Mob"/>'s <see cref="Defence"/>
    /// </summary>
    public class DefenceAteration : Effect
    {
        public DefenceAteration(Dictionary<Defences, int> value, int nbTurns = -1) : base(value, nbTurns)
        {
        }

    }
}
