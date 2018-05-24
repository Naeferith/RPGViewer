﻿using RPGViewer.Debug;
using RPGViewer.Game;
using RPGViewer.Game.Character;
using RPGViewer.Game.Character.Race;
using RPGViewer.Game.Mathematics;
using RPGViewer.Game.Playfield;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Desktop
{
    class Application
    {
        static void Main(string[] args)
        {
            Defence de = new Defence(30, 25, 26, 24);
            BaseSkills bs = new BaseSkills(20, 20, 15, 22, 19, 10);
            Traits tr = new Traits(9, 12, 7, 15, 12, 9, 11, 11, 18, 12, 11, 9, 16, 20, 13, 12, 12);
            PlayerCharacter WE = new PlayerCharacter("Wuihtentrein Eihset", new Human(), 174, 64, 180, de, 16, bs, tr);
            Player player = new Player("BA", WE);

            //Console.WriteLine(Math.Max(0, -2));

            PlayGrid play = PlayGrid.GetPlayGrid();
            play.SetDimension(10, 10);

            ASCIIPrint.DisplayPlayField();
            char a = Console.ReadKey(true).KeyChar;
        }
    }
}
