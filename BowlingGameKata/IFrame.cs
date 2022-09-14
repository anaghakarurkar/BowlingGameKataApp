using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public interface IFrame
    {
        public static int PreviousTotalScore { set; get;}
        public int FirstTurnScore { get; set; }
        public int SecondTurnScore { get; set; }
        public int CurrentFrameFinalScore { get; private set; }
    }
}
