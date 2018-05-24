using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGViewer.Game.Character;


namespace RPGViewer.Game
{
    /// <summary>
    /// Instance de joueur IRL
    /// </summary>
    class Player
    {
        private static readonly int BASE_ACTPTS = 5;
        /// <summary>
        /// IRL name
        /// </summary>
        private string _name;

        /// <summary>
        /// Character associated
        /// </summary>
        private PlayerCharacter _character;

        /// <summary>
        /// Current Action Points
        /// </summary>
        private int _actionPoints;

        public Player(string name, PlayerCharacter character)
        {
            this._name = name ?? throw new ArgumentNullException(nameof(name));
            this._character = character;
            this._actionPoints = BASE_ACTPTS;
        }

        public override string ToString()
        {
            return "Player " + _name + ' ' + _character.ToString();
        }
    }
}
