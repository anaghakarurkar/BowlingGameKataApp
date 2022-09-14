using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BowlingGameKata
{
    public  class Frame
    {
        public static int previousTotalScore;
        public  BowlingTurn FirstTurn { get; private set; }
        public  BowlingTurn SecondTurn { get; private set; }
        public int CurrentFrameFinalScore { get; private set; }

        private enum FrameType
        {
            STRIKE,
            SPARE,
            OPEN
        }
        private FrameType _frameType;
        public Frame()
        {
            FirstTurn = new();
            SecondTurn = new();
            _frameType = FrameType.OPEN;
        }

        public void FirstGo(int pinsKnocked)
        {
            if (pinsKnocked >= 0 && pinsKnocked <= 10)
            {
                FirstTurn.Score = pinsKnocked;
                _frameType = (pinsKnocked == 10) ? FrameType.STRIKE: FrameType.OPEN;
            }
            else
            {
                throw new Exception("Invalid number of pins");
            }
        }

        public void SecondGo(int pinsKnocked)
        {
            if (_frameType == FrameType.STRIKE)
                throw new Exception("You Scored STRIKE In First Turn! You Cant Play Second Turn");

           if(FirstTurn != null && (FirstTurn.Score + pinsKnocked <=10))
            {
                SecondTurn.Score = pinsKnocked;
                _frameType = (pinsKnocked + FirstTurn.Score == 10) ? FrameType.SPARE : FrameType.OPEN; 
            }
        }
       
    }
}
