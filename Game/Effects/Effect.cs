using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public abstract class Effect : IEffect
    {
        public abstract event EventHandler TurnStarted;
        public abstract event EventHandler TurnEnded;
        public abstract event EventHandler TargetReached;
        public abstract event EventHandler TargetMissed;

        public abstract void OnTurnStarted(EffectEventArgs e);
        public virtual void OnTurnEnded(EffectEventArgs e)
        {
            if (_nbTurn != -1)
            {
                _nbTurn--;
                if (_nbTurn == 0) { /*Remove event from Caster evetlist*/}
            }
        }
        public abstract void OnTargetReached(EffectEventArgs e);
        public abstract void OnTargetMissed(EffectEventArgs e);

        /// <summary>
        /// An information about the <see cref="Effect"/> itself. It can be an amount of damage, a percentage etc.
        /// </summary>
        protected double _value;

        /// <summary>
        /// How many turns left this <see cref="Effect"/> is active>
        /// If an event is permanent, the value is -1;
        /// </summary>
        private int _nbTurn;

        protected Effect(double value, int nbTurns = -1)
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
