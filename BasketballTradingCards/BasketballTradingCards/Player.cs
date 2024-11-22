using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTradingCards
{
    public class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public string PhotoPath { get; set; }
        public int PointsPerGame { get; set; }
        public int AssistsPerGame { get; set; }
        public int ReboundsPerGame { get; set; }
        public double FieldGoalPercentage { get; set; }
        public double FreeThrowPercentage { get; set; }
    }
}