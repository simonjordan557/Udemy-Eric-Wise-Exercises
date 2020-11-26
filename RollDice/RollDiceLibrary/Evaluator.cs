using System;
using System.Collections.Generic;
using System.Text;

namespace RollDiceLibrary
{
    public class Evaluator
    {
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (die1 != die2 || !noDoubles) return die1 + die2;
            else return die1 + die2 == 12 ? 7 : die1 + die2 + 1;
        }
    }
}
