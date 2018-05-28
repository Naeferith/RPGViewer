using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Abilities.Range;
using RPGViewer.Game.Character;
using RPGViewer.Game.Effects;
using RPGViewer.Game.Mathematics;

namespace RPGViewer.Game.Abilities
{
    public class Curse : Attack
    {
        /// <summary>
        /// Constructor for avoidable <see cref="Curse"/>
        /// </summary>
        public Curse(string label, string description, Avaliability avaliability, Scope scope, int diceBonus, Defences defence, List<Effect> le) : base(label, description, avaliability, scope, new DiceExpression(), le, diceBonus, defence)
        {
        }

        /// <summary>
        /// Constructor for unavoidable <see cref="Curse"/>
        /// </summary>
        public Curse(string label, string description, Avaliability avaliability, Scope scope, List<Effect> le) : base(label, description, avaliability, scope, new DiceExpression(), le)
        {
        }
    }
}
