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

        public Attack(string label, string description, Avaliability avaliability, Scope scope, DiceExpression de, int diceBonus, Defences defence, List<Effect> le, bool isAvoidable) : base(label, description, avaliability, scope, de, le, isAvoidable)
        {
            _diceBonus = diceBonus;
            _targetDefence = defence;
        }

        public override string ToString()
        {
            return (_isAvoidable) ? "Attack " + base.ToString() : "Attack (non-esquivable) " + base.ToString();
        }
    }
}
