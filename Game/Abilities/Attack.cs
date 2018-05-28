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
    public class Attack : Ability
    {
        private int _diceBonus;
        private Defences _targetDefence;

        public Attack(string label, string description, Avaliability avaliability, Scope scope, DiceExpression de, List<Effect> le, int diceBonus, Defences defence) : base(label, description, avaliability, scope, de, le, true)
        {
            _diceBonus = diceBonus;
            _targetDefence = defence;
        }

        public Attack(string label, string description, Avaliability avaliability, Scope scope, DiceExpression de, List<Effect> le) : base(label, description, avaliability, scope, de, le, false)
        {
        }

        public override string ToString()
        {
            return (_isAvoidable) ? "Attack " + base.ToString() : "Attack (non-esquivable) " + base.ToString();
        }
    }
}
