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
        private string _label;
        private string _description;
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


        //private Defence

        /// <summary>
        /// Tells if the <see cref="Ability"/> can be avoided or not.
        /// </summary>
        protected bool _isAvoidable;

        protected Ability(string label, string description, Avaliability avaliability, Scope scope, DiceExpression de, List<Effect> le, bool isAvoidable)
        {
            _label = label;
            _description = description;
            _avaliability = avaliability;
            _de = de;
            _effects = le;
            _isAvoidable = isAvoidable;
            _scope = scope;
        }

        public override string ToString()
        {
            return '[' + _avaliability.ToString() + "] " + _label + ": " + _description + " | " + _scope.ToString() + " | " + _de.ToString();
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
