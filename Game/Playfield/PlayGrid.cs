using RPGViewer.Game.Character;
using RPGViewer.Game.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Playfield
{
    public class PlayGrid : IPlayfield
    {
        private static PlayGrid _playGrid = null;
        private Cell[,] _grid = null;
        private bool _IsStarted = false;
        private bool _IsInitialized = false;
        private Player _currentPlayer = null;
        private List<Mob> _actors = new List<Mob>();

        public Cell[,] Grid { get { return _grid;} }

        public static PlayGrid GetPlayGrid()
        {
            if (_playGrid == null) _playGrid = new PlayGrid();
            return _playGrid;
        }

        private void SetDimension(int dimX, int dimY)
        {
            if (_grid == null)
            {
                _grid = new Cell[dimX, dimY];
                for (int x = 0; x < dimX; x++)
                {
                    for (int y = 0; y < dimY; y++) _grid[x, y] = new Cell();
                }
            }
        }

        public void PresetMobs(List<Mob> l)
        {
            _actors = l ?? throw new ArgumentNullException(nameof(l));
        }

        /// <summary>
        /// Initialize the <see cref="PlayGrid"/> with it's dimensions
        /// </summary>
        /// <param name="dimX">Dimension on the x axis</param>
        /// <param name="dimY">Dimension on the y axis</param>
        public void Initialize(int dimX, int dimY)
        {
            if (_IsInitialized) throw new PlayfieldInitializedException();
            SetDimension(dimX, dimY);
            TurnStarted += p_OnTurnStarted;
            TurnEnded += p_OnTurnEnded;
            _IsInitialized = true;
        }

        /// <summary>
        /// Add a <see cref="Mob"/> on the <see cref="PlayGrid"/>
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The x coordinate</param>
        /// <param name="mob">The actor</param>
        public void AddActor(int x, int y, Mob mob)
        {
            if (_grid[x, y].Actor != null) throw new CellOccupiedException();
            _grid[x, y].Actor = mob;
        }

        /// <summary>
        /// Remove a <see cref="Mob"/> from the <see cref="PlayGrid"/>
        /// </summary>
        /// <param name="mob">The actor to be removed</param>
        public void RemoveActor(Mob mob)
        {
            foreach (Cell cell in _grid)
            {
                if (cell.Actor != null && cell.Actor.Equals(mob)) cell.Actor = null;
            }
        }

        #region Events

        public event EventHandler<PlayfieldEventArgs> TurnStarted;
        public event EventHandler<PlayfieldEventArgs> TurnEnded;
        public event EventHandler<PlayfieldEventArgs> TargetReached;
        public event EventHandler<PlayfieldEventArgs> TargetMissed;

        public void OnTurnStarted(PlayfieldEventArgs e)
        {
            TurnStarted?.Invoke(this, e);
        }

        public void OnTurnEnded(PlayfieldEventArgs e)
        {
            TurnEnded?.Invoke(this, e);
        }

        public void OnTargetReached(PlayfieldEventArgs e)
        {
            TargetReached?.Invoke(this, e);
        }

        public void OnTargetMissed(PlayfieldEventArgs e)
        {
            TargetMissed?.Invoke(this, e);
        }
        
        static void p_OnTurnStarted(object sender, PlayfieldEventArgs e)
        {

        }

        static void p_OnTurnEnded(object sender, PlayfieldEventArgs e)
        {

        }

        static void p_OnTargetReached(object sender, PlayfieldEventArgs e)
        {

        }

        static void p_OnTargetMissed(object sender, PlayfieldEventArgs e)
        {

        }

        #endregion
    }
}
