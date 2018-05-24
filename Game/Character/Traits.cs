using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class Traits
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

        public int Agility { get { return _agility; } set { _agility = value; } }
        public int Arcane { get { return _arcane; } set { _arcane = value; } }
        public int Athletism { get { return _athletism; } set { _athletism = value; } }
        public int Bluff { get { return _bluff; } set { _bluff = value; } }
        public int Diplomacy { get { return _diplomacy; } set { _diplomacy = value; } }
        public int Discretion { get { return _discretion; } set { _discretion = value; } }
        public int Exploration { get { return _exploration; } set { _exploration = value; } }
        public int Heal { get { return _heal; } set { _heal = value; } }
        public int History { get { return _history; } set { _history = value; } }
        public int Intimidation { get { return _intimidation; } set { _intimidation = value; } }
        public int Intuition { get { return _intuition; } set { _intuition = value; } }
        public int Larceny { get { return _larceny; } set { _larceny = value; } }
        public int Nature { get { return _nature; } set { _nature = value; } }
        public int Perception { get { return _perception; } set { _perception = value; } }
        public int Religion { get { return _religion; } set { _religion = value; } }
        public int Stamina { get { return _stamina; } set { _stamina = value; } }
        public int Street_knowledge { get { return _street_knowledge; } set { _street_knowledge = value; } }

        public Traits(int agi, int arc, int ath, int blu, int dip, int dis, int exp, int hea, int his, int inti, int intu, int lar, int nat, int per, int rel, int sta, int skn)
        {
            this._agility      = agi;
            this._arcane       = arc;
            this._athletism    = ath;
            this._bluff        = blu;
            this._diplomacy    = dip;
            this._discretion   = dis;
            this._exploration  = exp;
            this._heal         = hea;
            this._history      = his;
            this._intimidation = inti;
            this._intuition    = intu;
            this._larceny      = lar;
            this._nature       = nat;
            this._perception   = per;
            this._religion     = rel;
            this._stamina      = sta;
            this._street_knowledge = skn;
        }
    }
}
