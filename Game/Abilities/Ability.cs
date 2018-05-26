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
    /// <summary>
    /// Represent a move usable on a fight.
    /// </summary>
    public abstract class Ability
    {
        /// <summary>
        /// The <see cref="Scope"/> on the Ability
        /// </summary>
        private Avaliability _avaliability;

        /// <summary>
        /// The range of the skill.
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

        /// <summary>
        /// Tells if the <see cref="Ability"/> can be avoided or not.
        /// </summary>
        private bool _isAvoidable;

        protected Ability(Avaliability avaliability, Scope scope, DiceExpression de, List<Effect> le, bool isAvoidable)
        {
            _avaliability = avaliability;
            _de = de;
            _effects = le;
            _isAvoidable = isAvoidable;
            _scope = scope;
        }

        /// <summary>
        /// Defines the level of avaliability of an Ability.
        /// Will have no restrictions on the usage.
        /// Meeting ability can be used once per fight.
        /// Daily is once a day.
        /// </summary>
        public enum Avaliability
        {
            Will,
            Meeting,
            Daily
        } 
    }
}
