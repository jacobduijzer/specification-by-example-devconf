namespace BowlingGame.Core;

public class Spare : IRollType
{
    private readonly int[] _score;
    private readonly int _frameIndex;

    public Spare(int[] score, int frameIndex)
    {
        _score = score;
        _frameIndex = frameIndex;
    }
    
    public (int score, int index) Roll() =>
        (10 + SpareBonus(_frameIndex), 2);
    
    private int SpareBonus(int frameIndex) =>
        _score[frameIndex + 2];
}