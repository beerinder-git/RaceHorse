using System;
using System.Windows.Forms;

namespace BettingCounter
{
    public class PunterFactory
    {
        public Punter getPunter(String Name,Label MaximumBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "jim":
                     p = new Jim(null, MaximumBet, 50, bet);
                    break;
                   
                case "roger":
                    p =  new Roger(null, MaximumBet, 50, bet);
                    break;
                    
                case "mike":
                    p = new Mike(null, MaximumBet, 50, bet);
                    break;
                   
                default:
                    p =  null ;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}