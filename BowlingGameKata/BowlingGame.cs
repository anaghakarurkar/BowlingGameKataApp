namespace BowlingGameKata;
public class BowlingGame
{
    private Frame[] _frames; 
    public bool HasSteppedOnBlackLine;
    private int _currentFrameID;
    public BowlingGame()
    {
        _frames = new Frame[10];
        HasSteppedOnBlackLine = false;
        _currentFrameID = 0;
    }

    public void NextFrame()
    {
        _frames[_currentFrameID + 1] = new Frame();
        _currentFrameID++;
    }

   




}
