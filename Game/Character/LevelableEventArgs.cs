using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class LevelableEventArgs : EventArgs
    {
        // Everything that can be upgraded by a level up

        /// <summary>
        /// HP added to a <see cref="ILevelable"/> character.
        /// </summary>
        public int BonusHP { get; set; }

        /// <summary>
        /// Value of each Trait to be added at a character's <see cref="Traits"/>
        /// </summary>
        public Traits DeltaTraits { get; set; }

        /// <summary>
        /// Value of each Trait to be added at a character's <see cref="Defence"/>
        /// </summary>
        public Traits DeltaDefence { get; set; }

        /// <summary>
        /// Value of each Trait to be added at a character's <see cref="BaseSkills"/>
        /// </summary>
        public Traits DeltaBaseSkils { get; set; }
    }
}
