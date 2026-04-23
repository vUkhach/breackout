using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakout
{
    public class GameResult
    {
        public int Id { get; set; } 
        public int Score { get; set; }
        public int TimeSeconds { get; set; }
        public DateTime Date { get; set; }
    }
}
