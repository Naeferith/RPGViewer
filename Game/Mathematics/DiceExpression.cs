using RPGViewer.Game.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGViewer.Game.Mathematics
{
    /// <summary>
    /// Represent any dice Expression of an <see cref="Ability"/>.
    /// A dice expression contains a certain amount of dices and a bonus. 
    /// The dice combinaisons or bonus can be null (e.g. Buff)
    /// </summary>
    class DiceExpression
    {
        /// <summary>
        /// The dice combinaison itself.
        /// The key represent the dice.
        /// The Value represent the number of dices.
        /// </summary>
        private Dictionary<int, int> _diceCombinaisons = new Dictionary<int, int>();

        /// <summary>
        /// Additional value of the expression.
        /// </summary>
        private int _bonus;

        /// <summary>
        /// Unique constructor for <see cref="DiceExpression"/>.
        /// </summary>
        /// <param name="list">By pair of element, represent the dice then the quantity. You can add a bonus value at the very end.</param>
        public DiceExpression(params int[] list)
        {
            for (int i = 0; i < list.Length / 2; i+=2) _diceCombinaisons.Add(list[i], list[i + 1]);

            //If the number of given arguments is even, we assume the bonus null
            _bonus = (list.Length % 2 == 0) ? 0 : list.Last();
        }

        /// <summary>
        /// Edit the <see cref="DiceExpression"/> by adding or removing some dices or the bonus.
        /// </summary>
        /// <param name="list">By pairs, the dice sides ; the delta of dices to be applied.</param>
        public void Alterate(params int[] list)
        {
            for (int i = 0; i < list.Length / 2; i += 2)
            {
                if (_diceCombinaisons.ContainsKey(list[i])) _diceCombinaisons[list[i]] = Math.Max(0, _diceCombinaisons[list[i]] + list[i + 1]);
                else _diceCombinaisons.Add(list[i], list[i + 1]);
            }
            _bonus = (list.Length % 2 == 0) ? _bonus : Math.Max(0, _bonus + list.Last());
        }

        /// <summary>
        /// Evaluate the expression randomly
        /// </summary>
        /// <returns>The random generated value</returns>
        public int Evaluate()
        {
            Random rnd = new Random();
            int sum = 0;
            foreach (KeyValuePair<int, int> entry in _diceCombinaisons)
            {
                for (int i = 1; i <= entry.Value; i++) sum += (rnd.Next(1, entry.Key + 1));
            }
            return sum + _bonus;
        }

        /// <summary>
        /// Calculate the maximum value.
        /// </summary>
        /// <returns>The maximum value of the expression.</returns>
        public int Max()
        {
            int sum = 0;
            foreach (KeyValuePair<int, int> entry in _diceCombinaisons) sum += (entry.Key * entry.Value);
            return sum + _bonus;
        }
    }
}
