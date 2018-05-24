using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    abstract class Effect
    {
        /// <summary>
        /// An information about the <see cref="Effect"/> itself. It can be a number of turns, an amount of damage etc.
        /// </summary>
        private int _value;

        protected Effect(int value)
        {
            _value = value;
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
