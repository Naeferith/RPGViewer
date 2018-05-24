using RPGViewer.Game.Effects;
using RPGViewer.Game.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities
{
    abstract class Ability
    {
        /// <summary>
        /// The <see cref="Scope"/> on the Ability
        /// </summary>
        private Scope _scope;

        /// <summary>
        /// The <see cref="DiceExpression"/> of the <see cref="Ability"/>.
        /// Can be empty.
        /// </summary>
        private DiceExpression _de;

        /// <summary>
        /// The effects of the <see cref="Ability"/>.
        /// Can be empty.
        /// </summary>
        private List<Effect> _effects;

        protected Ability(Scope scope)
        {
            _scope = scope;
            _de = new DiceExpression();
            _effects = new List<Effect>();
        }

        protected Ability(Scope scope, DiceExpression de, List<Effect> le)
        {
            _scope = scope;
            _de = de;
            _effects = le;
        }

        /// <summary>
        /// Defines the level of avaliability of an Ability.
        /// WILL have no restrictions on the usage.
        /// MEETING ability can be used once per fight.
        /// DAILY is once a day
        /// </summary>
        public enum Scope
        {
            WILL,
            MEETING,
            DAILY
        } 
    }
}
