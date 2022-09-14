namespace BowlingGameKata;
public class BowlingGame
{
    private Frame[] _frames; 
    public bool HasSteppedOnBlackLine; // it will be considered as faul
    private int _currentFrameID;
    public BowlingGame()
    {
        _frames = new Frame[10];
        HasSteppedOnBlackLine = false;
        _currentFrameID = -1;
    }

    public void NextFrame(int firstGo, int secondGo)
    {
        _frames[_currentFrameID] = new Frame();
        _frames[_currentFrameID].FirstGo(firstGo);
        _frames[_currentFrameID].SecondGo(secondGo);
        _currentFrameID++;
    }

   




}
