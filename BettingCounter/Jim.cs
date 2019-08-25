using System.Windows.Forms;

namespace BettingCounter
{
    using System;

    public class Jim : Punter
    {
        public Jim(Bet MyBet, Label MaximumBet, int Cash, Label MyLabel) : base(MyBet, MaximumBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "Jim";
        }
    }
}