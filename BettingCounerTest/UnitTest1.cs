using Microsoft.VisualStudio.TestTools.UnitTesting;
using BettingCounter;
namespace BettingCounterTest
{
    [TestClass]
    public class UnitTest1
    {
        PunterFactory pFactory = new PunterFactory();
        Punter Jim;
        Horse[] horses = new Horse[2];
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestWinnerOutcome()
        {
            Horse.StartingPosition1 = 0;
            Horse.RacetrackLength1 = 50;
            int BettingAmount = 45;
            int HorseNumber = 1;
            int expectedWin = 90;
            int expectedLose = 0;
            horses[0] = new Horse() { HorsePictureBox = null };
            horses[1] = new Horse() { HorsePictureBox = null };
            Jim = pFactory.getPunter("Jim", null, null);
            Jim.Cash = BettingAmount;
            Jim.PlaceBet((int)BettingAmount, HorseNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < horses.Length; i++)
                {
                    if (Horse.Run(horses[i]))
                    {
                        win = i + 1;
                        Jim.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Jim.bet.horseNum == win)
            {
                Assert.AreEqual(expectedWin, Jim.Cash, "Account not credited correctly");
            }
            if (Jim.bet.horseNum != win)
            {
                Assert.AreEqual(expectedLose, Jim.Cash, "Account not debited correctly");

            }
        }
    }

}
