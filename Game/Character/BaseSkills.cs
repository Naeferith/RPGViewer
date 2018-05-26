using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class BaseSkills
    {
        private int _charisma;
        private int _constitution;
        private int _dexterity;
        private int _intelligence;
        private int _spirit;
        private int _strength;

        public int Charisma { get { return _charisma; } set { _charisma = value; } }
        public int Constitution { get { return _constitution; } set { _constitution = value; } }
        public int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public int Intelligence { get { return _intelligence; } set { _intelligence = value; } }
        public int Spirit { get { return _spirit; } set { _spirit = value; } }
        public int Strength { get { return _strength; } set { _strength = value; } }

        public BaseSkills(int charisma, int constitution, int dexterity, int intelligence, int spirit, int strength)
        {
            _charisma     = charisma;
            _constitution = constitution;
            _dexterity    = dexterity;
            _intelligence = intelligence;
            _spirit       = spirit;
            _strength     = strength;
        }

        public override string ToString()
        {
            return "Base Stats   \n> Charisma     : " + _charisma +
                                "\n> Constitution : " + _constitution +
                                "\n> Dexterity    : " + _dexterity +
                                "\n> Intelligence : " + _intelligence +
                                "\n> Spirit       : " + _spirit +
                                "\n> Strength     : " + _strength;
        }
    }
}
