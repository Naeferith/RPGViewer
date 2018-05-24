using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Character.Race;

namespace RPGViewer.Game.Character
{
    public class Partner : Mob
    {
        private PlayerCharacter _master;

        public Partner(string pseudo, CharacterRace race, int size, int weight, int hp, Defence defences, int initiative, PlayerCharacter master) : base(pseudo, race, size, weight, hp, defences, initiative)
        {
            _master = master;
        }
    }
}
