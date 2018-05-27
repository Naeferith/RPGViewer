using RPGViewer.Game;
using RPGViewer.Game.Abilities.Range;
using RPGViewer.Game.Character.Race;
using RPGViewer.Game.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class Mob : IOrientable, IHasLevel
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

        private int _level;
        private int _baseHp;

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

        private List<int> _criticalValues;

        /// <summary>
        /// List of effects applied on the character.
        /// </summary>
        private List<Effect> _effects;

        /// <summary>
        /// The curent health of this character.
        /// </summary>
        public int Health
        {
            get => _hp;
            set
            {
                _hp = value;
                if (_hp <= 0) { /*Trigger a death event*/}
            }
        }

        /// <summary>
        /// The total health of this character.
        /// </summary>
        public int MaxHealth { get => _baseHp; set { _baseHp = value; } }

        /// <summary>
        /// The curent level of this character.
        /// </summary>
        public int Level { get => _level; set { _level = value; } }

        public Mob(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative, int level)
        {
            _pseudo = pseudo ?? throw new ArgumentNullException(nameof(pseudo));
            _race = race ?? throw new ArgumentNullException(nameof(race));
            _size = size;
            _weight = weight;
            _baseHp = _hp = hp;
            _defences = defences ?? throw new ArgumentNullException(nameof(defences));
            _initiative = initiative;
            _level = level;
            _criticalValues = new List<int>() { 20 };
        }

        public Mob(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative, int level, List<int> crits)
        {
            _pseudo = pseudo ?? throw new ArgumentNullException(nameof(pseudo));
            _race = race ?? throw new ArgumentNullException(nameof(race));
            _size = size;
            _weight = weight;
            _baseHp = _hp = hp;
            _defences = defences ?? throw new ArgumentNullException(nameof(defences));
            _initiative = initiative;
            _level = level;
            _criticalValues = crits;
        }

        public Orientation Orientation { get; set; }

        public override string ToString()
        {
            return "[" + _pseudo + " (" + _race.ToString() + ")]\n" + _defences.ToString();
        }
    }
}
