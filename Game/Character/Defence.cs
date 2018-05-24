using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Character
{
    public class Defence
    {
        private int _armorClass;
        private int _reflexes;
        private int _vigor;
        private int _will;
        
        public int ArmorClass { get { return _armorClass; } set { _armorClass = value; } }
        public int Reflexes { get { return _reflexes; } set { _reflexes = value; } }
        public int Vigor { get { return _vigor; } set { _vigor = value; } }
        public int Will { get { return _will; } set { _will = value; } }

        public Defence(int armorClass, int reflexes, int vigor, int will)
        {
            _armorClass = armorClass;
            _reflexes = reflexes;
            _vigor = vigor;
            _will = will;
        }
    }
}
