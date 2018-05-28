using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public abstract class Effect
    {
        /// <summary>
        /// An information about the <see cref="Effect"/> itself. It can be an amount of damage, a percentage etc.
        /// </summary>
        protected object _value;

        /// <summary>
        /// How many turns left this <see cref="Effect"/> is active.
        /// If an effect is permanent, the value is -1;
        /// </summary>
        private int _nbTurn;

        
        public int TurnsLeft { get => _nbTurn; set { _nbTurn = value; } }

        public object Value { get => _value; set { _value = value; } }

        protected Effect(object value, int nbTurns = -1)
        {
            _value = value;
            _nbTurn = nbTurns;
        }
        
    }

    public enum Elements
    {
        Rock,
        Fire,
        Water,
        Ice,
        Poison,
        Shadow,
        Light,
    }
}
