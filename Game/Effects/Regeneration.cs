using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    /// <summary>
    /// Regenerate a certain amount of health at the start of each turn
    /// </summary>
    class Regeneration : Effect
    {
        protected Regeneration(double value, int nbTurns = -1) : base(value, nbTurns)
        {
        }

        public override event EventHandler TurnStarted;
        public override event EventHandler TurnEnded;
        public override event EventHandler TargetReached;
        public override event EventHandler TargetMissed;

        public override void OnTargetMissed(EffectEventArgs e) {}

        public override void OnTargetReached(EffectEventArgs e) {}

        public override void OnTurnStarted(EffectEventArgs e)
        {
            e.Caster.Health += (int)_value;
        }
    }
}
