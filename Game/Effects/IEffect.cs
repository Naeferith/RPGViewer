using RPGViewer.Game.Character;
using RPGViewer.Game.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Effects
{
    public interface IEffect
    {
        /// <summary>
        /// Raise this event at the start of each <see cref="Mob"/> turn.
        /// </summary>
        event EventHandler TurnStarted;

        /// <summary>
        /// Method called when <see cref="TurnStarted"/> is raised.
        /// </summary>
        void OnTurnStarted(EffectEventArgs e);

        /// <summary>
        /// Raise this event at the start of each <see cref="Mob"/> turn.
        /// </summary>
        event EventHandler TurnEnded;

        /// <summary>
        /// Method called when <see cref="TurnEnded"/> is raised.
        /// </summary>
        void OnTurnEnded(EffectEventArgs e);

        /// <summary>
        /// Raise this event if an <see cref="Ability"/> reach a <see cref="Mob"/>.
        /// </summary>
        event EventHandler TargetReached;

        /// <summary>
        /// Method called when <see cref="TargetReached"/> is raised.
        /// </summary>
        /// <returns>EffectArgs modified y the <see cref="Effect"/></returns>
        EffectEventArgs OnTargetReached(EffectEventArgs e);

        /// <summary>
        /// Raise this event if an <see cref="Ability"/> doesn't reach a <see cref="Mob"/>.
        /// </summary>
        event EventHandler TargetMissed;

        /// <summary>
        /// Method called when <see cref="TargetMissed"/> is raised.
        /// </summary>
        void OnTargetMissed(EffectEventArgs e);
    }
}
