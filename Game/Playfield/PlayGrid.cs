using RPGViewer.Game.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Playfield
{
    class PlayGrid
    {
        private static PlayGrid _playGrid = null;
        private Cell[,] _grid = null;
        private bool _started = false;
        private Player _currentPlayer = null;
        private List<Mob> _actors = new List<Mob>();

        public Cell[,] Grid { get { return _grid;} }

        public static PlayGrid GetPlayGrid()
        {
            if (_playGrid == null) _playGrid = new PlayGrid();
            return _playGrid;
        }

        public void SetDimension(int dimX, int dimY)
        {
            if (GetPlayGrid()._grid == null) _grid = new Cell[dimX, dimY];
        }

        public void PresetMobs(List<Mob> l)
        {
            _actors = l ?? throw new ArgumentNullException(nameof(l));
        }
        
    }
}
