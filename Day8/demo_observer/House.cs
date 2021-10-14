using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_observer
{
    public class House : Observer
    {
        private BetMatchData matchData;

        public House(BetMatchData data)
        {
            matchData = data;
        }

        public override void Update()
        {
            matchData.Show();
            System.Console.WriteLine(String.Format("{0, 15} - {1, -15}", matchData.HomeMoney, 
                                                                         matchData.AwayMoney));
            double betRate = (double) matchData.HomeWin / matchData.AwayWin;
            double moneyRate = (double) matchData.HomeMoney / matchData.AwayMoney;

            if (moneyRate < betRate)
            {
                matchData.AwayWin -= 0.05;
                matchData.HomeWin += 0.05;
                System.Console.WriteLine("Bet rate change!");
            }
            else if (moneyRate > betRate)
            {
                matchData.HomeWin -= 0.05;
                matchData.AwayWin += 0.05;
                System.Console.WriteLine("Bet rate change!");
            }
            else {}
        }
    }
}