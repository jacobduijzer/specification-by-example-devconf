namespace BowlingGame.Core;

public class Normal : IRollType
{
    private readonly int[] _score;
    private readonly int _frameIndex;

    public Normal(int[] score, int frameIndex)
    {
        _score = score;
        _frameIndex = frameIndex;
    }

    public (int score, int index) Roll() =>
        (FrameScore(_frameIndex), 2);
    
    private int FrameScore(int frameIndex) =>
        _score[frameIndex] + _score[frameIndex + 1];
}