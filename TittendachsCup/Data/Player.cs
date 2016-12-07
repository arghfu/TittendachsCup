using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TittendachsCup.Data
{
    public class Player
    {
        public string Name { get; set; }
        private Dictionary<Statistic, int> stats;

        public enum Statistic
        {
            ScoredGoals,
            ReceivedGoals,
            DifferenceGoals,
            Win,
            Draw,
            Loss,
            Points
        }

        public Player(string name)
        {
            this.Name = name;
            stats = new Dictionary<Statistic, int>
            {
                {Statistic.DifferenceGoals, 0},
                {Statistic.Draw, 0},
                {Statistic.Loss, 0},
                {Statistic.Points, 0},
                {Statistic.ReceivedGoals, 0},
                {Statistic.ScoredGoals, 0},
                {Statistic.Win, 0}
            };
        }


    }
}
