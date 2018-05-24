using RPGViewer.Game.Playfield;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Debug
{
    public static class ASCIIPrint
    {

        public static void DisplayPlayField()
        {
            PlayGrid p = PlayGrid.GetPlayGrid();
            int X = p.Grid.GetLength(0);
            int Y = p.Grid.GetLength(1);

            string buffer;

            for (int i = 0; i < Y; i++)
            {
                buffer = "|";
                Console.WriteLine('+' + new String('-', X * 2 - 1) + '+');
                for (int j = 0; j < X; j++)
                {
                    buffer += " |";
                }
                Console.WriteLine(buffer);
            }
            Console.WriteLine('+' + new String('-', X * 2 - 1) + '+');
        }
    }
}
