using RPGViewer.Debug;
using RPGViewer.Game;
using RPGViewer.Game.Abilities;
using RPGViewer.Game.Abilities.Range;
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
            Dictionary<Defences, int> de = new Dictionary<Defences, int> {
                {Defences.ArmorClass , 30},
                {Defences.Reflexes , 25},
                {Defences.Vigor , 26},
                {Defences.Will , 24},
            };
            BaseSkills bs = new BaseSkills(20, 20, 15, 22, 19, 10);
            Traits tr = new Traits(9, 12, 7, 15, 12, 9, 11, 11, 18, 12, 11, 9, 16, 20, 13, 12, 12);
            PlayerCharacter WE = new PlayerCharacter("Wuihtentrein Eihset", new Human(), 174, 64, 180, de, 16, 18, bs, tr);
            Player player = new Player("BA", WE);

            Ability ability = new Attack("Furie Brisefer", "Attaque pour KS", Ability.Avaliability.Meeting, new Melee(), new DiceExpression(4, 12, 8), null, false);



            //Mob mob = WE;
            Console.WriteLine(ability.ToString());

            //PlayGrid playGrid = PlayGrid.GetPlayGrid();
            //playGrid.Initialize(10, 10);
            //playGrid.AddActor(2, 3, WE);
            //ASCIIPrint.DisplayPlayField();


            /*Counter c = new Counter(2);
            c.ThresholdReached += c_ThresholdReached;
            c.Count--;
            c.Count--;
            c.Count--;*/




            char a = Console.ReadKey(true).KeyChar;
        }

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
    }

    class Counter
    {
        private int _c;

        public Counter(int c)
        {
            _c = c;
        }

        public int Count
        {
            get => _c;
            set
            {
                if (_c == 0) OnThresholdReached(new EventArgs());
                else _c = value;
            }
        }

        public event EventHandler ThresholdReached;

        protected virtual void OnThresholdReached(EventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }

        // provide remaining implementation for the class
    }

    class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
