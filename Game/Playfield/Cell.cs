using RPGViewer.Game.Character;
using RPGViewer.Game.Playfield.Terrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Playfield
{
    class Cell
    {
        private Ground _ground;
        private Mob _actor = null;

        public Cell(int x, int y)
        {
            _ground = new Ground();
        }
    }
}
