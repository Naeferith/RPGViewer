using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Exceptions
{
    public class PlayfieldInitializedException : RPGViewerException
    {
        public PlayfieldInitializedException() : base("Playfield has already been initialized.")
        {
        }
    }
}
