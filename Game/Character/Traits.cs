using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class Traits : IMutable<Traits>
    {
        private int _agility;
        private int _arcane;
        private int _athletism;
        private int _bluff;
        private int _diplomacy;
        private int _discretion;
        private int _exploration;
        private int _heal;
        private int _history;
        private int _intimidation;
        private int _intuition;
        private int _larceny;
        private int _nature;
        private int _perception;
        private int _religion;
        private int _stamina;
        private int _street_knowledge;

        public int Agility { get { return _agility; } }
        public int Arcane { get { return _arcane; } }
        public int Athletism { get { return _athletism; } }
        public int Bluff { get { return _bluff; } }
        public int Diplomacy { get { return _diplomacy; } }
        public int Discretion { get { return _discretion; } }
        public int Exploration { get { return _exploration; } }
        public int Heal { get { return _heal; } }
        public int History { get { return _history; } }
        public int Intimidation { get { return _intimidation; } }
        public int Intuition { get { return _intuition; } }
        public int Larceny { get { return _larceny; } }
        public int Nature { get { return _nature; } }
        public int Perception { get { return _perception; } }
        public int Religion { get { return _religion; } }
        public int Stamina { get { return _stamina; } }
        public int Street_knowledge { get { return _street_knowledge; } }

        public Traits(int agi, int arc, int ath, int blu, int dip, int dis, int exp, int hea, int his, int inti, int intu, int lar, int nat, int per, int rel, int sta, int skn)
        {
            _agility      = agi;
            _arcane       = arc;
            _athletism    = ath;
            _bluff        = blu;
            _diplomacy    = dip;
            _discretion   = dis;
            _exploration  = exp;
            _heal         = hea;
            _history      = his;
            _intimidation = inti;
            _intuition    = intu;
            _larceny      = lar;
            _nature       = nat;
            _perception   = per;
            _religion     = rel;
            _stamina      = sta;
            _street_knowledge = skn;
        }

        public override string ToString()
        {
            return  "Traits :\n> Agility      : " + _agility +
                            "\n> Arcane       : " + _arcane +
                            "\n> Athletism    : " + _athletism +
                            "\n> Bluff        : " + _bluff +
                            "\n> Diplomacy    : " + _diplomacy +
                            "\n> Discretion   : " + _discretion +
                            "\n> Exploration  : " + _exploration +
                            "\n> Heal         : " + _heal +
                            "\n> History      : " + _history +
                            "\n> Intimidation : " + _intimidation +
                            "\n> Intuition    : " + _intuition +
                            "\n> Larceny      : " + _larceny +
                            "\n> Nature       : " + _nature +
                            "\n> Perception   : " + _perception +
                            "\n> Religion     : " + _religion +
                            "\n> Stamina      : " + _stamina +
                            "\n> Street Knowledge : " + _street_knowledge;
        }

        public void Edit(Traits deltaObject)
        {
            _agility      += deltaObject._agility;
            _arcane       += deltaObject._arcane;
            _athletism    += deltaObject._athletism;
            _bluff        += deltaObject._bluff;
            _diplomacy    += deltaObject._diplomacy;
            _discretion   += deltaObject._discretion;
            _exploration  += deltaObject._exploration;
            _heal         += deltaObject._heal;
            _history      += deltaObject._history;
            _intimidation += deltaObject._intimidation;
            _intuition    += deltaObject._intuition;
            _larceny      += deltaObject._larceny;
            _nature       += deltaObject._nature;
            _perception   += deltaObject._perception;
            _religion     += deltaObject._religion;
            _stamina      += deltaObject._stamina;
            _street_knowledge += deltaObject._street_knowledge;
        }
    }
}
