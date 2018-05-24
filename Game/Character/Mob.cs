using RPGViewer.Game.Character.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    class Mob
    {
        /// <summary>
        /// Character name
        /// </summary>
        private string _pseudo;

        /// <summary>
        /// Character race
        /// </summary>
        private CharacterRace _race;

        /// <summary>
        /// Size expressed in cm
        /// </summary>
        private int _size;

        /// <summary>
        /// Weight expressed in kg
        /// </summary>
        private int _weight;

        /// <summary>
        /// Health points
        /// </summary>
        private int _hp;

        /// <summary>
        /// Defence stats
        /// </summary>
        private Defence _defences;

        /// <summary>
        /// Character bonus initiative
        /// </summary>
        private int _initiative;

        public Mob(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative)
        {
            _pseudo = pseudo ?? throw new ArgumentNullException(nameof(pseudo));
            _race = race ?? throw new ArgumentNullException(nameof(race));
            _size = size;
            _weight = weight;
            _hp = hp;
            _defences = defences ?? throw new ArgumentNullException(nameof(defences));
            _initiative = initiative;
        }

        public override string ToString()
        {
            return "[" + _pseudo + " (" + _race.ToString() + ")]";
        }
    }
}
