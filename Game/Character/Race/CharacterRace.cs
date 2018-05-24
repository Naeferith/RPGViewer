using RPGViewer.Game.Character.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character.Race
{
    abstract class CharacterRace
    {
        /// <summary>
        /// Race name
        /// </summary>
        private string _name;

        /// <summary>
        /// Native Language of the Race
        /// </summary>
        public readonly CharacterLanguage NATIVE_LANGUAGE;

        protected CharacterRace(string name, CharacterLanguage language)
        {
            _name = name;
            NATIVE_LANGUAGE = language;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
