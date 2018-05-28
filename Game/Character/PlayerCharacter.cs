using RPGViewer.Game.Character.Languages;
using RPGViewer.Game.Character.Race;
using RPGViewer.Game.Items.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class PlayerCharacter : Mob, ILevelable
    {
        private int _experience;
        private int _totalExperience;

        /// <summary>
        /// Base skills
        /// </summary>
        private BaseSkills _baseSkills;

        /// <summary>
        /// Character traits
        /// </summary>
        private Traits _traits;

        /// <summary>
        /// List of spoken languages
        /// </summary>
        private List<Language> _languages;

        /// <summary>
        /// List of secondary characters such as necromancer spawns, pets etc.
        /// </summary>
        private List<Partner> _partners;

        /// <summary>
        /// The set of equipment of a character.
        /// </summary>
        private List<Equipment> _equimpentSet;

        public PlayerCharacter(string pseudo, CharacterRace race, int size, int weight, int hp, Dictionary<Defences, int> defences, int initiative, int level, BaseSkills bs, Traits tra, List<Language> lang = null, List<Partner> part = null) : base(pseudo, race, size, weight, hp, defences, initiative, level)
        {
            _baseSkills = bs;
            _traits = tra;
            _languages = (lang == null) ? new List<Language> { race.NATIVE_LANGUAGE } : lang;
            _partners = (part == null) ? new List<Partner>() : part;
        }

        public bool CanUnderstand(Language language)
        {
            foreach(Language lang in _languages)
            {
                if (lang.GetType() == language.GetType()) return true;
            }
            return false;
        }

        public int TotalExperience { get; set; }
        public int Experience
        {
            get => _experience;
            set
            {
                if (value < _totalExperience) _experience = value;
                else
                {
                    _experience = Math.Abs(_totalExperience - value);
                    //OnLevelChanged(/*Find a way to manage properly new LevelableEventArgs() values depending on former level data*/);
                }
            }

        }
        
        public virtual void OnLevelChanged(LevelableEventArgs e)
        {
            Level++;
            //Do Stuff
        }

        public override string ToString()
        {
            return base.ToString() + "\n\n" + _baseSkills.ToString() + "\n\n" + _traits.ToString();
        }
    }
}
