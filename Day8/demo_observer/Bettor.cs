using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_observer
{
    public class Bettor : Observer
    {
        private BetMatchData matchData;
        public Bettor(BetMatchData data)
        {
            matchData = data;
        }
        public override void Update()
        {
            matchData.Show();
            System.Console.WriteLine("Choose side to bet:");
            System.Console.WriteLine("1. " + matchData.Home);
            System.Console.WriteLine("2. " + matchData.Away);
            System.Console.WriteLine("0. Not bet");
            System.Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            System.Console.Write("Enter amount to bet: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Bet(choice, amount);
        }

        void Bet(int choice, int amount)
        {
            switch (choice)
            {
                case 1:
                {
                    matchData.HomeMoney += amount;
                    matchData.Notify();
                    break;
                }
                case 2:
                {
                    matchData.AwayMoney += amount;
                    matchData.Notify();
                    break;
                }
                case 0:
                {
                    System.Console.WriteLine("You'll regret this!!!");
                    break;
                }
                default: System.Console.WriteLine("Invalid option!"); break;
            }
        }
    }
}