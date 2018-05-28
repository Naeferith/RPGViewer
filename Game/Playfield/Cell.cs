using RPGViewer.Game.Character;
using RPGViewer.Game.Playfield.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Playfield
{
    public class Cell
    {
        private Ground _ground;
        private Mob _actor = null;

        public Mob Actor { get => _actor; set { _actor = value; } }

        public Cell()
        {
            _ground = new Ground();
        }
    }
}
