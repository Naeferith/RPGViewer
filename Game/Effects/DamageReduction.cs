using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public class DamageReduction : Effect
    {
        /// <summary>
        /// Damage taken is reduced by a certain percentage
        /// </summary>
        /// <param name="value">The percentage of damage absorbed</param>
        protected DamageReduction(double value) : base(value)
        {
        }
    }
}
