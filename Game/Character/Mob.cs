using RPGViewer.Game;
using RPGViewer.Game.Abilities;
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
    public class Mob : IOrientable, IHasLevel, IMutable<Dictionary<Defences, int>>
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
        private int _hp;

        private Dictionary<Defences, int> _defences;

        /// <summary>
        /// Character bonus initiative
        /// </summary>
        private int _initiative;

        private List<int> _criticalValues;

        /// <summary>
        /// List of effects applied on the character.
        /// </summary>
        private List<Effect> _effects;


        private List<Ability> _abilities;

        /// <summary>
        /// Defence stats
        /// </summary>
        public Dictionary<Defences, int> DefenceStats { get => _defences; set { _defences = value; } }

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

        public Mob(string pseudo, CharacterRace race, int size, int weight, int hp, Dictionary<Defences, int> defences, int initiative, int level, List<Ability> abilities = null, List<int> crits = null)
        {
            _abilities = (abilities == null) ? new List<Ability>() : abilities;
            _pseudo = pseudo ?? throw new ArgumentNullException(nameof(pseudo));
            _race = race ?? throw new ArgumentNullException(nameof(race));
            _size = size;
            _weight = weight;
            _baseHp = _hp = hp;

            _defences = new Dictionary<Defences, int> {
                {Defences.ArmorClass , 0},
                {Defences.Reflexes , 0},
                {Defences.Vigor , 0},
                {Defences.Will , 0},
            };
            Edit(defences);

            _initiative = initiative;
            _level = level;
            _effects = new List<Effect>();
            _criticalValues = (crits == null) ? new List<int>() { 20 } : crits;
        }

        public Orientation Orientation { get; set; }

        public override string ToString()
        {
            return "[" + _pseudo + " (" + _race.ToString() + ")]\n" + _defences.ToString();
        }

        public void Edit(Dictionary<Defences, int> deltaObject)
        {
            if (deltaObject == null) throw new ArgumentNullException(nameof(deltaObject));
            foreach (Defences entry in Enum.GetValues(typeof(Defences)))
            {
                int value;
                deltaObject.TryGetValue(entry, out value);
                _defences[entry] += value;
            }
        }

        
    }
    public enum Defences
    {
        ArmorClass,
        Reflexes,
        Vigor,
        Will
    }
}
