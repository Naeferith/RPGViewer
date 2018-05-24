using RPGViewer.Game.Abilities.Range.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities.Range
{
    public abstract class AbilityRange
    {
        /// <summary>
        /// The maximal distance from the <see cref="Character.Mob"/> expressed in number of cases
        /// </summary>
        private int _distance;

        /// <summary>
        /// The area of effect of the <see cref="Ability"/>
        /// </summary>
        private RangeShape _areaOfEffect;

        protected AbilityRange(int distance, RangeShape areaOfEffect)
        {
            _distance = distance;
            _areaOfEffect = areaOfEffect ?? throw new ArgumentNullException(nameof(areaOfEffect));
        }

        public enum Orientation
        {
            North,
            South,
            East,
            West
        }
    }
}
