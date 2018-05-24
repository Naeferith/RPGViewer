using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Character.Language;

namespace RPGViewer.Game.Character.Race
{
    class Human : CharacterRace
    {
        public Human() : base("Human", new Common())
        {
        }
    }
}
