using System;
using System.Collections.Generic;

namespace demo_observer
{
    public class BetMatchData
    {
        public string Home { get; set; }
        public string Away { get; set; }

        public double HomeWin { get; set; }
        public double AwayWin { get; set; }
        public int HomeMoney { get; set; }
        public int AwayMoney { get; set; }

        private List<Observer> observers;

        public BetMatchData()
        {
            observers = new List<Observer>();
        }

        public void Notify()
        {
            foreach (Observer obs in observers)
            {
                obs.Update();
            }
        }

        public void Attach(Observer obs)
        {
            observers.Add(obs);
        }

        public void Detach(Observer obs)
        {
            observers.Remove(obs);
        }

        public void Show()
        {
            System.Console.WriteLine(String.Format("Teams: {0, 15} - {1, -15}", Home, Away));
            System.Console.WriteLine(String.Format("Bet  : {0, 15} - {1, -15}", HomeWin, AwayWin));
        }
        
    }
}