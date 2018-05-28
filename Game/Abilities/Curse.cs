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
        public Curse(string label, string description, Avaliability avaliability, Scope scope, int diceBonus, Defences defence, List<Effect> le, bool isAvoidable) : base(label, description, avaliability, scope, new DiceExpression(), diceBonus, defence, le, isAvoidable)
        {
        }
    }
}
