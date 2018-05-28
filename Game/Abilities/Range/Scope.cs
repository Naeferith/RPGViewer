using RPGViewer.Game.Abilities.Range.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Abilities.Range
{
    public abstract class Scope
    {
        /// <summary>
        /// The maximal distance from the <see cref="Character.Mob"/> expressed in number of cases
        /// </summary>
        private int _distance;

        /// <summary>
        /// The area of effect of the <see cref="Ability"/>
        /// </summary>
        private Shape _areaOfEffect;

        protected Scope(int distance, Shape areaOfEffect)
        {
            _distance = distance;
            _areaOfEffect = areaOfEffect ?? throw new ArgumentNullException(nameof(areaOfEffect));
        }
    }
}
