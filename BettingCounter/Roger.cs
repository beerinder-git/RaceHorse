using System.Windows.Forms;
using System.Windows.Forms;

namespace BettingCounter
{
    using System;

    public class Roger : Punter
    {
        public Roger(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Roger";
        }
    }
}