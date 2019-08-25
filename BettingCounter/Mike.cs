using System.Windows.Forms;

namespace BettingCounter
{
    public class Mike : Punter
    {
        public Mike(Bet bet, Label MaximumBet, int Cash, Label label) : base(bet, MaximumBet, Cash, label)
        {
        }

        public override void setPunterName()
        {
            Name = "Mike";
        }
    }
}