using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public interface ILevelable : IHasLevel
    {
        /// <summary>
        /// Called when a <see cref="ILevelable"/> reaches his <see cref="TotalExperience"/>.
        /// </summary>
        /// <param name="e"></param>
        void OnLevelChanged(LevelableEventArgs e);

        /// <summary>
        /// Number total of experience points required to reach next level.
        /// </summary>
        int TotalExperience { get; set; }

        /// <summary>
        /// Current amount of experience
        /// </summary>
        int Experience { get; set; }
    }
}
