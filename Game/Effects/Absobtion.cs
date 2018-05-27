using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public class Absobtion : Effect
    {
        

        public override event EventHandler TurnStarted;
        public override event EventHandler TurnEnded;
        public override event EventHandler TargetReached;
        public override event EventHandler TargetMissed;

        /// <summary>
        /// Absorb a certain quantity of damages
        /// </summary>
        /// <param name="value">The quantity of damages</param>
        protected Absobtion(double value, int nbTurns = -1) : base(value, nbTurns)
        {
        }
        
        public override void OnTurnStarted(EffectEventArgs e) {}

        public override EffectEventArgs OnTargetReached(EffectEventArgs e)
        {
            if (TargetReached != null)
            {
                if (e.Damage > _value) e.Damage -= (int) _value;
                else _value -= e.Damage;
            }
            return e;
        }

        public override void OnTargetMissed(EffectEventArgs e) {}
    }
}
