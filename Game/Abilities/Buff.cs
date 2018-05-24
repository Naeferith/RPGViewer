using RPGViewer.Game.Effects;
using RPGViewer.Game.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities
{
    abstract class Buff : Ability
    {
        protected Buff(Scope scope, List<Effect> le) : base(scope, new DiceExpression(), le)
        {
        }
    }
}
