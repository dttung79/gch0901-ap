using System;

namespace demo_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            BetMatchData mu_liv = new BetMatchData();
            mu_liv.Home = "MU";
            mu_liv.Away = "Liv";
            mu_liv.HomeWin = 3.0;
            mu_liv.AwayWin = 2.0;

            mu_liv.HomeMoney = 3000;
            mu_liv.AwayMoney = 2000;

            // mu_liv.Show();
            mu_liv.Notify();

            Bettor quan = new Bettor(mu_liv);
            House f88 = new House(mu_liv);

            mu_liv.Attach(quan);
            mu_liv.Attach(f88);

            mu_liv.Notify();
        }
    }
}
