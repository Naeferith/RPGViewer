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

        public override event EventHandler TurnStarted;
        public override event EventHandler TurnEnded;
        public override event EventHandler TargetReached;
        public override event EventHandler TargetMissed;

        public override void OnTargetMissed(EffectEventArgs e) {}

        public override void OnTargetReached(EffectEventArgs e)
        {
            if (TargetReached != null)
            {
                e.Damage = (int)Math.Ceiling(e.Damage * (1 - _value)); 
            }
        }

        public override void OnTurnStarted(EffectEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
