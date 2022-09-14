using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BowlingGameKata
{
    public class Frame
    {
        public static int PreviousTotalScore { get; set;}
        public int FirstTurnScore { get; private set; }
        public int SecondTurnScore { get; private set; }
        public int CurrentFrameFinalScore { get; private set; }
        private const int TURN_NOT_STARTED = -1;
        private enum FrameType
        {
            STRIKE,
            SPARE,
            OPEN
        }
        private FrameType _frameType;
        public Frame()
        {
            FirstTurnScore = TURN_NOT_STARTED;
            SecondTurnScore = TURN_NOT_STARTED;
            _frameType = FrameType.OPEN; 
        }

        public int FirstGo(int pinsKnocked)
        {
            if (pinsKnocked >= 0 && pinsKnocked <= 10)
            {
                FirstTurnScore = pinsKnocked;
                _frameType = (pinsKnocked == 10) ? FrameType.STRIKE : FrameType.OPEN;
            }
            else
            {
                throw new Exception("Invalid number of pins");
            }
            return FirstTurnScore;
        }

        public int SecondGo(int pinsKnocked)
        {
            if (_frameType == FrameType.STRIKE)
            {
                SecondTurnScore = 0;
                return 0;
            }
            if (FirstTurnScore != TURN_NOT_STARTED && (FirstTurnScore+ pinsKnocked <= 10))
            {
                SecondTurnScore = pinsKnocked;
                _frameType = (pinsKnocked + FirstTurnScore == 10) ? FrameType.SPARE : FrameType.OPEN;
            }
            return SecondTurnScore;
        }

       private int CalculateScore(int tempScore, FrameType type)
        {
            if(type == FrameType.OPEN || type == FrameType.SPARE)
            PreviousTotalScore += tempScore;

            switch(type)
            {
                case FrameType.STRIKE:
                    // this frame score 10 + next turn score
                    break;
                    case FrameType.OPEN:
                    
                    break;
                    case FrameType.SPARE:
                    break;
            }

            return PreviousTotalScore;
        }

    }
}
