using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public interface ILevelable
    {
        /// <summary>
        /// Raises when <see cref="ILevelable"/>'s <see cref="Experience"/> reaches <see cref="TotalExperience"/>.
        /// </summary>
        event EventHandler LevelChanged;

        /// <summary>
        /// Called when <see cref="LevelChanged"/> is raised.
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
