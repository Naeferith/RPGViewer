using RPGViewer.Game.Abilities.Range;
using RPGViewer.Game.Effects;
using RPGViewer.Game.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities
{
    public abstract class Buff : Ability
    {
        protected Buff(Avaliability avaliability, Scope scope, List<Effect> le) : base(avaliability, scope, new DiceExpression(), le, false)
        {
        }
    }
}
