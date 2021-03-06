﻿using RPGViewer.Game.Character.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character.Race
{
    public abstract class CharacterRace
    {
        /// <summary>
        /// Race name
        /// </summary>
        private string _name;

        /// <summary>
        /// Native Language of the Race
        /// </summary>
        public readonly Language NATIVE_LANGUAGE;

        protected CharacterRace(string name, Language language)
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
