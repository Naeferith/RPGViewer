using RPGViewer.Game.Character.Language;
using RPGViewer.Game.Character.Race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class PlayerCharacter : Mob
    {

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
        private List<CharacterLanguage> _languages;

        /// <summary>
        /// List of secondary characters such as necromancer spawns, pets etc.
        /// </summary>
        private List<Partner> _partners;

        public PlayerCharacter(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative, BaseSkills bs, Traits tra) : base(pseudo, race, size, weight, hp, defences, initiative)
        {
            _baseSkills = bs;
            _traits = tra;
            _languages = new List<CharacterLanguage>() { race.NATIVE_LANGUAGE };
            _partners = new List<Partner>();

        }

        public PlayerCharacter(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative, BaseSkills bs, Traits tra, List<CharacterLanguage> lang, List<Partner> part) : base(pseudo, race, size, weight, hp, defences, initiative)
        {
            _baseSkills = bs;
            _traits = tra;
            _languages = lang;
            _partners = part;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
